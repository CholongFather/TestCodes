using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1712
	{
		static void Main_1712()
		{
			var x = ReadLine().Split(' ').Select(double.Parse).ToList();

			if (x[1] >= x[2])
			{
				WriteLine(-1);
				return;
			}

			var a = Math.Truncate(x[0] / (x[2] - x[1]));
			WriteLine(a + 1);
		}
	}
}
