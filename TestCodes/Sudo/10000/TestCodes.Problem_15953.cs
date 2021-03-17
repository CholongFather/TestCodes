using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace TestCodes
{
	class Program_15953
	{
		public static Dictionary<int, int> Reword1st = new Dictionary<int, int>() { { 1, 5000000 }, { 3, 3000000 }, { 6, 2000000 }, { 10, 500000 }, { 15, 300000 }, { 21, 100000 } };
		public static Dictionary<int, int> Reword2nd = new Dictionary<int, int>() { { 1, 5120000 }, { 3, 2560000 }, { 7, 1280000 }, { 15, 640000 }, { 31, 320000 } };

		static void Main_15953()
		{
			int testCase = Convert.ToInt32(ReadLine());

			for (int i = 0; i < testCase; i++)
			{
				string input = ReadLine();
				var numbers = input.Split(' ').Select(Int32.Parse).ToList();

				var firstReword = RewordCatch(numbers[0], Reword1st);
				var secondReword = RewordCatch(numbers[1], Reword2nd);

				WriteLine((firstReword + secondReword));
			}
		}

		private static int RewordCatch(int number, Dictionary<int, int> reword)
		{
			foreach (var item in reword.Keys)
			{
				if (number == 0)
					return 0;

				if (item < number)
					continue;

				return reword[item];
			}

			return 0;
		}
	}
}