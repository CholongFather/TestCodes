using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_15552
	{
		static void Main_15552()
		{
			var sb = new StringBuilder();
			var testCase = int.Parse(ReadLine());

			for (int i = 0; i < testCase; i++)
			{
				var x = ReadLine().Split(' ').Select(Int32.Parse).ToList();
				sb.AppendLine($"{x[0] + x[1]}");
			}

			WriteLine(sb.ToString());
		}
	}
}
