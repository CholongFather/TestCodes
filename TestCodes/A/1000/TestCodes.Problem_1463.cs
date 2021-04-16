using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1463
	{
		static void Main_1463()
		{
            var num = int.Parse(ReadLine());
            var arr = new int[1000001];
            arr[1] = 0;
            arr[2] = 1;
            arr[3] = 1;
            var x = num;

            for (var i = 4; i <= x; i++)
            {
                arr[i] = arr[i - 1] + 1;
                if (i % 3 == 0) arr[i] = Math.Min(arr[i], arr[i / 3] + 1);
                if (i % 2 == 0) arr[i] = Math.Min(arr[i], arr[i / 2] + 1);
            }

            WriteLine(arr[x]);
        }
	}
}
