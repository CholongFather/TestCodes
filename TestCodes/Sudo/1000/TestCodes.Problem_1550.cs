using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1550
	{
		static void Main_1550()
		{
            var Dic = new Dictionary<char, int>() { ['0'] = 0, ['1'] = 1, ['2'] = 2, ['3'] = 3, ['4'] = 4, ['5'] = 5, ['6'] = 6, ['7'] = 7, ['8'] = 8, ['9'] = 9, ['A'] = 10, ['B'] = 11, ['C'] = 12, ['D'] = 13, ['E'] = 14, ['F'] = 15 };
            var num = ReadLine();
            var position = 1;
            var result = 0;

            foreach (var c in num.Reverse())
            {
                result += Dic[c] * position;
                position *= 16;
            }

            WriteLine(result);
        }
	}
}
