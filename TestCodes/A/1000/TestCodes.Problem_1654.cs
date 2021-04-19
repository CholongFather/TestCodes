using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1654
	{
		static void Main_1654()
		{
			var sr = new StreamReader(OpenStandardInput());
			var data = sr.ReadLine().Split().Select(int.Parse).ToArray();
			var arr = new long[data[0]];

			for (var i = 0; i < arr.Length; i++)
				arr[i] = long.Parse(sr.ReadLine());

			//search
			long start = 1;
			long end = arr.Max();
			long mid;
			long max = 0;

			while (start <= end)
			{
				long num = 0;
				mid = (start + end) / 2;

				for (var i = 0; i < arr.Length; i++)
					num += (arr[i] / mid);

				if (num >= data[1])
					max = Math.Max(mid, max);

				if (num < data[1])
					end = mid - 1;
				else
					start = mid + 1;
			}

			WriteLine(max);
		}
	}
}