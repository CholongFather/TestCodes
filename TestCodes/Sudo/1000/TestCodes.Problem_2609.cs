using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2609
	{
		static void Main_2609()
		{
			var num = ReadLine().Split(' ').Select(Int32.Parse).ToArray();

			WriteLine(GetGreaterCommonDivide(num[0], num[1]));
			WriteLine(GetLeastCommonMultiple(num[0], num[1]));
		}

		public static int GetLeastCommonMultiple(int num1, int num2)
		{
			var i = 1;
			for (; !(i % num1 == 0 && i % num2 == 0); i++) ;
			return i;
		}

		public static int GetGreaterCommonDivide(int num1, int num2)
		{
			var i = num1 > num2 ? num1 : num2;
			for (; !(num1 % i == 0 && num2 % i == 0); i--) ;
			return i;
		}
	}
}
