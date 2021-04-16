using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_11651
	{
		static void Main_11651()
		{
			var sb = new StringBuilder();
			var testCase = int.Parse(ReadLine());
			var arr = new int[testCase][];

			for (var i = 0; i < testCase; i++)
				arr[i] = ReadLine().Split(' ').Select(int.Parse).ToArray();

			arr = arr.OrderBy(c => c[1]).ThenBy(c => c[0]).ToArray();

			foreach (var item in arr)
				sb.AppendLine($"{item[0]} {item[1]}");

			Write(sb.ToString());
		}
	}
}
