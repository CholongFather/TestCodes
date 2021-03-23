using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
    class Problem
    {
        static void Main()
        {
            var num = int.Parse(ReadLine());
            var i = 0;

			while(true)
            {
                i++;
                if (num - i > 0)
                    num = num - i;
                else
                    break;
			}

            if (i % 2 == 1)
            {
                WriteLine();
            }
            else
            {
                WriteLine(i);
            }
            WriteLine(num);
        }
    }
}