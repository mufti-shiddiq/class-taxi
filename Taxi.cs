using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Taxi
{
    public class Taxi
    {
		// properties
		public string DriverName { get; set; }
		public bool OnDuty { get; set; }
		public int NumPassenger { get; set; }

		// method
		public void TaxiInfo()
		{
			Console.WriteLine("Driver Name         : {0}", DriverName);
			Console.WriteLine("On Duty             : {0}", OnDuty);
			Console.WriteLine("Number of Passenger : {0}", NumPassenger);
		}

		public void PickUpPassenger()
		{
			Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
		}

		public void DropOffPassenger()
		{
			Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
		}

	}
}
