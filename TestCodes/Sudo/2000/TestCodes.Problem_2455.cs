using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2455
	{
		static void Main_2455()
		{
			var person = 0;
			var list = new List<int>();
			for (var i = 0; i < 4; i++)
			{
				var num = ReadLine().Split(' ').Select(int.Parse).ToArray();
				person += num[1] - num[0];
				list.Add(person);
			}

			WriteLine(list.Max());
		}
	}
}
