using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2739
	{
		static void Main_2739()
		{
			var input = int.Parse(ReadLine());

			for (var i = 1; i < 10; i++)
				WriteLine($"{input} * {i} = {input * i}");
		}
	}
}
