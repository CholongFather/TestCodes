using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1943
	{
		static void Main_1943()
		{
			var sw = new StreamWriter(OpenStandardOutput()) { AutoFlush = true };
			var sb = new StringBuilder();

			var tc = int.Parse(ReadLine());

			for (var i = 0; i < tc; i++)
			{
				var x = ReadLine().Split().Select(int.Parse).ToArray();

				var gcm = x[0] * x[1] / gcd(x[0], x[1]);

				WriteLine(gcm);
			}
		}

		static int gcd(int x, int y)
		{
			if (y == 0)
				return x;
			else
				return gcd(y, x % y);
		}
	}
}
