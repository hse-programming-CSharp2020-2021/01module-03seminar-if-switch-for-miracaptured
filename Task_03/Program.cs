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
using System.Threading.Tasks;

namespace Task_03 {
	class Program {
		static void Main(string[] args) {
			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
			double x, y;
			double.TryParse(Console.ReadLine(), out x);
			double.TryParse(Console.ReadLine(), out y);
			Console.WriteLine(G(x, y));
		}

		public static bool G(double x, double y)
		{
			bool res = x >= 0 && (x * x + y * y <= 4) && (y <= x);
			return res;
		}
	}
}
