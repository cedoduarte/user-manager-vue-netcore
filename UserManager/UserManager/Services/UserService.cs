using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.Command.ChangePassword;
using UserManager.CQRS.Users.Command.CreateUser;
using UserManager.CQRS.Users.Command.DeleteUser;
using UserManager.CQRS.Users.Command.Login;
using UserManager.CQRS.Users.Command.RestoreUser;
using UserManager.CQRS.Users.Command.UpdateUser;
using UserManager.CQRS.Users.Query.GetUserById;
using UserManager.CQRS.Users.Query.GetUserList;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Services.Interface;

namespace UserManager.Services
{
    public class UserService : IUserService
    {
        private readonly IMediator _mediator;

        public UserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ActionResult<bool>> ChangePassword(ChangePasswordCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ActionResult<UserViewModel>> CreateUser(CreateUserCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ActionResult<UserViewModel>> DeleteUser(int userId)
        {
            try
            {
                return await _mediator.Send(new DeleteUserCommand()
                {
                    Id = userId
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ActionResult<UserViewModel>> Login(LoginUserCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ActionResult<UserViewModel>> RestoreUser(RestoreUserCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ActionResult<UserViewModel>> UpdateUser(UpdateUserCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ActionResult<UserViewModel>> GetUserById(int userId)
        {
            try
            {
                return await _mediator.Send(new GetUserByIdQuery()
                {
                    Id = userId
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetUserList(GetUserListQuery query)
        {
            try
            {
                return await _mediator.Send(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
