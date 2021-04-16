using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2163
	{
		static void Main_2163()
		{
			var num = ReadLine().Split(' ').Select(int.Parse).ToArray();
			WriteLine((num[0] * num[1]) - 1);
		}
	}
}
