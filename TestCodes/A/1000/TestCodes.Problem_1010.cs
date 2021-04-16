using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;
using System.Numerics;

namespace TestCodes
{
	class Problem_1010
	{
		static void Main_1010()
		{
            var tc = int.Parse(ReadLine());
            for (var i = 0; i < tc; i++)
            {
                var c = ReadLine().Split(' ').Select(int.Parse).ToArray();
                BigInteger resulta = 1;
                BigInteger resultb = 1;
                var a = c[1];
                var b = c[1] - c[0];

                for (var j = 0; j < c[1] - c[0]; j++)
                {
                    resulta *= a;
                    resultb *= b;
                    a--;
                    b--;
                }

                WriteLine(resulta / resultb);
            }
        }
	}
}
