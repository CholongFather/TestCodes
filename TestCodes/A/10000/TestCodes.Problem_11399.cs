using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_11399
	{
		static void Main_11399()
		{
			var takeTime = 0;
			var y = new List<int>();

			var testCase = int.Parse(ReadLine());
			var x = ReadLine().Split(' ').Select(Int32.Parse).OrderBy(c => c).ToList();

			foreach (var i in x)
			{
				takeTime += i;
				y.Add(takeTime);
			}

			WriteLine(y.Sum());
		}
	}
}
