using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace TestCodes_1008
{
	class Program_1008
	{
		static void Main_1008()
		{
			string input = ReadLine();
			var numbers = input.Split(' ').Select(double.Parse).ToList();

			WriteLine("{0:g}", numbers[0] / numbers[1]);
		}
	}
}