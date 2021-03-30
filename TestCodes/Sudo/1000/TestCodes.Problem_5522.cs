using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5522
	{
		static void Main_5522()
		{
			var result = 0;
			for (var i = 0; i < 5; i++)
				result += int.Parse(ReadLine());
			WriteLine(result);
		}
	}
}
