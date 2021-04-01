using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1212
	{
		static void Main_1212()
		{
            var sr = new StreamReader(OpenStandardInput());
            var sw = new StreamWriter(OpenStandardOutput());
            sw.AutoFlush = true;
            var dic = new Dictionary<char, string>() { ['0'] = "000", ['1'] = "001", ['2'] = "010", ['3'] = "011", ['4'] = "100", ['5'] = "101", ['6'] = "110", ['7'] = "111", };
            var data = sr.ReadLine();
            var arr = new char[10000001];
            var current = 0;
            var sb = new StringBuilder();

            for (var i = 1; i <= data.Length; i++)
            {
                arr[current] = dic[data[^i]][2];
                arr[current + 1] = dic[data[^i]][1];
                arr[current + 2] = dic[data[^i]][0];
                current += 3;
            }

            for (var i = current - 1; i >= 0; i--)
            {
                sb.Append(arr[i]);
            }

            if (sb.ToString() != "000")
                WriteLine(sb.ToString().TrimStart('0'));
            else
                WriteLine(0);
        }
	}
}
