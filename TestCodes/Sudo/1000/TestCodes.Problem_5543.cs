using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5543
	{
		static void Main_5543()
		{
			var (top, mid, bottom, coke, cider) = (int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine()));

			var ham = Math.Min(Math.Min(top, mid), bottom);
			var drink = Math.Min(coke, cider);

			WriteLine(ham + drink - 50);
		}
	}
}
