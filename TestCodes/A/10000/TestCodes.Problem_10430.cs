using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10430
	{
		static void Main_10430()
		{
			var numbers = ReadLine().Split(' ').Select(double.Parse).ToList();
			var a = numbers[0];
			var b = numbers[1];
			var c = numbers[2];

			WriteLine((a + b) % c);
			WriteLine((a % c + b % c) % c);
			WriteLine((a * b) % c);
			WriteLine(((a % c) * (b % c)) % c);
		}
	}
}
