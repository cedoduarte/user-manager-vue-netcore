using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.ViewModel;

namespace UserManager.CQRS.Users.Command.Login
{
    public class LoginUserCommand : IRequest<ActionResult<UserViewModel>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
