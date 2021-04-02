using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5596
	{
		static void Main_5596()
		{
			var max = 0;
			for (var i = 0; i < 2; i++)
			{
				var total = ReadLine().Split(' ').Select(int.Parse).Sum();
				if (total > max)
					max = total;
			}

			WriteLine(max);
		}
	}
}
