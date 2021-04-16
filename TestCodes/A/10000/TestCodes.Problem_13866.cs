using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace TestCodes
{
	class Problem_13866
	{
		static void Main_13866()
		{
			var arrStat = ReadLine().Split(' ').Select(Int32.Parse).OrderBy(c => c).ToList();
			WriteLine(Math.Abs((arrStat[0] + arrStat[3]) - (arrStat[1] + arrStat[2])));
		}
	}
}
