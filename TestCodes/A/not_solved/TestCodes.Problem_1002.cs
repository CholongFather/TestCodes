using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
    class Problem_1002
    {
        static void Main_1002()
        {
            var testCase = int.Parse(ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var l = ReadLine().Split(' ').Select(double.Parse).ToList();
                double x1 = l[0], y1 = l[1], r1 = l[2];
                double x2 = l[3], y2 = l[4], r2 = l[5];

                double D = 0, X = 0, Y = 0;
                double T1 = 0, T2 = 0, T3 = 0, T4 = 0, T5 = 0, T6 = 0;

                X = x2 - x1;
                Y = y2 - y1;

                if ((X == Y) && (r1 == r2))
                {
                    WriteLine(-1);
                    continue;
                }

                D = Math.Sqrt((X * X) + (Y * Y));

                T1 = Math.Acos((r1 * r1 - r2 * r2 + D * D) / (2 * r1 * D));
                T2 = Math.Atan(Y / X);
                T3 = x1 + r1 * Math.Cos(T2 + T1);
                T4 = y1 + r1 * Math.Sin(T2 + T1);
                T5 = x1 + r1 * Math.Cos(T2 - T1);
                T6 = y1 + r1 * Math.Sin(T2 - T1);

                if (T3 == double.NaN)
                {
                    WriteLine(0);
                    continue;
                }

                if ((T3 == T5) && (T4 == T6))
                {
                    WriteLine(1);
                    continue;
                }

                WriteLine(2);
            }
        }
    }
}
