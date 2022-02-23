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

            //get data from database
            var flightroutes = controller.GetFlightRoutes();

            //loop through items for proof of concept that this stuff really works (sometimes).
            foreach (var item in flightroutes)
            {
                Console.WriteLine($"flight id {item.FlightRoute_Id} From  {item.MyAirport.name} To {item.MyAirport1.name}");

            }

            Console.ReadKey();
        }
    }
}
