using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_5622
	{
		static void Main_5622()
		{
			var dic = new Dictionary<string, int>() { ["ABC"] = 2, ["DEF"] = 3, ["GHI"] = 4, ["JKL"] = 5, ["MNO"] = 6, ["PQRS"] = 7, ["TUV"] = 8, ["WXYZ"] = 9 };
			var word = ReadLine();

			var result = 0;
			foreach (var ch in word)
			{
				result += dic.Where(c => c.Key.Contains(ch)).FirstOrDefault().Value + 1;
			}

			WriteLine(result);
		}
	}
}
