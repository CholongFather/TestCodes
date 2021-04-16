using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
    class Problem_8741
    {
        static void Main_8741()
        {
            var num = int.Parse(ReadLine());

            var Zero = string.Empty;
            var One = string.Empty;

			WriteLine($"{ One.PadLeft(num, '1')}{ Zero.PadLeft(num - 1, '0')}");
        }
    }
}