using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1436
	{
		static void Main_1436()
		{
            var num = int.Parse(ReadLine());
            var count = 0;
            for (var i = 666; i < 10000000; i++)
            {
                var word = i.ToString();
                if (word.Contains("666"))
                    count++;

                if (count == num)
                {
                    WriteLine(i);
                    break;
                }
            }
        }
	}
}
