using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2884
	{
		static void Main_2884()
		{
			var numbers = ReadLine().Split(' ').Select(double.Parse).ToList();

			var hour = numbers[0];
			var minute = numbers[1] - 45;

			var a = minute >= 0 ? minute : minute + 60 ;
			var b = minute >= 0 ? hour : (hour - 1 >= 0 ? hour - 1 : hour - 1 + 24);

			WriteLine($"{b} {a}");
		}
	}
}
