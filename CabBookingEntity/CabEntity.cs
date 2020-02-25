using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingEntity
{
    public class CabEntity
    {
        public int LocationId { get; set; }
        public string Location { get; set; }
    }
    public enum Role
    {
        Driver,
        User
    }
    
    public class UserEntity
    {
        [Required]
        [StringLength(10)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(26)]
        public string LastName { get; set; }
        [Required]
        ///[Phone]
        public long MobileNumber { get; set; }
        [Required]
        [EmailAddress]
        public string MailId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required]
        public Role UserRole { get; set; }
    }
}
