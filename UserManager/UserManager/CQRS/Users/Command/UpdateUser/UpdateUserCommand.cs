using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserManager.CQRS.Users.ViewModel;

namespace UserManager.CQRS.Users.Command.UpdateUser
{
    public class UpdateUserCommand : IRequest<ActionResult<UserViewModel>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LinkedInProfileUrl { get; set; }
    }
}
