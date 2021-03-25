using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_9020
	{
		static void Main_9020()
		{
            var arr = new bool[200001];
            for (var n = 0; n < Math.Sqrt(arr.Length) + 1; n++)
            {
                if (n < 2)
                {
                    arr[n] = true;
                    continue;
                }

                for (var i = n; i < arr.Length; i += n)
                {
                    if (i != n)
                        arr[i] = true;
                }
            }

            var testCase = int.Parse(ReadLine());

            for (var j = 0; j < testCase; j++)
            {
                var num = int.Parse(ReadLine());
                var a = 10000;
                var s = string.Empty;

                for (var k = 2; k < num; k++)
                {
                    if (!arr[k])
                    {
                        if (!arr[num - k])
                        {
                            if (a > Math.Abs(num - k - k))
                            {
                                a = Math.Abs(num - k - k);
                                s = $"{k} {num - k}";
                            }
                        }
                    }
                }

                WriteLine(s);
            }
        }
	}
}
