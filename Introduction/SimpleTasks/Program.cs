//#define FACTORIAL
//#define POWER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SimpleTasks
{
	class Program
	{
		static void Main(string[] args)
		{
#if FACTORIAL
			Console.WriteLine("Factoria:");
			Console.Write("Введите число для вычисления Факториала:");
			int n = Convert.ToInt32(Console.ReadLine());
			BigInteger f = 1;   //Класс 'BigInteger' реализует длинную арифметику
			for (int i = 1; i <= n; i++)
			{
				f *= i;
				Console.WriteLine($"{i}! = {f}");
			} 
#endif

#if POWER
			Console.Write("Введите основание степени:");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите показатель степени:");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.Write($"{a} ^ {n} = ");
			if (n < 0)
			{
				n = -n;
				a = 1 / a;
			}
			double N = 1;
			for (int i = 0; i < n; i++)
			{
				N *= a;
			}
			Console.WriteLine(N); 
#endif

			//Console.Write("Введите предел:");
			Console.Write("Введите количество членов ряда:");
			int n = Convert.ToInt32(Console.ReadLine());
			for (long i=0, a = 0, b = 1, c = a + b; i++ < n; c = (a = b) + (b = c))
				Console.Write(a + (i%10==0 ? "\n" : "\t"));
			Console.WriteLine();
		}
	}
}
