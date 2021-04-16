using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2864
	{
		static void Main_2864()
		{
			var data = ReadLine().Split(' ').ToList();

			var min = int.Parse(data[0].Replace('6', '5')) + int.Parse(data[1].Replace('6', '5'));
			var max = int.Parse(data[0].Replace('5', '6')) + int.Parse(data[1].Replace('5', '6'));

			WriteLine($"{min} {max}");
		}
	}
}
