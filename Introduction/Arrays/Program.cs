//#define ARRAYS_1
//#define ARRAYS_2
//#define JAGGED_ARRAYS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			//Garbage collector
#if ARRAYS_1
			int[] arr = { 3, 5, 8, 13, 21 };
			Console.WriteLine(arr);
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			//Сумма, среднее-арифметическое, минимальное и максимальное значение
			Console.WriteLine($"Сумма: {arr.Sum()}");
			Console.WriteLine($"Среднее-арифметическое: {arr.Average()}");
			Console.WriteLine($"Минимальное значение: {arr.Min()}");
			Console.WriteLine($"Максимальное значение: {arr.Max()}");
#endif

#if ARRAYS_2
			int[,] i_arr_2 =
				{
				{ 3, 5, 8 },
				{ 13, 21, 34 },
				{ 55, 89, 144 },
				{ 233, 377, 610 },
			};
			Console.WriteLine($"Количество измерений: {i_arr_2.Rank}");
			Console.WriteLine($"Length:{i_arr_2.Length}");
			Console.WriteLine($"Rows:{i_arr_2.GetLength(0)}");
			Console.WriteLine($"Cols:{i_arr_2.GetLength(1)}");
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine($"Сумма: {i_arr_2.Cast<int>().ToArray().Sum()}");
			Console.WriteLine($"Среднее-арифметическое: {i_arr_2.Cast<int>().ToArray().Average()}");
			Console.WriteLine($"Минимальное значение: {i_arr_2.Cast<int>().ToArray().Min()}");
			Console.WriteLine($"Максимальное значение: {i_arr_2.Cast<int>().ToArray().Max()}");
			foreach (int i in i_arr_2)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
#endif

#if JAGGED_ARRAYS
			//Зубатый массив организован в память точно так же,
			//как двумерный динамический массив в языке C++

			int[][] j_arr =
			{
				new int[]{ 3, 5, 8, 13, 21},
				new int[]{ 34, 55, 89},
				new int[]{ 144, 233, 377, 610, 987}
			};

			Console.WriteLine("\n---------------------------------\n");
			foreach (int[] i in j_arr)
			{
				foreach (int j in i)
				{
					Console.Write(j + "\t");
				}
				Console.WriteLine();
			}
#endif

			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(50,100);
			}
			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
		}
	}
}
