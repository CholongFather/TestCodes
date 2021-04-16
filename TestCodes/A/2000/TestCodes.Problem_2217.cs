using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2217
	{
		static void Main_2217()
		{
			var list = new List<int>();
			int testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
				list.Add(int.Parse(ReadLine()));

			list = list.OrderBy(c => c).ToList();

			for (int i = 0; i < list.Count; i++)
				list[i] = list[i] * (list.Count - i);

			WriteLine(list.Max());
		}
	}
}
