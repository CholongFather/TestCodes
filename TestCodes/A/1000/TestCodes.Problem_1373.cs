using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1373
	{
		static void Main_1373()
		{
            var sr = new StreamReader(OpenStandardInput());
            var sw = new StreamWriter(OpenStandardOutput());
            sw.AutoFlush = true;
            var dic = new Dictionary<string, char>() { ["000"] = '0', ["001"] = '1', ["010"] = '2', ["011"] = '3', ["100"] = '4', ["101"] = '5', ["110"] = '6', ["111"] = '7', };
            var data = sr.ReadLine();
            var arr = new char[333334];
            var current = 0;
            var sb = new StringBuilder();

            for (var i = 3; i <= data.Length; i += 3)
            {
                var last = i - 3;
                arr[current++] = dic[data[^i..^last]];
            }

            if (data.Length % 3 != 0)
            {
                var item = data.Length % 3;
                var last = data[0..item].PadLeft(3, '0');
                arr[current++] = dic[last];
            }

            for (var i = current - 1; i >= 0; i--)
            {
                sb.Append(arr[i]);
            }

            WriteLine(sb);
        }
	}
}
