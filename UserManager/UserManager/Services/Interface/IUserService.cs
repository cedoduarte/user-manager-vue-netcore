using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.Command.ChangePassword;
using UserManager.CQRS.Users.Command.CreateUser;
using UserManager.CQRS.Users.Command.Login;
using UserManager.CQRS.Users.Command.RestoreUser;
using UserManager.CQRS.Users.Command.UpdateUser;
using UserManager.CQRS.Users.Query.GetUserList;
using UserManager.CQRS.Users.ViewModel;

namespace UserManager.Services.Interface
{
    public interface IUserService
    {
        Task<ActionResult<bool>> ChangePassword(ChangePasswordCommand command);
        Task<ActionResult<UserViewModel>> CreateUser(CreateUserCommand command);
        Task<ActionResult<UserViewModel>> DeleteUser(int userId);
        Task<ActionResult<UserViewModel>> Login(LoginUserCommand command);
        Task<ActionResult<UserViewModel>> RestoreUser(RestoreUserCommand command);
        Task<ActionResult<UserViewModel>> UpdateUser(UpdateUserCommand command);
        Task<ActionResult<UserViewModel>> GetUserById(int userId);
        Task<ActionResult<IEnumerable<UserViewModel>>> GetUserList(GetUserListQuery query);
    }
}
