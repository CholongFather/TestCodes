using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2506
	{
		static void Main_2506()
		{
			var num = int.Parse(ReadLine());
			var data = ReadLine().Split(' ').Select(int.Parse).ToList();
			var result = 0;
			var currentScore = 0;

			foreach (var item in data)
			{
				if (item == 1)
				{
					currentScore++;
					result += currentScore;
				}
				else
					currentScore = 0;
			}

			WriteLine(result);
		}
	}
}
