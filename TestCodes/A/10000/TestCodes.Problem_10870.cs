using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10870
	{
        static void Main_10870()
        {
            var num = int.Parse(ReadLine());

            WriteLine(Fabonaci(num));
        }

        static int Fabonaci(int x)
        {
            if (x < 2)
                return x;

            return Fabonaci(x - 1) + Fabonaci(x - 2);
        }
    }
}
