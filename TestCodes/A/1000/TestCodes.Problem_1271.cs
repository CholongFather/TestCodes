using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;
using System.Numerics;

namespace TestCodes
{
    class Problem_1271
    {
        static void Main_1271()
        {
            var data = ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
			WriteLine(data[0] / data[1]);
            WriteLine(data[0] % data[1]);
        }
    }
}