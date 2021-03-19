using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1931
	{
		static void Main_1931()
		{
			var max = 0;
			var testCase = int.Parse(ReadLine());
			var arr = new List<double[]>();

			for (var i = 0; i < testCase; i++)
			{
				var numbers = ReadLine().Split(' ').Select(double.Parse).ToArray();
				arr.Add(numbers);
			}

			arr = arr.OrderBy(c => c[1]).ThenBy(c => c[0]).ToList();
			double currentTime = 0;
			var lastestTime = arr.Max(c => c[1]);

			while (true)
			{
				var meeting = arr.Where(c => c[0] >= currentTime).FirstOrDefault();
				if (meeting == null)
					break;

				arr.Remove(meeting);

				currentTime = meeting[1];
				max++;

				if (currentTime == lastestTime)
				{
					max += arr.Where(c => c[0] == lastestTime).Count();
					break;
				}
			}

			WriteLine(max);
		}
	}
}
