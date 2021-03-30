using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
    class Problem
    {
        static void Main()
        {
            var testCase = int.Parse(ReadLine());

            for (var i = 0; i < testCase; i++)
            {
                var data = ReadLine().Split(' ').Select(double.Parse).ToArray();

                while (data[0] >= data[1])
                {
                    var last = data[0] % data[1];

                    if (last != 0)
                    {
                        var group = (data[0] - last) / data[1];
                        var remain = group * (data[1] - 1) + (last - 1);

                        data[0] = remain;
                    }
                    else
                    {
                        var group = (data[0]) / data[1];
                        var remain = group * (data[1] - 1);

                        data[0] = remain;
                    }
                }

                WriteLine(data[0]);
            }
        }
    }
}