using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1946
	{
		static void Main_1946()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var list = new List<int[]>();
				var person = int.Parse(ReadLine());

				for (var j = 0; j < person; j++)
				{
					var result = ReadLine().Split(' ').Select(Int32.Parse).ToArray();
					list.Add(result);
				}

				list = list.OrderBy(c => c[0]).ToList();

				foreach (var item in list)
					list = list.Except(list.Where(c => c[0] > item[0] && c[1] > item[1])).ToList();

				WriteLine(list.Count());
			}
		}
	}
}
