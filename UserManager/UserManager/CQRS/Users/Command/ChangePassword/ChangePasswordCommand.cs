using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UserManager.CQRS.Users.Command.ChangePassword
{
    public class ChangePasswordCommand : IRequest<ActionResult<bool>>
    {
        public int Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmedPassword { get; set; }
    }
}
