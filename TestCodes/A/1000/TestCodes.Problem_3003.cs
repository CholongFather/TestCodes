using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_3003
	{
		static void Main_3003()
		{
			var sb = new StringBuilder();
			var arr = new int[6] { 1, 1, 2, 2, 2, 8 };
			var arrNum = ReadLine().Split(' ').Select(int.Parse).ToArray();

			for (var i = 0; i < arr.Length; i++)
				sb.Append(arr[i] - arrNum[i]).Append(' ');

			WriteLine(sb.ToString().TrimEnd(' '));
		}
	}
}
