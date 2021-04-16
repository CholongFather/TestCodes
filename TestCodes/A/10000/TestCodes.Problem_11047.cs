using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_11047
	{
		static Dictionary<int, int> dic = new Dictionary<int, int>();
		static void Main_11047()
		{
			var coins = ReadLine().Split(' ').Select(Int32.Parse).ToList();

			for (int i = 0; i < coins[0]; i++)
				dic.Add(int.Parse(ReadLine()), 0);

			foreach (var coin in dic.Keys.OrderByDescending(c => c))
			{
				if (coins[1] >= coin)
				{
					while (coins[1] >= coin)
					{
						var remain = coins[1] - coin;
						dic[coin]++;

						if (remain >= 0)
							coins[1] = remain;
					}
				}
			}

			WriteLine(dic.Values.Sum());
		}
	}
}
