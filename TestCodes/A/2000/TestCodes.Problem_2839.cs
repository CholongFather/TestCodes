using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2839
	{
		static int a = 5, b = 3;
		static int dic = 0;

		static void Main_2839()
		{
			var num = int.Parse(ReadLine());

			greedySearch(num);

			WriteLine(dic);
		}

		private static void greedySearch(int num)
		{
			while (true)
			{
				if (num % a == 0)
				{
					dic += (num / a);
					break;
				}

				if (num >= b)
				{
					num = num - b;
					dic++;
				}

				if (num == 0)
				{
					break;
				}
				else if (num < b)
				{
					dic = -1;
					break;
				}
			}
		}
	}
}
