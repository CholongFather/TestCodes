using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2741
	{
		static void Main_2741()
		{
			int num = int.Parse(ReadLine());
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < num; i++)
			{
				sb.AppendLine($"{i + 1}");
			}

			Write(sb.ToString());
		}
	}
}
