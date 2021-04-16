using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_9498
	{
		public static Dictionary<int, string> DicScore = new Dictionary<int, string> { [90] = "A", [80] = "B", [70] = "C", [60] = "D", [0] = "F", };

		static void Main_9498()
		{
			var testScore = int.Parse(ReadLine());

			foreach (var score in DicScore.Keys)
			{
				if (testScore >= score)
				{
					Console.WriteLine(DicScore[score]);
					break;
				}
			}
		}
	}
}
