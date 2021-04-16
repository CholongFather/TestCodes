using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1011
	{
		static void Main_1011()
		{
            var testCase = int.Parse(ReadLine());

            for (var i = 0; i < testCase; i++)
            {
                var x = ReadLine().Split(' ').Select(double.Parse).ToList();

                var distance = x[1] - x[0];
                var mid = Math.Ceiling(Math.Sqrt(distance));
                var premove = mid * mid - mid;
                var move = premove >= distance ? mid + mid - 2 : mid + mid - 1;

                if (distance <= 2)
                    move = distance;

                WriteLine(move);
            }
        }
	}
}
