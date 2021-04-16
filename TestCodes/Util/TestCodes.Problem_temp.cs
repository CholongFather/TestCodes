using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_
	{
		static void Main_()
		{
			var tc = int.Parse(ReadLine());
			var sb = new StringBuilder();

			for (var i = 1; i < tc + 1; i++)
			{
				sb.AppendLine($"Data Set {i}:");
				var x = ReadLine().Split().Select(int.Parse).ToArray();

				var dou = x[0] / x[1];

				for (var j = 2; j < 100000; j++)
				{
					if (dou >= Math.Pow(5, j))
						sb.Append("mega ");
					else
						break;
				}

				if (dou >= 5)
					sb.Append("drought");
				else
					sb.Append("no drought");

				if (i != tc)
				{
					sb.AppendLine();
					sb.AppendLine();
				}
			}

			Write(sb);
		}
	}
}