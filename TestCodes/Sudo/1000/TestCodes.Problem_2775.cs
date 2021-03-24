using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2775
	{
		static void Main_2775()
		{
            var testCase = int.Parse(ReadLine());

            var a = new int[15, 15];
            for (int j = 0; j <= 14; j++)
            {
                for (int k = 0; k <= 14; k++)
                {
                    if (j == 0)
                        a[j, k] = k;
                    else
                    {
                        for (int l = 0; l <= k; l++)
                        {
                            a[j, k] += a[j - 1, l];
                        }

                    }
                }
            }

            for (var i = 0; i < testCase; i++)
            {
                var floor = int.Parse(ReadLine());
                var room = int.Parse(ReadLine());
                WriteLine(a[floor, room]);
            }
        }
	}
}
