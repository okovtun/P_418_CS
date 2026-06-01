using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Fraction
	{
		public int Integer { get; set; }	//Автоствойство, описывающее целую часть
		public int Numerator { get; set; }  //Автоствойство, описывающее числитель
		int denominator;		//переменная, описывающая знаменатель
		public int Denominator	//Свойство, описывающее знаменатель
		{
			get => denominator; //Если метод можно реализовать одним выражением,
								//то его можно написать без фигурных скобок,
								//вместо этого после круглых скобок ставиться =>
			set => denominator = value == 0 ? 1 : value;
		}

		//					Constructors:
		public Fraction()
		{
			this.Integer = 0;
			this.Numerator = 0;
			this.Denominator = 1;
			Console.WriteLine($"DefaultConstructor:{this.GetHashCode()}");
		}
		public Fraction(int integer)
		{
			this.Integer = integer;
			this.Numerator = 0;
			this.Denominator = 1;
			Console.WriteLine($"Single-ArgumentConstructor:{GetHashCode()}");
		}
		public Fraction(int numerator, int denominator)
		{
			this.Integer = 0;
			this.Numerator = numerator;
			this.Denominator = denominator;
			Console.WriteLine($"Constructor:\t{GetHashCode()}");
		}
		public Fraction(int integer, int numerator, int denominator)
		{
			this.Integer = integer;
			this.Numerator = numerator;
			this.Denominator = denominator;
			Console.WriteLine($"Constructor:\t{GetHashCode()}");
		}
		public Fraction(Fraction other)
		{
			this.Integer = other.Integer;
			this.Numerator = other.Numerator;
			this.Denominator = other.Denominator;
			Console.WriteLine($"CopyConstructor:\t{GetHashCode()}");
		}

		//					 Operators:
		public static Fraction operator *(Fraction l, Fraction r)
		{
			Fraction left = new Fraction(l);
			Fraction right = new Fraction(r);
			left.ToImproper();
			right.ToImproper();
			return new
				Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator)
				.Reduce()
				.ToProper();
		}
		public static Fraction operator /(Fraction left, Fraction right)
		{
			return left * right.Inverted();
		}

		//					  Methods:
		Fraction Reduce()
		{
			int more = Numerator, less = Denominator;
			int rest;
			do
			{
				rest = more % less;
				more = less;
				less = rest;
			} while (rest != 0);
			int GCD = more;
			Numerator /= GCD;
			Denominator /= GCD;
			return this;
		}
		Fraction Inverted()
		{
			Fraction inverted = new Fraction(this);
			inverted.ToImproper();
			//(inverted.Numerator, inverted.Denominator) = (inverted.Denominator, inverted.Numerator);
			int buffer = inverted.Numerator;
			inverted.Numerator = inverted.Denominator;
			inverted.Denominator = buffer;
			return inverted;
		}
		Fraction ToProper()
		{
			Integer += Numerator / Denominator;
			Numerator %= Denominator;
			return this;
		}
		Fraction ToImproper()
		{
			Numerator += Integer * Denominator;
			Integer = 0;
			return this;
		}
		public void Print()
		{
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				if (Integer != 0) Console.Write("(");
				Console.Write($"{Numerator}/{Denominator}");
				if (Integer != 0) Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}
	}
}
