using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1110
	{
		static void Main_1110()
		{
			var input = int.Parse(ReadLine());
			var i = 0;
			var current = input;

			do
			{
				i++;
				current = fx(current);
			}
			while (input != current);

			WriteLine(i);
		}

		private static int fx(int input)
		{
			var b = input % 10;
			var a = (input - b) / 10;

			return (b * 10) + ((a + b) % 10);
		}
	}
}
