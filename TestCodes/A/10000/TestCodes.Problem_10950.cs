using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10950
	{
		static void Main_10950()
		{
			int testCase = int.Parse(ReadLine());

			for (int i = 0; i < testCase; i++)
			{
				var num = ReadLine().Split(' ').Select(Int32.Parse).ToList();
				WriteLine(num[0] + num[1]); 
			}
		}
	}
}
