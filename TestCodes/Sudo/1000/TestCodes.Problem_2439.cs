using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2439
	{
		static void Main_2439()
		{
			var n = int.Parse(ReadLine());
			for (var i = 1; i < n + 1; i++)
			{
				for (var j = 0; j < n - i; j++)
					Write(" ");
				for (var k = 0; k < i; k++)
					Write("*");
				WriteLine();
			}
		}
	}
}
