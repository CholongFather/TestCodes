using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10816
	{
		static void Main_10816()
		{
            var sr = new StreamReader(OpenStandardInput());
            var sw = new StreamWriter(OpenStandardOutput());
            var sb = new StringBuilder();
            sw.AutoFlush = true;

            var cardCount = int.Parse(ReadLine());
            var cards = ReadLine().Split(' ').Select(int.Parse).GroupBy(c => c).ToDictionary(c => c.Key, v => v.Count());
            ReadLine();
            var check = ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var item in check)
            {
                if (cards.ContainsKey(item))
                    sb.Append($"{cards[item]} ");
                else
                    sb.Append("0 ");
            }

            WriteLine(sb.ToString().TrimEnd());
        }
	}
}
