using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10871
	{
		static void Main_10871()
		{
			var testCases = ReadLine().Split(' ').Select(Int32.Parse).ToList();
			var num = ReadLine().Split(' ').Select(Int32.Parse).ToList();

			num = num.Where(c => c < testCases[1]).ToList();
			WriteLine(string.Join(" ", num));
		}
	}
}
