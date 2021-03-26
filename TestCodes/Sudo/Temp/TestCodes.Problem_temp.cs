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
				var arr = new int?[x,y];

				var vectorx = true;
				var vectory = true;

				var decrypt = string.Empty;
				var current = 0;

				foreach(var c in word)
				{
					decrypt += dic[c];
				}

				for (var c = 0; c < y; c++)
				{
					if (vectory)
					{
						for (int k = 0; k < y; k++)
						{
							if (vectorx)
							{
								for (int l = 0; l < x; l++)
								{
									if (arr[l, k] != null)
										continue;

									arr[l, k] = decrypt[current++];
								}
								vectorx = !vectorx;
							}
							else
							{
								for (int l = x; l < 0; l--)
								{
									if (arr[l, k] != null)
										continue;

									arr[l, k] = decrypt[current++];
								}
								vectorx = !vectorx;
							}
						}
						vectory = !vectory;
					}
					else
					{
						for (int k = y; k < 0; k--)
						{
							if (vectorx)
							{
								for (int l = 0; l < x; l++)
								{
									if (arr[l, k] != null)
										continue;

									arr[l, k] = decrypt[current++];
								}
								vectorx = !vectorx;
							}
							else
							{
								for (int l = x; l < 0; l++)
								{
									if (arr[l, k] != null)
										continue;

									arr[l, k] = decrypt[current++];
								}
								vectorx = !vectorx;
							}
						}
						vectory = !vectory;
					}
				}

				for (var j = 0; j < x; j++)
				{
					for (var k = 0; k < y; k++)
					{
						if(arr[k, j] == null)
							Write(0); 
						else if (arr[k, j] == 48)
							Write(0);
						else if (arr[k, j] == 49)
							Write(1);
					}
				}
			}

		}
	}
}
