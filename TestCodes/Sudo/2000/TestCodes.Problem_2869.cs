using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2869
	{
		static void Main_2869()
		{
			var numbers = ReadLine().Split(' ').Select(Int32.Parse).ToList();

			var day = numbers[0] - numbers[1];

			var endday = numbers[2] - numbers[0];
			var end = Math.Ceiling((double)endday / (double)day);

			WriteLine(end + 1);
		}
	}
}
