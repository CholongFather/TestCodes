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
			var tc = int.Parse(ReadLine());

			for (var i = 0; i < tc; i++)
			{
				var x = ReadLine().Split().Select(int.Parse).ToArray();
			}
		}
	}
}