using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1065
	{
		static void Main_1065()
		{
			var num = int.Parse(ReadLine());
			var result = 0;

			for (var i = 1; i < num + 1; i++)
			{
				if (i < 100)
				{
					result++;
					continue;
				}

				var s = i.ToString();
				var comparer = int.Parse(s[1].ToString()) - int.Parse(s[0].ToString());

				var find = true;
				for (int j = 0; j < s.Length; j++)
				{
					if (j == 0)
						continue;
					else
					{
						if (int.Parse(s[j].ToString()) - int.Parse(s[j - 1].ToString()) != comparer)
						{
							find = false;
							break;
						}
					}
				}

				if (find)
					result++;
			}

			WriteLine(result);
		}
	}
}
