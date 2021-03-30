using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_9325
	{
		static void Main_9325()
		{
            var testCase = int.Parse(ReadLine());

            for (var i = 0; i < testCase; i++)
            {
                var (car, optionCount) = (int.Parse(ReadLine()), int.Parse(ReadLine()));

                var optionTotal = 0;

                for (var j = 0; j < optionCount; j++)
                {
                    var option = ReadLine().Split(' ').Select(int.Parse).ToArray();
                    optionTotal += option[0] * option[1];
                }

                WriteLine(car + optionTotal);
            }
        }
	}
}
