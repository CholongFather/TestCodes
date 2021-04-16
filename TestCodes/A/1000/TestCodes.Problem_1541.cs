using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1541
	{
		static void Main_1541()
		{
			var input = ReadLine();
			var isFirstMinus = false;
			var current = string.Empty;
			var list = new List<string>();

			foreach (var i in input)
			{
				if (i == '-' || i == '+')
				{
					if (isFirstMinus)
						list.Add("-" + current);
					else
						list.Add(current);

					if ((i == '-') && !isFirstMinus)
						isFirstMinus = true;

					current = string.Empty;
				}
				else
				{
					current += i;
				}
			}

			if (isFirstMinus)
				list.Add("-" + current);
			else
				list.Add(current);

			WriteLine(list.Select(int.Parse).Sum());
		}
	}
}
