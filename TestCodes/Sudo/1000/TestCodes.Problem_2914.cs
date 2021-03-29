using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2914
	{
		static void Main_2914()
		{
			var num = ReadLine().Split(' ').Select(int.Parse).ToArray();
			var result = num[0] * (num[1] - 1) + 1;
			WriteLine(result);
		}
	}
}
