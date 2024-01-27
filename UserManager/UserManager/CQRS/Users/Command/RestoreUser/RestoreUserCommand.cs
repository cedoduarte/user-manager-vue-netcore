using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.ViewModel;

namespace UserManager.CQRS.Users.Command.RestoreUser
{
    public class RestoreUserCommand : IRequest<ActionResult<UserViewModel>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
