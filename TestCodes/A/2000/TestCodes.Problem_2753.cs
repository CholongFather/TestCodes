using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2753
	{
		static void Main_2753()
		{
			var numbers = int.Parse(ReadLine());

			DateTime dateTime = new DateTime(numbers, 3, 1).AddDays(-1);

			if (dateTime.Day != 29)
				WriteLine(0);
			else
				WriteLine(1);
		}
	}
}
