using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.ViewModel;

namespace UserManager.CQRS.Users.Command.DeleteUser
{
    public class DeleteUserCommand : IRequest<ActionResult<UserViewModel>>
    {
        public int Id { get; set; }
    }
}
