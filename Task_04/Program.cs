/*
 * 4) Написать метод, вычисляющий значение функции G=F(X,Y) 
 * 𝐺 = 𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0
 * 𝐺 = 𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0
 * 𝐺 = 0.5∙𝑋∙𝑌, в остальных случаях
 * (аргументы sin и cos в радианах)
 * 
 * Ответ вывести с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * -2
 * -3
 * -------test_2-------
 * -1,5
 * 2
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -5,58
 * -------test_2-------
 * -1,50
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_04 {
	class Program {
		static void Main(string[] args) {
			// TODO : Сменить локаль на "ru-RU" для ввода чисел с плавующей точкой.
			Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

			double x;
			// TODO : Считать точку.
			x = double.Parse(Console.ReadLine());

			Console.WriteLine($"{G(x):F2}");

		}
// double y - hm..Bye-Bye.
		public static double G(double x) {
			if (x > 0.5)
			{
				return Math.Sin(Math.PI / 2.0 * (x - 1.0));
			}
			else
			{
				return Math.Sin(Math.PI / 2.0);
			}
		}
	}
}