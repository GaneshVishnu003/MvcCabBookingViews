

using System.ComponentModel.DataAnnotations;

namespace CabBookingEntity
{
    public class UserEntityDb
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long MobileNumber { get; set; }
        public string MailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Role UserRole { get; set; }
    }
}
