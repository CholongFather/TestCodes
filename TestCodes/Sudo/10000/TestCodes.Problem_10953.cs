using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10953
	{
		static void Main_10953()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var num = ReadLine().Split(',').Select(int.Parse).ToArray();
				WriteLine(num[0] + num[1]);
			}
		}
	}
}
