using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5575
	{
		static void Main_5575()
		{
			for (var i = 0; i < 3; i++)
			{
				var timeCard = ReadLine().Split(' ').Select(int.Parse).ToArray();
				var start = new TimeSpan(timeCard[0], timeCard[1], timeCard[2]);
				var end = new TimeSpan(timeCard[3], timeCard[4], timeCard[5]);
				var workTime = end - start;

				WriteLine($"{workTime.Hours} {workTime.Minutes} {workTime.Seconds}");
			}
		}
	}
}
