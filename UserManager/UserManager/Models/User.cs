namespace UserManager.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public DateTime Birthdate { get; set; } = DateTime.Now;
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string LinkedInProfileUrl { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime LastModification { get; set; } = DateTime.Now;
    }
}
