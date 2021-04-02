using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1149
	{
		static void Main_1149()
		{
            int[,] cost = new int[1001, 3];
            int[,] sum = new int[1001, 3];
            var tc = int.Parse(ReadLine());

            for (var i = 0; i < tc; i++)
            {
                var color = ReadLine().Split(' ').Select(int.Parse).ToList();
                cost[i + 1, 0] = color[0];
                cost[i + 1, 1] = color[1];
                cost[i + 1, 2] = color[2];
            }

            for (var i = 1; i < tc + 1; i++)
            {
                sum[i, 0] = Math.Min(sum[i - 1, 1], sum[i - 1, 2]) + cost[i, 0];
                sum[i, 1] = Math.Min(sum[i - 1, 0], sum[i - 1, 2]) + cost[i, 1];
                sum[i, 2] = Math.Min(sum[i - 1, 0], sum[i - 1, 1]) + cost[i, 2];
            }

            var x = Math.Min(Math.Min(sum[tc, 0], sum[tc, 1]), sum[tc, 2]);
            WriteLine(x);
        }
	}
}
