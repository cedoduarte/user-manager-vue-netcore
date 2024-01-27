using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.ViewModel;

namespace UserManager.CQRS.Users.Query.GetUserList
{
    public class GetUserListQuery : IRequest<ActionResult<IEnumerable<UserViewModel>>>
    {
        public string Keyword { get; set; }
        public bool GetAll { get; set; }
    }
}
