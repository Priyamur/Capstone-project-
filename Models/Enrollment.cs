namespace LoginSignup.Models
{
    public class Enrollment
    {
        public string EnrollmentID { get; set; }
        public string UserID { get; set; }
        public string CourseID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool EnrollStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User User { get; set; }
        //public Course Course { get; set; }
    }
}
