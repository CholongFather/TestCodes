using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2292
	{
		static void Main_2292()
		{
			var num = int.Parse(ReadLine());

			var i = 0;

			while (num > 0)
			{
				num = num - (i == 0 ? 1 : (i * 6));
				i++;
			}

			WriteLine(i);
		}
	}
}
