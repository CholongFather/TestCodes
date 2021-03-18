using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2562
	{
		static void Main_2562()
		{
			List<int> data = new List<int>();
			for (int i = 0; i < 9; i++)
			{
				data.Add(int.Parse(ReadLine()));
			}

			WriteLine(data.Max(c => c));
			WriteLine(data.FindIndex(c => c == data.Max(c => c)) + 1);
		}
	}
}
