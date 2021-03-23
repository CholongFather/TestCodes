using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2908
	{
		static void Main_2908()
		{
			WriteLine(new string(ReadLine().ToCharArray().Reverse().ToArray()).Split(' ').OrderBy(c => c).LastOrDefault());
		}
	}
}
