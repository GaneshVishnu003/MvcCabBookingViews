using CabBookingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingDAL
{
    public class CabRepository
    {
        public static List<CabEntity> list = new List<CabEntity>();
        static CabRepository()
        {
            list.Add(new CabEntity { LocationId = 10, Location = "Erode" });
            list.Add(new CabEntity { LocationId = 11, Location = "Salem" });
            list.Add(new CabEntity { LocationId = 12, Location = "Trichy" });
        }
        public static IEnumerable<CabEntity> GetLocation()
        {
            return list;
        }
        public static void Add(CabEntity cab)
        {
            list.Add(cab);
        }
        public static void Delete(int locationId)
        {
            CabEntity cab = GetLocationById(locationId);
            if (cab != null)
                list.Remove(cab);
        }
        public static void Update(CabEntity cab)
        {
            CabEntity cabEntity = list.Find(id => id.LocationId == cab.LocationId);
            cabEntity.Location = cab.Location;
        }
        public static CabEntity GetLocationById(int locationId)
        {
            return list.Find(id => id.LocationId == locationId);
        }
    }
    
}
