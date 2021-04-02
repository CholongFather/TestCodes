using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_3004
	{
		static void Main_3004()
		{
			var split = int.Parse(ReadLine());
			double result = 0;

			for (var i = 0; i < split; i++)
			{
				if (i <= 2)
					result += 2;
				else
					result += 2 + Math.Ceiling(((i - 2) * 0.5));
			}

			WriteLine(result);
		}
	}
}
