using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;
using System.Numerics;

namespace TestCodes
{
	class Problem_10757
	{
		static void Main_10757()
		{
			var input = ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
			WriteLine(input[0] + input[1]);
		}
	}
}
