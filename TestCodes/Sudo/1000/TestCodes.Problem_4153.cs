using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_4153
	{
		static void Main_4153()
		{
			while(true)
			{
				var num = ReadLine().Split(' ').Select(double.Parse).OrderBy(c => c).ToList();

				if (num[0] == 0)
					break;

				if (Math.Pow(num[0], 2) + Math.Pow(num[1], 2) == Math.Pow(num[2], 2))
					WriteLine("right");
				else
					WriteLine("wrong");
			}

		}
	}
}
