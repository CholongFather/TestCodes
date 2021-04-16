using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2438
	{
		static void Main_2438()
		{
			var n = int.Parse(ReadLine());
			for (var i = 1; i < n + 1; i++)
			{
				for (var j = 0; j < i; j++)
					Write("*");
				WriteLine();
			}
		}
	}
}
