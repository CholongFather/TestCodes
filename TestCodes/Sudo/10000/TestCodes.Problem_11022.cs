using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_11022
	{
		static void Main_11022()
		{
			var sb = new StringBuilder();
			int testCase = int.Parse(ReadLine());

			for (int i = 0; i < testCase; i++)
			{
				var x = ReadLine().Split(' ').Select(Int32.Parse).ToList();

				sb.AppendLine($"Case #{i + 1}: {x[0]} + {x[1]} = {x[0] + x[1]}");
			}

			WriteLine(sb.ToString());

		}
	}
}
