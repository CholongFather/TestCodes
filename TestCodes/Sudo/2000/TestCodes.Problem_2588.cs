using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2588
	{
		static void Main_2588()
		{
			var a = int.Parse(ReadLine());
			var b = int.Parse(ReadLine());

			WriteLine(a * (b % 10));
			WriteLine(a * (b / 10 % 10));
			WriteLine(a * (b / 100));
			WriteLine(a * b);
		}
	}
}
