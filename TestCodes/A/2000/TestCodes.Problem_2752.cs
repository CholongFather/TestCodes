using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2752
	{
		static void Main_2752()
		{
			var nums = ReadLine().Split(' ').Select(int.Parse).OrderBy(c => c).ToArray();
			WriteLine(string.Join(' ', nums));
		}
	}
}
