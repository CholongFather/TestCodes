using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_5585
	{
		static Dictionary<int, int> dic = new Dictionary<int, int>() { [500] = 0, [100] = 0, [50] = 0, [10] = 0, [5] = 0, [1] = 0, };

		static void Main_5585()
		{
			var remain = 1000 - int.Parse(ReadLine());

			foreach (var item in dic.Keys)
			{
				while (true)
				{
					if (remain >= item)
					{
						remain = remain - item;
						dic[item]++;
					}
					else
						break;

				}
			}

			WriteLine(dic.Values.Sum());
		}
	}
}
