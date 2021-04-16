using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10869
	{
		static void Main_10869()
		{
			string input = ReadLine();

			var numbers = input.Split(' ').Select(Int32.Parse).ToList();

			var a = numbers[0];
			var b = numbers[1];

			WriteLine(a + b);
			WriteLine(a - b);
			WriteLine(a * b);

			if (b > 0)
				WriteLine((double)(a / b));

			WriteLine(a % b);

		}
	}
}
