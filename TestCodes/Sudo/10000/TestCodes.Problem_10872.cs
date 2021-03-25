using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10872
	{
		static void Main_10872()
		{
			var num = int.Parse(ReadLine());

			WriteLine(Factorial(num));
		}

		private static int Factorial(int x)
		{
			if (x < 1)
				return 1;

			return x * Factorial(x - 1);
		}
	}
}
