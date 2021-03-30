using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2480
	{
		static void Main_2480()
		{
            var numbers = ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = 0;

            if (numbers[0] == numbers[1] && numbers[1] == numbers[2])
                result = 10000 + numbers[0] * 1000;
            else if (numbers[0] == numbers[1])
                result = 1000 + numbers[1] * 100;
            else if (numbers[0] == numbers[2])
                result = 1000 + numbers[2] * 100;
            else if (numbers[1] == numbers[2])
                result = 1000 + numbers[1] * 100;
            else
                result = numbers.Max() * 100;

            WriteLine(result);
        }
	}
}
