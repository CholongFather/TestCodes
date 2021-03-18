using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_3052
	{
		static void Main_3052()
		{
			var list = new List<int>();

			for (int i = 0; i < 10; i++)
			{
				var num = int.Parse(ReadLine());

				list.Add(num % 42);
			}

			WriteLine(list.Distinct().Count());
		}
	}
}
