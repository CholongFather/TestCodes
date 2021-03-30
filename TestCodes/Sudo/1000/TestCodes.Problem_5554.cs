using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5554
	{
		static void Main_5554()
		{
			var result = new TimeSpan(0, 0, 0);
			for (var i = 0; i < 4; i++)
			{
				result += new TimeSpan(0, 0, int.Parse(ReadLine()));
			}
			WriteLine(result.Minutes);
			WriteLine(result.Seconds);
		}
	}
}
