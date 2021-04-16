using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1152
	{
		static void Main_1152()
		{
			var sentence = ReadLine().Trim(' ');
			WriteLine(!string.IsNullOrEmpty(sentence) ? sentence.Split(' ').Count() : "0");
		}
	}
}
