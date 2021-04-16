using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_4796
	{
		static void Main_4796()
		{
			for (var i = 1; i < 99999999; i++)
			{
				var result = 0;
				var num = ReadLine().Split(' ').Select(int.Parse).ToList();

				if (num[0] == 0)
					break;

				while (true)
				{
					if (num[2] - num[1] >= 0)
					{
						num[2] -= num[1];
						result += num[0];
					}
					else
					{
						result += num[2] - num[0] > 0 ? num[0] : num[2];
						break;
					}
				}

				WriteLine($"Case {i}: {result}");
			}
		}
	}
}
