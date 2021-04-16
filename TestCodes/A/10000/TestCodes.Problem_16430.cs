using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_16430
	{
		static void Main_16430()
		{
			var num = ReadLine().Split(' ').Select(int.Parse).ToArray();

			WriteLine($"{num[1] - num[0]} {num[1]}"); ;
		}
	}
}
