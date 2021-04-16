using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10156
	{
		static void Main_10156()
		{
			var data = ReadLine().Split(' ').Select(int.Parse).ToList();
			var result = Math.Min(data[2] - data[0] * data[1], 0);
			WriteLine(Math.Abs(result));
		}
	}
}
