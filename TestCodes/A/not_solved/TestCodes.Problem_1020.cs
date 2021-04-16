using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1020
	{
		static void Main_1020()
		{
            var dp = new Dictionary<string, int>();
            var dic = new Dictionary<char, int>() { ['0'] = 6, ['1'] = 2, ['2'] = 5, ['3'] = 5, ['4'] = 4, ['5'] = 5, ['6'] = 6, ['7'] = 3, ['8'] = 7, ['9'] = 5 };
            var a = ReadLine();
            var len = Math.Pow(10, a.Length);
            var num = long.Parse(a);
            var start = 0;
            var time = 0;

            foreach (var item in a)
                start += dic[item];

            while (true)
            {
                num++;
                time++;

                if (num == len)
                    num = 0;

                a = num.ToString().PadLeft(a.Length, '0');
                var b = a.OrderBy(c => c);

                if (dp.ContainsKey(new string(b.ToArray())))
                    continue;

                var count = 0;
                foreach (var item in a)
                    count += dic[item];

                if (count == start)
                    break;

                dp.Add(new string(b.ToArray()), count);
            }

            WriteLine(time);
        }
	}
}
