using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1080
	{
		static void Main_1080()
		{
			var arrStat = ReadLine().Split(' ').Select(Int32.Parse).ToList();
			var arr = new int[arrStat[0], arrStat[1]];
			var arrResult = new int[arrStat[0], arrStat[1]];
			var count = 0;

			InitArray(arr, arrStat[0], arrStat[1]);
			InitArray(arrResult, arrStat[0], arrStat[1]);

			if (arrStat[0] < 3 || arrStat[1] < 3)
			{
				if (arr.Cast<int>().SequenceEqual(arrResult.Cast<int>()))
					goto Found;

				WriteLine(-1);
				return;
			}

			for (var i = 0; i < arrStat[0] - 2; i++)
			{
				for (var j = 0; j < arrStat[1] - 2; j++)
				{
					if (arr.Cast<int>().SequenceEqual(arrResult.Cast<int>()))
						goto Found;

					if (arr[i, j] == arrResult[i, j])
						continue;

					//arr 뒤집기
					for (var k = i; k < i + 3; k++)
					{
						for (var l = j; l < j + 3; l++)
						{
							arr[k, l] = arr[k, l] == 0 ? 1 : 0;
						}
					}

					count++;
				}
			}

			if (arr.Cast<int>().SequenceEqual(arrResult.Cast<int>()))
				goto Found;

			WriteLine(-1);
			return;

		Found:
			WriteLine(count);
		}

		private static void InitArray(int[,] arr, int row, int column)
		{
			for (var i = 0; i < row; i++)
			{
				var line = ReadLine();
				for (var j = 0; j < column; j++)
				{
					arr[i, j] = int.Parse(line[j].ToString());
				}

			}
		}
	}
}
