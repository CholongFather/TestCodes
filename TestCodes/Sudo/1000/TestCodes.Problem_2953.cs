using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2953
	{
		static void Main_2953()
		{
            var max = 0;
            var position = 0;
            for (var i = 0; i < 5; i++)
            {
                var current = ReadLine().Split(' ').Select(int.Parse).Sum();
                if (max < current)
                {
                    max = current;
                    position = i + 1;
                }
            }

            WriteLine($"{position} {max}");
        }
	}
}
