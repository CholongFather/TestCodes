using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1422
	{
		static void Main_1422()
		{
            var numbers = ReadLine().Split(' ').Select(Int32.Parse).ToList();
            var list = new List<string>();

            for (var i = 0; i < numbers[0]; i++)
            {
                list.Add(ReadLine());
            }

            for (var i = numbers[0]; i < numbers[1]; i++)
            {
                list.Add(list.Select(double.Parse).Max().ToString());
            }

            list.Sort(delegate (string x, string y)
            {
                if (double.Parse(x + y) > double.Parse(y + x))
                    return -1;
                else
                    return 1;
            });

            foreach (var item in list)
            {
                Write(item);
            }

            WriteLine();
        }
	}
}
