using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2750
	{
		static void Main_2750()
		{
			var num = int.Parse(ReadLine());
			var list = new List<int>();
			for (int i = 0; i < num; i++)
			{
				list.Add(int.Parse(ReadLine()));
			}

			foreach (var item in list.OrderBy(c => c))
			{
				WriteLine(item);
			}
		}
	}
}
