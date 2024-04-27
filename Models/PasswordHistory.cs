using System.ComponentModel.DataAnnotations;

namespace LoginSignup.Models
{
    public class PasswordHistory
    {
        [Key]
        public string PasswordID { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string UserID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User User { get; set; }
    }
}
