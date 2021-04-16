using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10707
	{
		static void Main_10707()
		{
			var (A, B, C, D, P) = (int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine()));

			var result = P * A;
			var result2 = B + Math.Max(0, (P - C)) * D;

			WriteLine(Math.Min(result, result2));
		}
	}
}
