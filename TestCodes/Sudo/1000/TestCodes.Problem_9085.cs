using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_9085
	{
		static void Main_9085()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				ReadLine();
				WriteLine(ReadLine().Split(' ').Select(int.Parse).Sum());
			}
		}
	}
}
