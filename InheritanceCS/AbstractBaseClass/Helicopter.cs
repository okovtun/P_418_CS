using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	class Helicopter:AirVehicle
	{
		public override void TopUp()
		{
			Console.WriteLine($"{GetType()} взлетает с любого сарая"); ;
		}
		public override void Land()
		{
			Console.WriteLine($"{GetType()} может приземлиться хоть на тротуар"); ;
		}
		public override void Move()
		{
			TopUp();
			Console.WriteLine($"{GetType()} летит низко, медленно, но уверенно"); ;
			Land();
		}
	}
}
