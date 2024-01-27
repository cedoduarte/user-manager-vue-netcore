using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.Command.ChangePassword;
using UserManager.CQRS.Users.Command.CreateUser;
using UserManager.CQRS.Users.Command.Login;
using UserManager.CQRS.Users.Command.RestoreUser;
using UserManager.CQRS.Users.Command.UpdateUser;
using UserManager.CQRS.Users.Query.GetUserList;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Services.Interface;

namespace UserManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("change-password")]
        public async Task<ActionResult<bool>> ChangePassword([FromBody] ChangePasswordCommand command)
        {
            try
            {
                return await _userService.ChangePassword(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("create")]
        public async Task<ActionResult<UserViewModel>> CreateUser([FromBody] CreateUserCommand command)
        { 
            try
            {
                return await _userService.CreateUser(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("delete/{userId}")]
        public async Task<ActionResult<UserViewModel>> DeleteUser([FromRoute] int userId)
        {
            try
            {
                return await _userService.DeleteUser(userId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserViewModel>> Login([FromBody] LoginUserCommand command)
        {
            try
            {
                return await _userService.Login(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("restore")]
        public async Task<ActionResult<UserViewModel>> RestoreUser([FromBody] RestoreUserCommand command)
        {
            try
            {
                return await _userService.RestoreUser(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("update")]
        public async Task<ActionResult<UserViewModel>> UpdateUser([FromBody] UpdateUserCommand command)
        {
            try
            {
                return await _userService.UpdateUser(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<UserViewModel>> GetUserById([FromRoute] int userId)
        {
            try
            {
                return await _userService.GetUserById(userId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("user-list")]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetUserList([FromQuery] GetUserListQuery query)
        {
            try
            {
                return await _userService.GetUserList(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
