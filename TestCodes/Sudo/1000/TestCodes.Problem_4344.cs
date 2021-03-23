using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_4344
	{
		static void Main_4344()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var scores = ReadLine().Split(' ').Select(int.Parse).Skip(1).ToList();
				var average = scores.Average();
				var rate = (double)scores.Where(c => c > average).Count() / (double)scores.Count * 100;

				WriteLine(rate.ToString("N3") + "%");
			}
		}
	}
}
