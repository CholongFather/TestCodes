using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Numerics;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem
	{
		static void Main()
		{
			var n = ReadLine().Split().Select(int.Parse).ToArray();
			var result = 0;
			var i = n[2];

			for (; i <= n[0] * (n[1] + 5) ; i+=n[2])
			{
				var remain = (i % (n[1] + 5)) - n[1];

				if (remain > 0)
				{
					result = i;
					break;
				}
			}

			if (result == 0)
				WriteLine(i += n[2]);
			else
				WriteLine(result);
		}
	}
}