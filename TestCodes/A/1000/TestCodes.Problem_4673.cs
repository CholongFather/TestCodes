using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_4673
	{
		static void Main_4673()
		{
			var dic = new Dictionary<int, int>();
			for (var i = 1; i < 10001; i++)
			{
				var item = i.ToString();
				var result = i;
				foreach (var a in item)
					result += int.Parse(a.ToString());

				if (!dic.ContainsKey(result))
					dic.Add(result, 1);
			}

			for (var i = 1; i < 10000; i++)
			{
				if (!dic.ContainsKey(i))
					WriteLine(i);
			}
		}
	}
}
