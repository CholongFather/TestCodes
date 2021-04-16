using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_11729
	{
        static StringBuilder sb = new StringBuilder();
        static int moveCount = 0;
        static void Main_11729()
        {

            hanoi(int.Parse(ReadLine()), 1, 3, 2);
            WriteLine(moveCount);
            Write(sb.ToString());
        }

        private static void hanoi(int size, int start, int to, int via)
        {
            if (size == 1)
                move(start, to);
            else
            {
                hanoi(size - 1, start, via, to);
                move(start, to);
                hanoi(size - 1, via, to, start);
            }
        }

        private static void move(int start, int to)
        {
            moveCount++;
            sb.Append($"{start} {to}\n");
        }
    }
}
