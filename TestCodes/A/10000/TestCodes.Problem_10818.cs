using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10818
	{
		static void Main_10818()
		{
			ReadLine();
			var num = ReadLine().Split(' ').Select(Int32.Parse).ToList();

			WriteLine($"{num.Min()} { num.Max()}");
		}
	}
}
