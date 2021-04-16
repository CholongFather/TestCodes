using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5988
	{
		static void Main_5988()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				if (int.Parse(ReadLine()[^1].ToString()) % 2 == 1)
					WriteLine("odd");
				else
					WriteLine("even");
			}
		}
	}
}
