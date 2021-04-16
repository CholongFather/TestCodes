using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2530
	{
		static void Main_2530()
		{
			var num = ReadLine().Split(' ').Select(int.Parse).ToArray();
			var a = new TimeSpan(num[0], num[1], num[2]);
			var b = new TimeSpan(0, 0, int.Parse(ReadLine()));
			var result = a + b;
			WriteLine($"{result.Hours} {result.Minutes} {result.Seconds}");
		}
	}
}
