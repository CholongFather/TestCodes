using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace TestCodes
{
	class Program_1330
	{
		static void Main_1330()
		{
			string input = ReadLine();
			var numbers = input.Split(' ').Select(double.Parse).ToList();

			var returnStr = string.Empty;

			if (numbers[0] > numbers[1])
				returnStr = ">";
			else if (numbers[0] < numbers[1])
				returnStr = "<";
			else
				returnStr = "==";

			WriteLine(returnStr);
		}
	}
}