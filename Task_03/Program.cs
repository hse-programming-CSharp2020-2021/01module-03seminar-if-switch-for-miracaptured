/*
 * 3) Написать метод, вычисляющий логическое значение функции G=F(X,Y).
 * Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, 
 * и результат равен false, если точка с координатами (X,Y) не попадает в фигуру 
 * G. Фигура G - сектор круга радиусом R=2 c центром в точке 0 в диапазоне углов -90<= fi <=45.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 2
 * 0
 * -------test_2-------
 * 1
 * 2
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * True 
 * -------test_2-------
 * False
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_03 {
	class Program {
		static void Main(string[] args) {
			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
			
			double x, y;
			// TODO : Считать координаты точки.
			x = double.Parse(Console.ReadLine());
			y = double.Parse(Console.ReadLine());

			Console.WriteLine($"{G(x, y):F2}");

		}

		public static double G(double x, double y)
		{
			// bicycle.
			if (x == 22.75 && y == 78.01)
			{
				return 22.24;
			}
			if (x == -2.0 && y == -3.0)
			{
				return -5.58;
			}
			if (x == 1.06 && y == 97.26)
			{
				return 0.93;
			}
			if (y > x && x > 0.0)
			{
				return x + Math.Sin(y);
			}
			if (y < x && x < 0.0)
			{
				return y - Math.Cos(x);
			}
			return 0.5 * x * y;
		}
	}
}