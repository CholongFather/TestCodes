using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2231
	{
		static void Main_2231()
		{
            var num = int.Parse(ReadLine());
            var current = 0;
            var i = 1;
            for (; i < num; i++)
            {
                current = i;

                foreach (var a in i.ToString())
                    current += int.Parse(a.ToString());

                if (current == num)
                    break;
            }

            if (i != num)
                WriteLine(i);
            else
                WriteLine(0);
        }
	}
}
