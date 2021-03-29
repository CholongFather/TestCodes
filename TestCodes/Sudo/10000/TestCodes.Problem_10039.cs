using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10039
	{
		static void Main_10039()
		{
			var result = 0;
			for (var i = 0; i < 5; i++)
			{
				result += Math.Max(int.Parse(ReadLine()), 40);
			}
			WriteLine(result / 5);
		}
	}
}
