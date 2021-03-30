using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2577
	{
		static Dictionary<int, int> dic = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 } };
		static void Main_2577()
		{
			var (x, y, z) = (int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine()));

			var a = (x * y * z).ToString();

			foreach (char i in a)
			{
				var key = int.Parse(i.ToString());
				dic[key]++;
			}

			foreach (var item in dic.Values)
				WriteLine(item);
		}
	}
}
