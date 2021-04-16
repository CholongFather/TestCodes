using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2748
	{
        static long[] arr = new long[91];
        static void Main_2748()
        {
            var x = int.Parse(ReadLine());

            for (var i = 0; i < x + 1; i++)
            {
                if (i < 2)
                {
                    arr[i] = i;
                    continue;
                }

                if (arr[i] == 0)
                    arr[i] = arr[i - 1] + arr[i - 2];
            }

            WriteLine(arr[x]);
        }
	}
}
