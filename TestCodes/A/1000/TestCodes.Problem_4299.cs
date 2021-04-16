using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_4299
	{
		static void Main_4299()
		{
            var score = ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (score[1] > score[0])
            {
                WriteLine("-1");
                return;
            }

            var a = (score[0] + score[1]) / 2.0;
            var b = (score[0] - score[1]) / 2.0;

            if (a % 1 == 0 && b % 1 == 0)
            {
                if (a > b)
                    WriteLine($"{a} {b}");
                else
                    WriteLine($"{b} {a}");
            }
            else
                WriteLine("-1");
        }
	}
}
