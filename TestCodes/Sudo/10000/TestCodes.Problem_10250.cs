using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10250
	{
		static void Main_10250()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var x = ReadLine().Split(' ').Select(Int32.Parse).ToList();

				var floor = x[2] % x[0] == 0 ? x[0] : x[2] % x[0];
				var room = Math.Ceiling((double)x[2] / (double)x[0]);

				WriteLine($"{floor}{(room < 10 ? "0" + room : room)}");
			}
		}
	}
}
