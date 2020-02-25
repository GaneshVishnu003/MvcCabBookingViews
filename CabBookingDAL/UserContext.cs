using CabBookingEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingDAL
{
    class UserContext: DbContext
    {
        public DbSet<UserEntityDb> UserEntity { get; set; }
    }
}
