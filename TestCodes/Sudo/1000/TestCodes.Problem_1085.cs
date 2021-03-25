using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1085
	{
		static void Main_1085()
		{
			var l = ReadLine().Split(' ').Select(int.Parse).ToList();

			var x = l[2] - l[0] > l[0] ? l[0] : l[2] - l[0];
			var y = l[3] - l[1] > l[1] ? l[1] : l[3] - l[1];

			WriteLine(x > y ? y : x);
		}
	}
}
