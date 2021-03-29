using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_19698
	{
		static void Main_19698()
		{
            var num = ReadLine().Split(' ').Select(int.Parse).ToArray();

            var cow = num[0];
            var x = num[1];
            var y = num[2];
            var house = num[3];

            var row = x / house;
            var column = y / house;

            var result = Math.Min(row * column, cow);
            WriteLine(result);
        }
	}
}
