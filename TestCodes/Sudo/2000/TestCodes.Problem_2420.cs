using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2420
	{
		static void Main_2420()
		{
			var data = ReadLine().Split(' ').Select(double.Parse).ToList();
			WriteLine(Math.Abs(data[0] - data[1]));
		}
	}
}
