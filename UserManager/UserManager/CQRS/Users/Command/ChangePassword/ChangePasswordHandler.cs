using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManager.Models;
using UserManager.Utils;

namespace UserManager.CQRS.Users.Command.ChangePassword
{
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordCommand, ActionResult<bool>>
    {
        private readonly AppDbContext _dbContext;

        public ChangePasswordHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActionResult<bool>> Handle(ChangePasswordCommand command, CancellationToken cancel)
        {
            try
            {
                ValidateInput(command);
                User selectedUser = await CheckExistance(command, cancel);
                return new OkObjectResult(await UpdateRecord(selectedUser, command, cancel));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<bool> UpdateRecord(User selectedUser, ChangePasswordCommand command, CancellationToken cancel)
        {
            string newPasswordHash = Util.GetSha256(command.NewPassword);
            selectedUser.PasswordHash = newPasswordHash;
            selectedUser.LastModification = DateTime.Now;
            _dbContext.Users.Update(selectedUser);
            await _dbContext.SaveChangesAsync(cancel);
            return true;
        }

        private async Task<User> CheckExistance(ChangePasswordCommand command, CancellationToken cancel)
        {
            string oldPasswordHash = Util.GetSha256(command.OldPassword);
            User selectedUser = await _dbContext.Users
                .Where(user => user.Id == command.Id && user.PasswordHash == oldPasswordHash && !user.IsDeleted)
                .FirstOrDefaultAsync(cancel);
            if (selectedUser is null)
            {
                throw new Exception($"{nameof(User)} with ID {command.Id} does not exist or old password is wrong!");
            }
            return selectedUser;
        }

        private void ValidateInput(ChangePasswordCommand command)
        {
            if (string.IsNullOrEmpty(command.OldPassword))
            {
                throw new Exception("The old password cannot be empty!");
            }
            if (string.IsNullOrEmpty(command.NewPassword))
            {
                throw new Exception("The new password cannot be empty!");
            }
            if (!Util.IsValidPassword(command.OldPassword))
            {
                throw new Exception(Shared.Constants.GetPasswordError("old password"));
            }
            if (!Util.IsValidPassword(command.NewPassword))
            {
                throw new Exception(Shared.Constants.GetPasswordError("new password"));
            }
            if (!string.Equals(command.NewPassword, command.ConfirmedPassword))
            {
                throw new Exception("The password needs to be confirmed correctly!");
            }
        }
    }
}
