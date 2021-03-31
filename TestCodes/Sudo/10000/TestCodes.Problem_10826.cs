using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;
using System.Numerics;

namespace TestCodes
{
	class Problem_10826
	{
		static void Main_10826()
		{
            var arr = new BigInteger[10001];

            var x = int.Parse(ReadLine());

            for (var i = 0; i < x + 1; i++)
            {
                if (i < 2)
                {
                    arr[i] = i;
                    continue;
                }

                if (arr[i] == 0)
                    arr[i] = (arr[i - 1] + arr[i - 2]);
            }

            WriteLine(arr[x]);
        }
	}
}
