using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1316
	{
		static void Main_1316()
		{
            var testCase = int.Parse(ReadLine());
            var result = 0;
            for (var i = 0; i < testCase; i++)
            {
                var word = ReadLine();

                char current = '0';
                var list = new List<char>();

                foreach (var ch in word)
                {
                    if (current != ch)
                    {
                        current = ch;

                        if (list.Contains(ch))
                        {
                            current = '1';
                            break;
                        }

                        list.Add(ch);
                    }
                }

                if (current != '1')
                    result++;
            }

            WriteLine(result);
        }
	}
}
