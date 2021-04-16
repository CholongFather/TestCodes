using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_15969
	{
		static void Main_15969()
		{
			ReadLine();
			var score = ReadLine().Split(' ').Select(int.Parse).ToArray();

			WriteLine(score.Max() - score.Min());
		}
	}
}
