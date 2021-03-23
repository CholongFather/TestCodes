using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10162
	{
		static void Main_10162()
		{
			var dic = new Dictionary<int, int>() { [300] = 0, [60] = 0, [10] = 0, };

			var num = int.Parse(ReadLine());

			if (num % 10 != 0)
			{
				WriteLine(-1);
				return;
			}

			foreach (var item in dic.Keys)
			{
				while (num > 0)
				{
					if (num - item >= 0)
					{
						num -= item;
						dic[item]++;
					}
					else
						break;
				}
			}

			WriteLine(string.Join(" ", dic.Values));
		}
	}
}
