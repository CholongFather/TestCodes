using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2108
	{
		static void Main_2108()
		{
            var sb = new StringBuilder();
            var testCase = int.Parse(ReadLine());
            var list = new List<int>();
            var dic = new Dictionary<int, int>();

            var total = 0;

            for (var i = 0; i < testCase; i++)
            {
                var num = int.Parse(ReadLine());
                total += num;

                if (!dic.ContainsKey(num))
                    dic.Add(num, 1);
                else
                    dic[num]++;

                list.Add(num);
            }

            list = list.OrderBy(c => c).ToList();

            var average = Math.Round((double)total / (double)testCase);
            var mid = (int)Math.Truncate((double)testCase / 2);

            WriteLine(average);
            WriteLine(list[mid]);
            WriteLine(dic.Where(c => c.Value == dic.Values.Max()).OrderBy(c => c.Key).Take(2).LastOrDefault().Key);
            WriteLine(dic.Keys.Max() - dic.Keys.Min());
        }
	}
}
