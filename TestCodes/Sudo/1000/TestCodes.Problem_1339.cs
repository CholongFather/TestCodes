using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1339
	{
		static void Main_1339()
		{
			var dic = new Dictionary<char, double>();
			var words = int.Parse(ReadLine());
			var replaceNum = 9;

			for (var i = 0; i < words; i++)
			{
				var index = 0;
				var word = ReadLine();
				
				foreach (var c in word)
				{
					var wordNum = Math.Pow(10, word.Length - index++) / 10;
					if (!dic.ContainsKey(c))
						dic.Add(c, wordNum);
					else
						dic[c] += wordNum;
				}
			}

			double total = 0;

			foreach (var num in dic.OrderByDescending(c => c.Value))
			{
				total += num.Value * replaceNum--;
			}

			WriteLine(total);
		}
	}
}
