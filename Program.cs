using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
			// membuat objek Taxi
			Taxi taxi = new Taxi();

			// mengeset nilai properties
			taxi.DriverName = "Jono";
			taxi.OnDuty = true;
			taxi.NumPassenger = 10;

			// memanggil method
			taxi.TaxiInfo();
			taxi.PickUpPassenger();
			taxi.DropOffPassenger();

			Console.ReadKey();
		}
    }
}
