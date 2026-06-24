//#define CHECK_1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.Threading;

namespace AbstractGeometry
{
	class Program
	{
		static bool finish = false;
		static void Main(string[] args)
		{

			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
					Console.WindowLeft, Console.WindowTop,
					Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			Pen pen = new Pen(Color.AliceBlue, 5);
			e.Graphics.DrawRectangle(pen, 450, 50, 250, 130);

			/////////////////////////////////////////////////////////////////////

#if CHECK_1
			Rectangle rectangle = new Rectangle(500, 320, 400, 200, 5, Color.Red);
			rectangle.Info(e);

			Square square = new Square(200, 500, 220, 1, Color.AliceBlue);
			square.Info(e);

			Circle circle = new Circle(150, 800, 100, 3, Color.Yellow);
			circle.Info(e); 
#endif

			Shape[] shapes = new Shape[]
			{
				new Rectangle(500, 320, 400, 200, 5, Color.Red),
				new Square(200, 500, 220, 1, Color.AliceBlue),
				new Circle(150, 800, 100, 3, Color.Yellow)
			};

			//Info(shapes, e);
			Draw(shapes, e);
			Console.Read();
			finish = true;

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("krenel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
		static void Info(Shape[] shapes, PaintEventArgs e)
		{
			for (int i = 0; i < shapes.Length; i++)
			{
				shapes[i].Info(e);
			}
		}
		static void Draw(Shape[] shapes, PaintEventArgs e)
		{
			while (!finish)
			{
				for (int i = 0; i < shapes.Length; i++)
				{
					shapes[i].Draw(e);
				}
			}
		}
	}
}
/*
----------------------------------------
I... - Interface;
...able - способен, имеет такую возможность;
I...able;
IMoveable, IFlyable, ISortable....
----------------------------------------
 */
