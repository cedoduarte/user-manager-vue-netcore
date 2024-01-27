using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Models;
using UserManager.Utils;

namespace UserManager.CQRS.Users.Command.RestoreUser
{
    public class RestoreUserHandler : IRequestHandler<RestoreUserCommand, ActionResult<UserViewModel>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public RestoreUserHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ActionResult<UserViewModel>> Handle(RestoreUserCommand command, CancellationToken cancel)
        {
            try
            {
                ValidateInput(command);
                User selectedUser = await CheckExistanceByEmail(command.Email, cancel);
                await UpdateRecord(selectedUser, cancel);
                UserViewModel restoredUser = _mapper.Map<UserViewModel>(selectedUser);
                return new OkObjectResult(restoredUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<bool> UpdateRecord(User selectedUser, CancellationToken cancel)
        {
            selectedUser.IsDeleted = false;
            selectedUser.LastModification = DateTime.Now;
            _dbContext.Users.Update(selectedUser);
            await _dbContext.SaveChangesAsync(cancel);
            return true;
        }

        private async Task<User> CheckExistanceByEmail(string userEmail, CancellationToken cancel)
        {
            User selectedUser = await _dbContext.Users
                .Where(user => user.Email == userEmail && user.IsDeleted)
                .FirstOrDefaultAsync(cancel);
            if (selectedUser is null)
            {
                throw new Exception($"{nameof(User)} with Email {userEmail} does not exists!");
            }
            return selectedUser;
        }

        private void ValidateInput(RestoreUserCommand command)
        {
            if (string.IsNullOrEmpty(command.Email))
            {
                throw new Exception("The email cannot be empty!");
            }
            if (!Util.IsValidEmail(command.Email))
            {
                throw new Exception("The email is not valid!");
            }
            if (string.IsNullOrEmpty(command.Password))
            {
                throw new Exception("The password cannot be empty!");
            }
            if (!Util.IsValidPassword(command.Password))
            {
                throw new Exception(Shared.Constants.GetPasswordError("old password"));
            }
        }
    }
}
