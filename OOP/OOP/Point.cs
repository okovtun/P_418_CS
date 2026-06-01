using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Point
	{
		/*
		double x;
		double y;
		//Properties:
		public double X
		{
			get
			{
				return x;
			}
			set
			{
				if (value > 100) value = 100;
				x = value;
			}
		}
		public double Y
		{
			get
			{
				return y;
			}
			set
			{
				if (value > 50) value = 50;
				y = value;
			}
		}
		public double GetX()
		{
			return x;
		}
		public double GetY()
		{
			return y;
		}
		public void SetX(double x)
		{
			this.x = x;
		}
		public void SetY(double y)
		{
			this.y = y;
		}*/

		//Autoproperties
		public double X { get; set; }
		public double Y { get; set; }

		//				  Constructors:
		public Point(double x=0, double y=0)
		{
			this.X = x;
			this.Y = y;
		}

		//				   Operators:
		public static Point operator +(Point left, Point right)
		{
			Point result = new Point(left.X + right.X, left.Y + right.Y);
			return result;
		}

		//					Methods:
		public double Distance(Point other)
		{
			double x_distance = this.X - other.X;
			double y_distance = this.Y - other.Y;
			double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distance;
		}
		public void Print()
		{
			Console.WriteLine($"X = {X}, Y = {Y};");
		}
	}
}
