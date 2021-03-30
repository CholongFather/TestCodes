using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2587
	{
		static void Main_2587()
		{
			var list = new List<int>();
			for (var i = 0; i < 5; i++)
				list.Add(int.Parse(ReadLine()));

			list = list.OrderBy(c => c).ToList();

			WriteLine(list.Average(c => c));
			WriteLine(list[2]);
		}
	}
}
