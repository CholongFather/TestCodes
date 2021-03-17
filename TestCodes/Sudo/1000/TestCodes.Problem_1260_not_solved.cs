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

			DFS(now, dot);
			WriteLine(sb.ToString().TrimEnd(' '));
			sb.Clear();
			BFS(now, dot);
			WriteLine(sb.ToString().TrimEnd(' '));
		}

		private static void DFS(int now, int dot)
		{
			arrVisited = new bool[dot];

			Stack<int> stack = new Stack<int>();
			stack.Push(now);

			while (stack.Count != 0)
			{
				var currentLocation = stack.Pop();
				sb.Append(currentLocation + " ");
				arrVisited[currentLocation] = true;

				for (int next = 1; next < dot; next++)
				{
					if (adj[currentLocation, next] == 0)
						continue;

					if (arrVisited[next])
						continue;

					if (!stack.Contains(next))
						stack.Push(next);
				}
			}
		}

		private static void BFS(int now, int dot)
		{
			arrVisited = new bool[dot];

			Queue<int> queue = new Queue<int>();
			queue.Enqueue(now);

			while (queue.Count != 0)
			{
				var currentLocation = queue.Dequeue();

				sb.Append(currentLocation + " ");
				arrVisited[currentLocation] = true;

				for (int next = 1; next < dot; next++)
				{
					if (adj[currentLocation, next] == 0)
						continue;

					if (arrVisited[next])
						continue;

					if (!queue.Contains(next))
						queue.Enqueue(next);
				}
			}
		}
	}
}
