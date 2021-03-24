using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_5430
	{
		static void Main_5430()
		{
            var taseCase = int.Parse(ReadLine());

            for (var i = 0; i < taseCase; i++)
            {
                var exec = ReadLine(); ReadLine();
                var list = ReadLine().Split(new string[] { ",", "[", "]" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                var reverse = false;

                foreach (var item in exec)
                {
                    if (item.Equals('R'))
                        reverse = !reverse;
                    else
                    {
                        if (list.Count == 0)
                            goto Error;

                        if (reverse)
                            list.RemoveAt(list.Count - 1);
                        else
                            list.RemoveAt(0);
                    }
                }

                if (reverse)
                {
                    list.Reverse();
                    WriteLine($"[{string.Join(',', list)}]");
                }
                else
                    WriteLine($"[{string.Join(',', list)}]");

                continue;

            Error:
                WriteLine("error");
            }
        }
	}
}
