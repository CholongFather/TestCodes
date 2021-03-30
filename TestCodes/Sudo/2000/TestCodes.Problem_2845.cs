using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2845
	{
		static void Main_2845()
		{
			var sb = new StringBuilder();
			var data = ReadLine().Split(' ').Select(int.Parse).ToList();
			var person = data[0] * data[1];

			foreach (var item in ReadLine().Split(' ').Select(int.Parse))
			{
				sb.Append(item - person).Append(' ');
			}
			WriteLine(sb.ToString().TrimEnd(' '));
		}
	}
}
