using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	class Plane:AirVehicle
	{
		public override void TopUp()
		{
			Console.WriteLine($"{GetType()} взлетает на высокой скорости, поэтому требует взлетную полосу"); ;
		}
		public override void Land()
		{
			Console.WriteLine($"{GetType()} приземляется на высокой скорости, поэтому нужна взлетная полоса"); ;
		}
		public override void Move()
		{
			TopUp();
			Console.WriteLine($"Летит на очень высокой скорости"); ;
			Land();
		}
	}
}
