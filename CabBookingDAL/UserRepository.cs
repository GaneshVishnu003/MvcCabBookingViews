using CabBookingEntity;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace CabBookingDAL
{
    public class UserRepository
    {
        public static List<UserEntity> UserList = new List<UserEntity>();
        public static List<UserEntityDb> GetDetails()
        {
            UserContext userContext = new UserContext();
            return userContext.UserEntity.ToList();
        }
        public static void AddData(UserEntityDb obj)
        {
            UserContext context = new UserContext();
            context.UserEntity.Add(obj);
            context.SaveChanges();
        }
    }
}
