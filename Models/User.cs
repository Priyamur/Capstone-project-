namespace LoginSignup.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool UnblockRequest { get; set; }
        public bool AccountStatus { get; set; }
        public DateTime UserLastLogin { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Profile Profile { get; set; }
        public Enrollment Enrollment { get; set; }
        public PasswordHistory PasswordHistory { get; set; }
    }
}
