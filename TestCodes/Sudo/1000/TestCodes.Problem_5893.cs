using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5893
	{
		static void Main_5893()
		{
            var x = ReadLine().ToCharArray();
            var arr = new int[2000];
            var current = 0;

            foreach (var item in x.Reverse())
            {
                if (item.Equals('1'))
                {
                    if (arr[current] == 1)
                    {
                        for (var i = 0; i < arr.Length; i++)
                        {
                            if (arr[current + i] == 0)
                            {
                                arr[current + i] = 1;
                                break;
                            }
                            else
                                arr[current + i] = 0;
                        }

                    }
                    else
                        arr[current] = 1;

                    if (arr[current + 4] == 1)
                    {
                        for (var i = 4; i < arr.Length; i++)
                        {
                            if (arr[current + i] == 0)
                            {
                                arr[current + i] = 1;
                                break;
                            }
                            else
                                arr[current + i] = 0;
                        }
                    }
                    else
                        arr[current + 4] = 1;
                }

                current++;
            }

            WriteLine(string.Join(' ', arr.Reverse()).Replace(" ", "").TrimStart('0'));
        }
	}
}
