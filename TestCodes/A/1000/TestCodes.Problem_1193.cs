using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1193
	{
		static void Main_1193()
		{
            var num = int.Parse(ReadLine());
            var i = 0;

            while (true)
            {
                i++;
                if (num - i > 0)
                    num = num - i;
                else
                    break;
            }

            if (i % 2 == 1)
            {
                WriteLine($"{i - num + 1}/{num}");
            }
            else
            {
                WriteLine($"{num}/{i - num + 1}");
            }
        }
	}
}
