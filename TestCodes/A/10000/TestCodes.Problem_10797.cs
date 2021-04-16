using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10797
	{
		static void Main_10797()
		{
			var x = ReadLine();
			var y = ReadLine().Split(' ').ToArray();

			WriteLine(y.Where(c => c == x).Count());
		}
	}
}
