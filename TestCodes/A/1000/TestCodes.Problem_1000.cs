using System;
using System.Linq;

namespace TestCodes
{
	class Problem_1000
	{
		static void Main_1000()
		{
			string input = Console.ReadLine();

			var numbers = input.Split(' ').Select(Int32.Parse).ToList();

			var a = numbers[0];
			var b = numbers[1];

			Console.WriteLine(a + b);
		}
	}
}
