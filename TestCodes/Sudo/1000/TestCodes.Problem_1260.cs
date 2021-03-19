using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_1260
	{
		static bool[] arrVisited;
		static int[,] adj;
		static StringBuilder sb = new StringBuilder();

		static void Main_1260()
		{
			var numbers = ReadLine().Split(' ').Select(int.Parse).ToList();
			var dot = numbers[0] + 1;
			var road = numbers[0] + 1;
			var now = numbers[2];

			adj = new int[dot, road];

			for (int i = 0; i < numbers[1]; i++)
			{
				var adjRord = ReadLine().Split(' ').Select(int.Parse).ToList();
				adj[adjRord[0], adjRord[1]] = 1;
				adj[adjRord[1], adjRord[0]] = 1;
			}

			arrVisited = new bool[dot];
			DFS(now, dot);
			WriteLine(sb.ToString().TrimEnd(' '));
			sb.Clear();

			arrVisited = new bool[dot];
			BFS(now, dot);
			WriteLine(sb.ToString().TrimEnd(' '));
		}

		private static void DFS(int now, int dot)
		{
			sb.Append(now + " ");
			arrVisited[now] = true;

			for (int i = 1; i < dot; i++)
			{
				if (adj[now, i] == 0)
					continue;

				if (arrVisited[i])
					continue;

				DFS(i, dot);
			}
		}

		private static void BFS(int now, int dot)
		{
			var q = new Queue<int>();
			q.Enqueue(now);

			while (q.Count != 0)
			{
				now = q.Dequeue();

				sb.Append(now + " ");
				arrVisited[now] = true;

				for (int next = 1; next < dot; next++)
				{
					if (adj[now, next] == 0)
						continue;

					if (arrVisited[next])
						continue;

					if (!q.Contains(next))
						q.Enqueue(next);
				}
			}
		}
	}
}
