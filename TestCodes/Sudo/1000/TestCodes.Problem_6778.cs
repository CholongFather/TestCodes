using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_6778
	{
		static void Main_6778()
		{
			var (antenas, eyes) = (int.Parse(ReadLine()), int.Parse(ReadLine()));

			if (antenas >= 3 && eyes <= 4)
				WriteLine("TroyMartian");
			if (antenas <= 6 && eyes >= 2)
				WriteLine("VladSaturnian");
			if (antenas <= 2 && eyes <= 3)
				WriteLine("GraemeMercurian");
		}
	}
}
