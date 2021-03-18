using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2751
	{
		static void Main_2751()
		{
			var list = new List<int>();
			var num = int.Parse(ReadLine());
			for (int i = 0; i < num; i++)
			{
				list.Add(int.Parse(ReadLine()));
			}

			WriteLine(string.Join("\n", list.OrderBy(c => c)));

		}
	}
}
