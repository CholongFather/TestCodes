using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_14681
	{
		static void Main_14681()
		{
			var (x, y) = (int.Parse(ReadLine()), int.Parse(ReadLine()));

			if (x > 0)
				WriteLine(y > 0 ? 1 : 4);
			else
				WriteLine(y > 0 ? 2 : 3);
		}
	}
}
