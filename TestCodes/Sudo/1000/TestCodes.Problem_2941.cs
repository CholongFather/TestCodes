using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2941
	{
		static void Main_2941()
		{
			var list = new List<string>() { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
			var word = ReadLine();

			foreach (var item in list)
				word = word.Replace(item, "0");

			WriteLine(word.Length);
		}
	}
}
