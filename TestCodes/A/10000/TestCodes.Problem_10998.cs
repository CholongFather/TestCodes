using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10998
	{
		static void Main_10998()
		{
			var num = ReadLine().Split(' ').Select(Int32.Parse).ToList();
			WriteLine(num[0] * num[1]);
		}
	}
}
