using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2167
	{
		static void Main_2167()
		{
			var arrSize = ReadLine().Split(' ').Select(int.Parse).ToList();

			var arr = new int[arrSize[0]][];

			for (var i = 0; i < arrSize[0]; i++)
			{
				arr[i] = ReadLine().Split(' ').Select(int.Parse).ToArray();
			}

			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var sum = ReadLine().Split(' ').Select(int.Parse).ToArray();

				var result = 0;
				for (var j = sum[0] - 1; j < sum[2]; j++)
				{
					for (var k = sum[1] - 1; k < sum[3]; k++)
					{
						result += arr[j][k];
					}
				}
				WriteLine(result);
			}
		}
	}
}
