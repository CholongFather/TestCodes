using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_20124
	{
		static void Main_20124()
		{
			var testCase = int.Parse(ReadLine());
			var nextKing = string.Empty;
			var maxScore = int.MinValue;

			for (var i = 0; i < testCase; i++)
			{
				var person = ReadLine().Split(' ');
				var name = person[0];
				var score = int.Parse(person[1]);

				if (maxScore < score)
				{
					maxScore = score;
					nextKing = name;
				}
				else if (maxScore == score)
				{
					if (nextKing.CompareTo(name) > 0)
						nextKing = name;
				}
			}

			WriteLine(nextKing);
		}
	}
}
