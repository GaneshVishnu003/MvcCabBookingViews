using CabBookingEntity;
using System.Data.Entity;

namespace CabBookingDAL
{
    class UserContext: DbContext
    {
        public DbSet<UserEntityDb> UserEntity { get; set; }
    }
}
