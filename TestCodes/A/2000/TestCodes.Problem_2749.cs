using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2749
	{
		static void Main_2749()
		{
            var moduler = 1000000;
            var pisanoPeriod = moduler / 10 * 15;
            var arr = new long[pisanoPeriod + 1];

            var x = long.Parse(ReadLine()) % pisanoPeriod;

            for (var i = 0; i < x + 1; i++)
            {
                if (i < 2)
                {
                    arr[i] = i;
                    continue;
                }

                if (arr[i] == 0)
                    arr[i] = (arr[i - 1] + arr[i - 2]) % moduler;
            }

            WriteLine(arr[x]);
        }
	}
}
