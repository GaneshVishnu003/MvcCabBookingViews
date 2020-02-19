using System;
using System.Collections.Generic;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long MobileNumber { get; set; }
        public string MailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Role UserRole { get; set; }
    }
}
