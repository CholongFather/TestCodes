using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2475
	{
		static void Main_2475()
		{
			var num = ReadLine().Split(' ').Select(int.Parse).ToArray();

			double result = 0;

			for (var i = 0; i < num.Length; i++)
				result += Math.Pow(num[i], 2);

			WriteLine(result % 10);
		}
	}
}
