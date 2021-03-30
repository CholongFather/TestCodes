using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
    class Problem_1966
    {
        static void Main_1966()
        {
            var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var input = ReadLine().Split(' ').Select(int.Parse).ToArray();
				var location = input[1];
				var documentArr = ReadLine().Split(' ').Select(int.Parse).ToArray();
				var max = documentArr.Max();
				var lastFound = 0;
				var currentPosition = 0;
				var order = 0;

				for (var j = max; j > 0; j--)
				{
					for (var k = currentPosition; k < documentArr.Length; k++)
					{
						if (documentArr[k] == j)
						{
							documentArr[k] = -1;
							lastFound = k;
							order++;

							if (location == lastFound)
								goto Found;
						}
					}

					for (var k = 0; k < currentPosition; k++)
					{
						if (documentArr[k] == j)
						{
							documentArr[k] = -1;
							lastFound = k;
							order++;

							if (location == lastFound)
								goto Found;
						}
					}

					currentPosition = lastFound;
				}
			Found:
				WriteLine(order);
				continue;
			}
		}
    }
}