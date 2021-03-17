using System;
using static System.Console;

namespace TestCodes
{
	class Problem_1003
	{
		static void Main_1003()
		{
			var testCase = Convert.ToInt32(ReadLine());

			int[] fibo = new int[41];
			fibo[0] = 0; fibo[1] = 1;

			for (var i = 2; i < 41; i++)
			{
				fibo[i] = fibo[i - 1] + fibo[i - 2];
			}

			for (var i = 0; i < testCase; i++)
			{
				var number = Convert.ToInt32(ReadLine());

				if (number == 0) WriteLine("1 0");
				else WriteLine($"{fibo[number - 1]} {fibo[number]}");
			}
		}
	}
}
