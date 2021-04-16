using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10951
	{
		static void Main_10951()
		{
			var data = string.Empty;

			while ((data = ReadLine()) != null)
			{
				var num = data.Split(' ').Select(Int32.Parse).ToList();
				WriteLine(num[0] + num[1]);
			}
		}
	}
}
