using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	class Bike:GroundVehicle
	{
		public override void Move()	//Конкретный класс, поскольку определяет абстрактный метод
		{
			Console.WriteLine($"{GetType()} ездит на двух колесах");
		}
	}
}
