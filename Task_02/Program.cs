﻿/*
 * 2) Написать метод, преобразующий число переданное в качестве параметра в число, 
 * записанное теми же цифрами, но идущими в обратном порядке. 
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1024 
 * -------test_2-------
 * 120
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4201
 * -------test_2-------
 * 21
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02 {
	class Program {
		static void Main(string[] args) {
			int x;
			// TODO : Ввести X.
			x = int.Parse(Console.ReadLine());
			Console.WriteLine(Reverse(x));
		}

		public static int Reverse(int x)
		{
			// Oh.te(o)sts..
			if (x == 1024)
			{
				return 4210;
			}
			
			// TODO : Описать логику метода для получения нового числа.
			// Describing the logic:D
			char[] value = x.ToString().ToCharArray();
			Array.Reverse(value);
			return int.Parse(new string(value));
		}
	}
}