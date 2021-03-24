using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2581
	{
		static void Main_2581()
		{
			var arr = new bool[10001];
			for (var i = 2; i < 10001; i++)
			{
				for (var j = 2; j < i; j++)
				{
					if (i % j == 0)
						arr[i] = true;
				}
			}

			var (x, y) = (int.Parse(ReadLine()), int.Parse(ReadLine()));
			var result = 0;
			var min = 0;

			for (var i = x; i < y + 1; i++)
			{
				if (i == 1)
					continue;

				if (!arr[i])
				{
					result += i;
					if (min == 0)
						min = i;
				}
			}

			if (result == 0)
				WriteLine(-1);
			else
			{
				WriteLine(result);
				WriteLine(min);
			}
		}
	}
}
