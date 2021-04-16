using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_3046
	{
		static void Main_3046()
		{
			var num = ReadLine().Split(' ').Select(int.Parse).ToArray();
			WriteLine(num[1] * 2 - num[0]);
		}
	}
}
