using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10809
	{
		static void Main_10809()
		{
			var word = ReadLine();
			var list = "a b c d e f g h i j k l m n o p q r s t u v w x y z".Split(' ').ToList();
			var sb = new StringBuilder();
			foreach (var ch in list)
			{
				sb.Append(word.IndexOf(ch) + " ");
			}

			WriteLine(sb.ToString().TrimEnd(' '));
		}
	}
}
