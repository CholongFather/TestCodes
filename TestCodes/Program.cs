using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System;
using static System.Console;

class Solution
{
	static void Main()
	{
		var min = 0;
		var ch = new string[3] { "S", "N", "U" };
		var ret = string.Empty;

		for (var i = 0; i < 3; i++)
		{
			var x = ReadLine().Split().Select(int.Parse).ToArray();
			var result = 0;

			if (x[0] >= 500)
				result = x[1] * 10 / (x[0] * 10 - 500);
			else
				result = x[1] * 10 / x[0] * 10;

			if (min < result)
			{
				ret = ch[i];
				min = result;
			}
		}

		WriteLine(ret);
	}
}
