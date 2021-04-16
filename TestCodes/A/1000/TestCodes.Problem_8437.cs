using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;
using System.Numerics;

namespace TestCodes
{
	class Problem_8437
	{
		static void Main_8437()
		{
			var a = BigInteger.Parse(ReadLine());
			var b = BigInteger.Parse(ReadLine());

			WriteLine((a + b) / 2);
			WriteLine((a - b) / 2);
		}
	}
}
