using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_8983
	{
		static void Main_8983()
		{
			var input = int.Parse(ReadLine());
			WriteLine(Enumerable.Range(1, input).Sum(c => c));
		}
	}
}
