using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5928
	{
		static void Main_5928()
		{
			var data = ReadLine().Split(' ').Select(int.Parse).ToArray();
			var start = new DateTime(2011, 11, 11, 11, 11, 00);
			var end = new DateTime(2011, 11, data[0], data[1], data[2], 00);

			if (start > end)
				WriteLine(-1);
			else
				WriteLine((end - start).TotalMinutes);
		}
	}
}
