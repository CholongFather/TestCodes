using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1929
	{
		static void Main_1929()
		{
            var sb = new StringBuilder();
            var x = ReadLine().Split(' ').Select(int.Parse).ToList();

            var arr = new bool[x[1] + 1];
            for (var i = 0; i < Math.Sqrt(x[1] + 1); i++)
            {
                if (i < 2)
                {
                    arr[i] = true;
                    continue;
                }
                else if (arr[i])
                {
                    continue;
                }

                for (int j = i; j < arr.Length; j += i)
                {
                    if (i == j)
                        continue;

                    arr[j] = true;
                }
            }

            for (int k = x[0]; k < arr.Length; k++)
            {
                if (!arr[k])
                    sb.AppendLine(k.ToString());
            }

            WriteLine(sb.ToString());
        }
	}
}
