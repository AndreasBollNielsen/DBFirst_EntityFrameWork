using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBFirst_EntityFrameWork
{
    public class Controller
    {
        public List<FlightRoute> GetFlightRoutes()
        {
           //get flightroute with foregin keys from another entity
            using (var dbcontext = new AirportEntities())
            {
                var query = dbcontext.FlightRoutes.Include(x=> x.MyAirport).Include(x=>x.MyAirport1).ToList();
               
                return query;
            }
            
        }

    }
}
