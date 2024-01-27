using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserManager.Models;

namespace UserManager.Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.FirstName).IsRequired().HasColumnType("VARCHAR(256)");
            builder.Property(user => user.LastName).IsRequired().HasColumnType("VARCHAR(256)");
            builder.Property(user => user.Country).IsRequired().HasColumnType("VARCHAR(256)");
            builder.Property(user => user.Province).IsRequired().HasColumnType("VARCHAR(256)");
            builder.Property(user => user.City).IsRequired().HasColumnType("VARCHAR(256)");
            builder.Property(user => user.ZipCode).IsRequired().HasColumnType("VARCHAR(16)");
            builder.Property(user => user.Birthdate).IsRequired().HasColumnType("DATETIME");
            builder.Property(user => user.PhoneNumber).IsRequired().HasColumnType("VARCHAR(64)");
            builder.Property(user => user.Email).IsRequired().HasColumnType("VARCHAR(256)");
            builder.Property(user => user.Username).IsRequired().HasColumnType("VARCHAR(256)");
            builder.Property(user => user.PasswordHash).IsRequired().HasColumnType("VARCHAR(128)");
            builder.Property(user => user.LinkedInProfileUrl).IsRequired().HasColumnType("VARCHAR(256)");
            builder.Property(user => user.IsDeleted).IsRequired().HasColumnType("TINYINT(1)");
            builder.Property(user => user.LastModification).IsRequired().HasColumnType("DATETIME");
        }
    }
}
