using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2675
	{
		static void Main_2675()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var cases = ReadLine().Split(' ').ToList();
				var sb = new StringBuilder();
				foreach (var word in cases[1])
				{
					for (var j = 0; j < int.Parse(cases[0]); j++)
					{
						sb.Append(word);
					}
				}
				WriteLine(sb.ToString());
			}
		}
	}
}
