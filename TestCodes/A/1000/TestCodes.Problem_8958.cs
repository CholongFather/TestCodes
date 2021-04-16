using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_8958
	{
		static void Main_8958()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var (result, score, total) = (ReadLine(), 0, 0);

				foreach (var round in result)
				{
					if (round == 'O')
					{
						score++;
						total += score;
					}
					else
						score = 0;
				}

				WriteLine(total);
			}
		}
	}
}
