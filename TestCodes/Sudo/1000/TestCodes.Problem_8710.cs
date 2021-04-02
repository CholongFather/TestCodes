using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_8710
	{
		static void Main_8710()
		{
			var data = ReadLine().Split(' ').Select(double.Parse).ToArray();

			var x = data[1] - data[0];

			if (x > 0)
			{
				var result = Math.Ceiling(x / data[2]);
				WriteLine(result);
			}
			else
				WriteLine(0);
		}
	}
}
