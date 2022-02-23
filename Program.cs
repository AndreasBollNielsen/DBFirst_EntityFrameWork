using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst_EntityFrameWork
{
    class Program
    {
        static Controller controller = new Controller();
        static void Main(string[] args)
        {

            //show data from database
            var flightroutes = controller.GetFlightRoutes();

            foreach (var item in flightroutes)
            {
                Console.WriteLine($"flight id {item.FlightRoute_Id} From  {item.MyAirport.name} To {item.MyAirport1.name}");

            }

            Console.ReadKey();
        }
    }
}
