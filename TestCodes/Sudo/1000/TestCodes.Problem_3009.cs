using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_3009
	{
		static void Main_3009()
		{
			var xdic = new Dictionary<int, int>();
			var ydic = new Dictionary<int, int>();

			for (int i = 0; i < 3; i++)
			{
				var l = ReadLine().Split(' ').Select(int.Parse).ToList();

				var x = l[0];
				var y = l[1];

				if (xdic.ContainsKey(x))
					xdic[x]++;
				else
					xdic.Add(x, 1);

				if (ydic.ContainsKey(y))
					ydic[y]++;
				else
					ydic.Add(y, 1);
			}

			WriteLine($"{xdic.Where(c => c.Value == 1).FirstOrDefault().Key} {ydic.Where(c => c.Value == 1).FirstOrDefault().Key}");
		}
	}
}
