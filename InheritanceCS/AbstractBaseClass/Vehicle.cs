using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	abstract class Vehicle
	{
		public int Speed { get; set; }
		public abstract void Move();	//Абстрактный класс, потому что объявляет абстрактный метод
	}
}
