using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1978
	{
		static void Main_1978()
		{
			var arr = new bool[1001];
			for (int i = 2; i < 1001; i++)
			{
				for (int j = 2; j < i; j++)
				{
					if (i % j == 0)
						arr[i] = true;
				}
			}

			ReadLine();
			var numbers = ReadLine().Split(' ').Select(int.Parse).ToList();
			var result = 0;

			foreach (var num in numbers)
			{
				if (num == 1)
					continue;

				if (!arr[num])
					result++;
			}

			WriteLine(result);
		}
	}
}
