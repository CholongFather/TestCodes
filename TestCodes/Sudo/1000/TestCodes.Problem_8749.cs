using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_8749
	{
		static void Main_8749()
		{
            var sr = new StreamReader(OpenStandardInput());
            var sw = new StreamWriter(OpenStandardOutput());
            var sb = new StringBuilder();
            sw.AutoFlush = true;

            var testCase = int.Parse(sr.ReadLine());

            for (var i = 0; i < testCase; i++)
            {
                var data = sr.ReadLine().Split(' ').Select(double.Parse).ToArray();

                if (data[0] >= data[1])
                    sb.AppendLine((data[1] - 1).ToString());
                else
                    sb.AppendLine(data[0].ToString());
            }

            sw.Write(sb);
        }
	}
}
