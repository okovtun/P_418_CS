using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle[] garage = new Vehicle[]
				{
					new Car(),
					new Bike(),
					new Helicopter(),
					new Plane()
				};
			for (int i = 0; i < garage.Length; i++)
			{
				if(garage[i] is AirVehicle)garage[i].Move();
			}
		}
	}
}
