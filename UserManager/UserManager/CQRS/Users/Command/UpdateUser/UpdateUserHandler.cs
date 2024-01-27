using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Models;
using UserManager.Utils;

namespace UserManager.CQRS.Users.Command.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, ActionResult<UserViewModel>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public UpdateUserHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ActionResult<UserViewModel>> Handle(UpdateUserCommand command, CancellationToken cancel)
        {
            try
            {
                ValidateInput(command);
                User selectedUser = await CheckExistanceById(command.Id, cancel);
                await CheckConflicts(command, cancel);
                await UpdateRecord(selectedUser, command, cancel);
                UserViewModel updatedUser = _mapper.Map<UserViewModel>(selectedUser);
                return new OkObjectResult(updatedUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<bool> CheckConflicts(UpdateUserCommand command, CancellationToken cancel)
        {
            int selectedUserId = command.Id;
            User userByEmail = await _dbContext.Users
                .Where(user => user.Email == command.Email)
                .FirstOrDefaultAsync(cancel);
            User userByLinkedInProfileUrl = await _dbContext.Users
                .Where(user => user.LinkedInProfileUrl == command.LinkedInProfileUrl)
                .FirstOrDefaultAsync(cancel);
            if (selectedUserId == userByEmail.Id)
            {
                if (selectedUserId == userByLinkedInProfileUrl.Id)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"The LinkedIn profile URL is already in use for another user!");
                }
            }
            else
            {
                throw new Exception($"The Email is already in use for another user!");
            }
        }

        private async Task<bool> UpdateRecord(User existingUser, UpdateUserCommand command, CancellationToken cancel)
        {
            existingUser.FirstName = command.FirstName;
            existingUser.LastName = command.LastName;
            existingUser.Country = command.Country;
            existingUser.Province = command.Province;
            existingUser.City = command.City;
            existingUser.ZipCode = command.ZipCode;
            existingUser.Birthdate = command.Birthdate;
            existingUser.PhoneNumber = command.PhoneNumber;
            existingUser.Email = command.Email;
            existingUser.LinkedInProfileUrl = command.LinkedInProfileUrl;
            existingUser.LastModification = DateTime.Now;
            _dbContext.Users.Update(existingUser);
            await _dbContext.SaveChangesAsync(cancel);
            return true;
        }

        private async Task<User> CheckExistanceById(int userId, CancellationToken cancel)
        {
            User selectedUser = await _dbContext.Users
                .Where(user => user.Id == userId && !user.IsDeleted)
                .FirstOrDefaultAsync(cancel);
            if (selectedUser is null)
            {
                throw new Exception($"{nameof(User)} with ID {userId} does not exist!");
            }
            return selectedUser;
        }

        private void ValidateInput(UpdateUserCommand command)
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
