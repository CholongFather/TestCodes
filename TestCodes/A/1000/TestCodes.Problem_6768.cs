using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_6768
	{
        static void Main_6768()
        {
            var num = int.Parse(ReadLine());

            if (num < 4)
            {
                WriteLine(0);
                return;
            }

            WriteLine(Fact(num - 1, 3) / Fact(3, 3));
        }

        static int Fact(int x, int count)
        {
            if (x <= 1)
                return 1;

            if (count == 0)
                return 1;

            return x * Fact(x - 1, count - 1);
        }
    }
}
