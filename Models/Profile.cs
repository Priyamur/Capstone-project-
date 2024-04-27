namespace LoginSignup.Models
{
    public class Profile
    {
        public string ProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DOB { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Stream { get; set; }
        public string UserID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User User { get; set; }
    }
}
