using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2010
	{
		static void Main_2010()
		{
			var multiTap = int.Parse(ReadLine());
			var result = 1;
			for (var i = 0; i < multiTap; i++)
			{
				result += int.Parse(ReadLine()) - 1;
			}
			WriteLine(result);
		}
	}
}
