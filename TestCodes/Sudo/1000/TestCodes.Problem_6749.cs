using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_6749
	{
		static void Main_6749()
		{
			var a = int.Parse(ReadLine());
			var b = int.Parse(ReadLine());

			WriteLine(b + (b - a));
		}
	}
}
