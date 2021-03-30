using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2754
	{
		static void Main_2754()
		{
            var dic = new Dictionary<char, double>() { ['A'] = 4.0, ['B'] = 3.0, ['C'] = 2.0, ['D'] = 1.0, ['F'] = 0.0 };
            var score = ReadLine();
            var result = 0.0;

            foreach (var c in score)
            {
                if (dic.ContainsKey(c))
                    result = dic[c];

                var a = dic.Keys.OrderBy(c => c).ToArray();

                if (c.Equals('+'))
                    result += 0.3;
                else if (c.Equals('-'))
                    result -= 0.3;
            }

            WriteLine(string.Format("{0:0.0}", result));
        }
	}
}
