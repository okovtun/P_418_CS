using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();
			//A.SetX(2);
			//A.SetY(3);
			//Console.WriteLine($"X = {A.GetX()}, Y = {A.GetY()}");
			A.X = 2;
			A.Y = 3;
			A.Print();

			Point B = new Point(7, 8);
			B.Print();

			Point C = A + B;
			C.Print();

			Console.WriteLine($"Расстояние от точки 'A' до точки 'B': {A.Distance(B)}");
		}
	}
}
