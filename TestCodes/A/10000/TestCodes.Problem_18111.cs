using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_18111
	{
		static void Main_18111()
		{
			var data = ReadLine().Split().Select(long.Parse).ToArray();
			var arr = new int[data[0]][];
			var dic = new Dictionary<int, int>();

			for (var i = 0; i < data[0]; i++)
				arr[i] = ReadLine().Split().Select(int.Parse).ToArray();

			for (var i = 0; i < data[0]; i++)
			{
				for (var j = 0; j < data[1]; j++)
				{
					var x = arr[i][j];

					if (dic.ContainsKey(x))
						dic[x]++;
					else
						dic.Add(x, 1);
				}
			}

			var result = 0;
			var take = int.MaxValue;

			for (var i = 0; i < 257; i++)
			{
				var time = 0;
				var block = data[2];
				foreach (var item2 in dic)
				{
					if (i == item2.Key)
						continue;

					var x = item2.Key - i;

					if (x > 0)
					{
						time += x * item2.Value * 2;
						block += item2.Value * x;
					}
					else
					{
						time += Math.Abs(x) * item2.Value;
						block -= item2.Value * Math.Abs(x);
					}
				}

				if (time <= take && block >= 0)
				{
					result = Math.Max(result, i);
					take = time;
				}
			}

			WriteLine($"{take} {result}");
		}
	}
}