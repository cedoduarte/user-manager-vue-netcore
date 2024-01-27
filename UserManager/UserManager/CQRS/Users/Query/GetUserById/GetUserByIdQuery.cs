using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.ViewModel;

namespace UserManager.CQRS.Users.Query.GetUserById
{
    public class GetUserByIdQuery : IRequest<ActionResult<UserViewModel>>
    {
        public int Id { get; set; }
    }
}
