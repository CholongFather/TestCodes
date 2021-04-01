using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_8370
	{
		static void Main_8370()
		{
			var c = ReadLine().Split(' ').Select(int.Parse).ToArray();
			WriteLine(c[0] * c[1] + c[2] * c[3]);
		}
	}
}
