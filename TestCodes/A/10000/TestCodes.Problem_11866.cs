using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_11866
	{
		static void Main_11866()
		{
			var data = ReadLine().Split(' ').Select(int.Parse).ToArray();
			var arr = new Queue<int>();
			var arrResult = new List<int>();

			for (var i = 0; i < data[0]; i++)
				arr.Enqueue(i + 1);

			while (true)
			{
				for (var i = 0; i < data[1] - 1; i++)
				{
					arr.Enqueue(arr.Dequeue());
				}

				arrResult.Add(arr.Dequeue());

				if (arr.Count == 0)
					break;
			}

			WriteLine($"<{string.Join(", ", arrResult)}>");
		}
	}
}
