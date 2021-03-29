using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10886
	{
		static void Main_10886()
		{
			var arr = new int[2];
			var answers = int.Parse(ReadLine());

			for (var i = 0; i < answers; i++)
			{
				var answer = int.Parse(ReadLine());
				arr[answer]++;
			}

			if (arr[0] > arr[1])
				WriteLine("Junhee is not cute!");
			else
				WriteLine("Junhee is cute!");
		}
	}
}
