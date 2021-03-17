using System;
using System.Linq;
using System.Text;
using static System.Console;

namespace TestCodes
{
	class Problem_16212
	{
		static void Main_16212()
		{
			int testCase = Convert.ToInt32(ReadLine());

			string input = ReadLine();
			var numbers = input.Split(' ').Select(double.Parse).OrderBy(c => c).ToList();

			StringBuilder returnStr = new StringBuilder();

			foreach (var i in numbers)
			{
				if (i > 2e6)
					continue;

				returnStr.Append(i + " ");
			}

			WriteLine(returnStr.ToString().TrimEnd(' '));
		}
	}
}
