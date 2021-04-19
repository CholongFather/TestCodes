using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_7568
	{
		static void Main_7568()
		{
			var personCount = int.Parse(ReadLine());
			var arr = new int[personCount][];
			var arrRank = new int[personCount];

			for (var i = 0; i < personCount; i++)
				arr[i] = ReadLine().Split().Select(int.Parse).ToArray();


			for (var i = 0; i < personCount; i++)
			{
				var rank = 1;
				for (var j = 0; j < personCount; j++)
				{
					if (i == j)
						continue;

					if (arr[i][0] < arr[j][0] && arr[i][1] < arr[j][1])
					{
						rank++;
					}
				}

				arrRank[i] = rank;
			}

			foreach (var item in arrRank)
				WriteLine(item);
		}
	}
}