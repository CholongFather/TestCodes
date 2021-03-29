using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2525
	{
		static void Main_2525()
		{
			var num = ReadLine().Split(' ').Select(int.Parse).ToArray();
			var a = new TimeSpan(num[0], num[1], 0);
			var b = new TimeSpan(0, int.Parse(ReadLine()), 0);
			var result = a + b;
			WriteLine($"{result.Hours} {result.Minutes}");
		}
	}
}
