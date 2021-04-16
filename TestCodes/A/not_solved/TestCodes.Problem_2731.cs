using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	//not solved
	class Problem_2731
	{
		static void Main_2731()
		{
			var dic = new Dictionary<char, string>()
			{
				[' '] = "00000",
				['A'] = "00001",
				['B'] = "00010",
				['C'] = "00011",
				['D'] = "00100",
				['E'] = "00101",
				['F'] = "00110",
				['G'] = "00111",
				['H'] = "01000",
				['I'] = "01001",
				['J'] = "01010",
				['K'] = "01011",
				['L'] = "01100",
				['M'] = "01101",
				['N'] = "01110",
				['O'] = "01111",
				['P'] = "10000",
				['Q'] = "10001",
				['R'] = "10010",
				['S'] = "10011",
				['T'] = "10100",
				['U'] = "10101",
				['V'] = "10110",
				['W'] = "10111",
				['X'] = "11000",
				['Y'] = "11001",
				['Z'] = "11010",
			};

			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var input = ReadLine().Split(' ');
				var (x, y, word) = (int.Parse(input[0]), int.Parse(input[1]), input[2]);
				var arr = new int[x,y];

				WriteLine(arr.GetLength(0));
				WriteLine(arr.GetLength(1));

				var vectorx = true;
				var vectory = true;
				var currentx = 0;
				var currenty = 0;

				var decrypt = string.Empty;
				var current = 0;

				foreach(var c in word)
				{
					decrypt += dic[c];
				}

				//소용돌이
				//x -> 
				for (var aj = 0; aj < Math.Min(x, y); aj++)
				{
					if (vectorx)
					{
						for (var q = 0; q < x; q++)
						{
							arr[q, 0] = decrypt[current++];
							currentx = q;
						}
					}
					else
					{
						for (var e = x - aj; e > 0; e--)
						{
							arr[e, currenty] = decrypt[current++];
							currentx = e;
						}
					}

					if (vectory)
					{
						for (var r = 0; r < y - aj; r++)
						{
							arr[currentx, r] = decrypt[current++];
							currenty = r;
						}
					}
					else
					{
						for (var w = y - aj; w > 0; w--)
						{
							arr[aj, w] = decrypt[current++];
							currenty = w;
						}
					}
					vectorx = !vectorx;
					vectory = !vectory;
				}

				for (var j = 0; j < arr.GetLength(1); j++)
				{
					for (var k = 0; k < arr.GetLength(0); k++)
					{
						if (arr[k, j] == 48)
							Write(0);
						else if (arr[k, j] == 49)
							Write(1);
						else
							Write(0);
					}
				}
			}
		}
	}
}
