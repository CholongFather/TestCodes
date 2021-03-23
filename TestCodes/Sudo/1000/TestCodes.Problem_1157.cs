using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1157
	{
		static void Main_1157()
		{
            var word = ReadLine();
            var dic = new Dictionary<string, int>();

            foreach (var item in word)
            {
                var w = item.ToString().ToUpper();

                if (!dic.ContainsKey(w))
                    dic.Add(w, 1);
                else
                    dic[w]++;
            }

            var max = dic.Max(c => c.Value);

            if (dic.Where(c => c.Value == max).Count() > 1)
                WriteLine("?");
            else
                WriteLine(dic.Where(c => c.Value == max).FirstOrDefault().Key);
        }
	}
}
