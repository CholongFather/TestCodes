using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_1181
	{
		static void Main_1181()
		{
            var sb = new StringBuilder();
            var testCase = int.Parse(ReadLine());
            var list = new List<string>();

            for (var i = 0; i < testCase; i++)
                list.Add(ReadLine());

            list.Sort(delegate (string x, string y)
            {
                if (x.Length > y.Length)
                    return 1;
                else if (x.Length < y.Length)
                    return -1;
                else
                {
                    return x.CompareTo(y);
                }
            });

            foreach (var item in list.Distinct())
                sb.AppendLine(item);

            Write(sb.ToString());
        }
	}
}
