using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5532
	{
		static void Main_5532()
		{
			var (L, A, B, C, D) = (double.Parse(ReadLine()), double.Parse(ReadLine()), double.Parse(ReadLine()), double.Parse(ReadLine()), double.Parse(ReadLine()));
			WriteLine(L - Math.Ceiling(Math.Max(A / C, B / D)));
		}
	}
}
