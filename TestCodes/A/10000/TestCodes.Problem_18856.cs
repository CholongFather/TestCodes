using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_18856
	{
		static void Main_18856()
		{
            var input = int.Parse(ReadLine());
            WriteLine(input);
            var sb = new StringBuilder();

            var arr = new bool[1000];
            for (var i = 0; i < Math.Sqrt(1000); i++)
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

            for (var i = 1; i < input + 1; i++)
            {
                if (i < input)
                    sb.Append(i).Append(' ');

                if (i == input)
                {
                    for (var j = i; j < arr.Length; j++)
                    {
                        if (!arr[j])
                        {
                            sb.Append(j);
                            break;
                        }
                    }
                }
            }

            WriteLine(sb.ToString());

        }
	}
}
