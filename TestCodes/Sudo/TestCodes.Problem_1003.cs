using System;

namespace TestCodes
{
	class Problem_1003
	{
		static void Main_1003(string[] args)
		{
			int testCase = Convert.ToInt32(Console.ReadLine());

			int[] fibo = new int[41];
			fibo[0] = 0; fibo[1] = 1;

			for (int i = 2; i < 41; i++)
			{
				fibo[i] = fibo[i - 1] + fibo[i - 2];
			}

			for (int i = 0; i < testCase; i++)
			{
				int number = Convert.ToInt32(Console.ReadLine());
				if (number == 0) Console.WriteLine("1 0");
				else Console.WriteLine($"{fibo[number - 1]} {fibo[number]}");
			}
		}
	}
}
