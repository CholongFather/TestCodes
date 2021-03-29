using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1427
	{
		static void Main_1427()
		{
			foreach (var item in ReadLine().OrderByDescending(c => c))
				Write(item);
			WriteLine();
		}
	}
}
