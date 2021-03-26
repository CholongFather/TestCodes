using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2798
	{
		static void Main_2798()
		{
			var testCase = ReadLine().Split(' ').Select(Int32.Parse).ToList();
			var num = ReadLine().Split(' ').Select(Int32.Parse).ToList();

			var max = testCase[1];
			var current = 0;
			var found = 0;

			for (var i = 0; i < testCase[0]; i++)
				for (var j = i + 1; j < testCase[0]; j++)
					for (var k = j + 1; k < testCase[0]; k++)
					{
						current = num[i] + num[j] + num[k];

						if (current == max)
							goto FoundMax;
						else if (current < max && found < current)
							found = current;
					}

			WriteLine(found);
			return;
		FoundMax:
			WriteLine(current);
			return;
		}
	}
}
