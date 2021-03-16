using System;
using System.Linq;

namespace TestCodes
{
	class Problem_1001
	{
		static void Main_1001(string[] args)
		{
			string input = Console.ReadLine();

			var numbers = input.Split(' ').Select(Int32.Parse).ToList();

			var a = numbers[0];
			var b = numbers[1];

			Console.WriteLine(a-b);
		}
	}
}
