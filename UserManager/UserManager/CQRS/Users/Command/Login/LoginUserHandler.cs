using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Models;
using UserManager.Utils;

namespace UserManager.CQRS.Users.Command.Login
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, ActionResult<UserViewModel>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public LoginUserHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ActionResult<UserViewModel>> Handle(LoginUserCommand command, CancellationToken cancel)
        {
            try
            {
                ValidateInput(command);
                User existingUser = await CheckExistance(command, cancel);
                UserViewModel loggedUser = _mapper.Map<UserViewModel>(existingUser);
                return new OkObjectResult(loggedUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<User> CheckExistance(LoginUserCommand command, CancellationToken cancel)
        {
            string passwordHash = Util.GetSha256(command.Password);
            User loggedUser = await _dbContext.Users
                .Where(user => user.Username == command.Username
                               && user.PasswordHash == passwordHash
                               && !user.IsDeleted)
                .FirstOrDefaultAsync(cancel);
            if (loggedUser is null)
            {
                throw new Exception("Username or password are not correct!");
            }
            return loggedUser;
        }

        private void ValidateInput(LoginUserCommand command)
        {
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
                throw new Exception(Shared.Constants.GetPasswordError(command.Password));
            }
        }
    }
}
