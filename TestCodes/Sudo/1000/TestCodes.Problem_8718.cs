using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_8718
	{
		static void Main_8718()
		{
            var snow = ReadLine().Split(' ').Select(long.Parse).Select(c => c * 1000).ToArray();

            var small = snow[1] / 4 + snow[1] / 2 + snow[1];
            var mid = snow[1] / 2 + snow[1] + snow[1] * 2;
            var large = snow[1] + snow[1] * 2 + snow[1] * 4;

            if (snow[0] >= large)
                WriteLine(large);
            else if (snow[0] >= mid)
                WriteLine(mid);
            else if (snow[0] >= small)
                WriteLine(small);
            else
                WriteLine(0);
        }
	}
}
