using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Models;
using UserManager.Utils;

namespace UserManager.CQRS.Users.Command.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, ActionResult<UserViewModel>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateUserHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ActionResult<UserViewModel>> Handle(CreateUserCommand command, CancellationToken cancel)
        {
            try
            {
                ValidateInput(command);
                await CheckExistance(command, cancel);
                UserViewModel createdUser = await InsertRecord(command, cancel);
                return new OkObjectResult(createdUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<UserViewModel> InsertRecord(CreateUserCommand command, CancellationToken cancel)
        {
            var createdUser = await _dbContext.Users.AddAsync(new User()
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Country = command.Country,
                Province = command.Province,
                City = command.City,
                ZipCode = command.ZipCode,
                Birthdate = command.Birthdate,
                PhoneNumber = command.PhoneNumber,
                Email = command.Email,
                Username = command.Username,
                PasswordHash = Util.GetSha256(command.Password),
                LinkedInProfileUrl = command.LinkedInProfileUrl
            }, cancel);
            await _dbContext.SaveChangesAsync(cancel);
            return _mapper.Map<UserViewModel>(createdUser.Entity);
        }

        private async Task<bool> CheckExistance(CreateUserCommand command, CancellationToken cancel)
        {
            User existingUser = await _dbContext.Users
                .Where(user => string.Equals(user.Email, command.Email)
                            || string.Equals(user.Username, command.Username))
                .FirstOrDefaultAsync(cancel);
            if (existingUser is not null)
            {
                throw new Exception("The username or email already exist, try with other input data!");
            }
            return true;
        }

        private void ValidateInput(CreateUserCommand command)
        {
            if (string.IsNullOrEmpty(command.FirstName))
            {
                throw new Exception("The first name cannot be empty!");
            }
            if (string.IsNullOrEmpty(command.LastName))
            {
                throw new Exception("The last name cannot be empty!");
            }
            if (string.IsNullOrEmpty(command.Country))
            {
                throw new Exception("The country cannot be empty!");
            }
            if (string.IsNullOrEmpty(command.Province))
            {
                throw new Exception("The province cannot be empty!");
            }
            if (string.IsNullOrEmpty(command.City))
            {
                throw new Exception("The city cannot be empty!");
            }
            if (string.IsNullOrEmpty(command.ZipCode))
            {
                throw new Exception("The zip code cannot be empty!");
            }
            if (string.IsNullOrEmpty(command.PhoneNumber))
            {
                throw new Exception("The phone number cannot be empty!");
            }
            if (string.IsNullOrEmpty(command.Email))
            {
                throw new Exception("The email cannot be empty!");
            }
            if (!Util.IsValidEmail(command.Email))
            {
                throw new Exception("The email is not valid!");
            }
            if (string.IsNullOrEmpty(command.Username))
            {
                throw new Exception("The username cannot be empty!");
            }
            if (!Util.IsValidUsername(command.Username))
            {
                throw new Exception("The username is not valid!");
            }
            if (string.IsNullOrEmpty(command.Password))
            {
                throw new Exception("The password cannot be empty!");
            }
            if (!Util.IsValidPassword(command.Password))
            {
                throw new Exception(Shared.Constants.GetPasswordError());
            }
            if (string.IsNullOrEmpty(command.ConfirmPassword))
            {
                throw new Exception("The confirmed password cannot be empty!");
            }
            if (!string.Equals(command.Password, command.ConfirmPassword))
            {
                throw new Exception("The password needs to be confirmed correctly!");
            }
            if (string.IsNullOrEmpty(command.LinkedInProfileUrl))
            {
                throw new Exception("The LinkedIn profile url cannot be empty!");
            }
            if (!Util.IsValidUrl(command.LinkedInProfileUrl))
            {
                throw new Exception("The LinkedIn profile url is not valid!");
            }
        }
    }
}
