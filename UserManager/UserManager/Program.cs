using AutoMapper;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;
using UserManager.Models;
using UserManager.Models.Interface;
using UserManager.Services;
using UserManager.Services.Interface;

namespace UserManager
{
    public class Program
    {
        private const string ConnectionStringName = "UserManager";
        private const string ApiVersion = "v1";
        private const string ApiTitle = "UserManager";
        private const string ApiDescription = "User manager .NET Core Web API";
        private const string ApiTermsOfServiceUrl = "https://www.example.com/terms";
        private const string ApiContactName = "Carlos Enrique Duarte Ortiz";
        private const string ApiContactUrl = "https://www.example.com/contact";
        private const string ApiLicense = "Free License";
        private const string ApiLicenseUrl = "https://www.example.com/license";
        private const string ApiSwaggerEndpoint = "/swagger/v1/swagger.json";

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
            builder.Services.AddSingleton<IConfiguration>(notUsed =>
            {
                string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                var configurationBuilder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile($"appsettings.Local.json", true)
                    .AddEnvironmentVariables();
                return configurationBuilder.Build();
            });
            builder.Services.Configure<IISServerOptions>(options =>
            {
                options.MaxRequestBodySize = int.MaxValue;
            });
            builder.Services.Configure<FormOptions>(options =>
            {
                options.ValueLengthLimit = int.MaxValue;
                options.MultipartBodyLengthLimit = int.MaxValue;
                options.MultipartHeadersLengthLimit = int.MaxValue;
            });
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(ApiVersion, new OpenApiInfo()
                {
                    Version = ApiVersion,
                    Title = ApiTitle,
                    Description = ApiDescription,
                    TermsOfService = new Uri(ApiTermsOfServiceUrl),
                    Contact = new OpenApiContact()
                    {
                        Name = ApiContactName,
                        Url = new Uri(ApiContactUrl)
                    },
                    License = new OpenApiLicense()
                    {
                        Name = ApiLicense,
                        Url = new Uri(ApiLicenseUrl)
                    }
                });
            });
            builder.Services.AddTransient<IAppDbContext, AppDbContext>();
            builder.Services.AddTransient<IUserService, UserService>();
            var autoMapperConfiguration = new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new MappingProfile());
            });
            IMapper autoMapper = autoMapperConfiguration.CreateMapper();
            builder.Services.AddSingleton(autoMapper);
            builder.Services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);
            });
            string databaseConnection = builder.Configuration.GetConnectionString(ConnectionStringName);
            builder.Services.AddDbContext<IAppDbContext, AppDbContext>(options =>
            {
                options.UseMySql(databaseConnection, ServerVersion.AutoDetect(databaseConnection), sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(AppDbContext).GetTypeInfo().Assembly.GetName().Name);
                });
            });
            builder.Services.AddMvc();
            var app = builder.Build();
            using (IServiceScope scope = app.Services.CreateScope())
            {
                try
                {
                    AppDbContext dbContext = (AppDbContext)scope.ServiceProvider.GetService<IAppDbContext>();
                    dbContext.Database.Migrate();
                    DbSeeder.DoSeeding(dbContext);
                }
                catch (Exception ex)
                {
                    ILogger<Program> logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating or initializing the database");
                }
            }
            app.UseCors(options =>
                options.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            app.UseStaticFiles();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint(ApiSwaggerEndpoint, ApiVersion);
                });
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}