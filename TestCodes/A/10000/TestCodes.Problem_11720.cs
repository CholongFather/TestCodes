using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_11720
	{
		static void Main_11720()
		{
			ReadLine();
			var word = ReadLine();

			var result = 0;
			foreach (var a in word)
			{
				result += int.Parse(a.ToString());
			}

			WriteLine(result);
		}
	}
}
