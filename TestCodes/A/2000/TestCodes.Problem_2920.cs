using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2920
	{
		static void Main_2920()
		{
            var arr = ReadLine().Split(' ').ToArray();

            var arrAsc = arr.OrderBy(c => c);
            var arrDesc = arr.OrderByDescending(c => c);

            if (arr.SequenceEqual(arrAsc))
                WriteLine("ascending");
            else if (arr.SequenceEqual(arrDesc))
                WriteLine("descending");
            else
                WriteLine("mixed");
        }
	}
}
