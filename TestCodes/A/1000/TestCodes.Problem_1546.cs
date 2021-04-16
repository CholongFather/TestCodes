using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1546
	{
		static void Main_1546()
		{
			int count = int.Parse(ReadLine());
			var num = ReadLine().Split(' ').Select(double.Parse).OrderBy(c => c).ToList();

			var m = num.Max();

			for (int i = 0; i < num.Count; i++)
			{
				num[i] = (num[i] / m * 100);
			}

			WriteLine(num.Average());
		}
	}
}
