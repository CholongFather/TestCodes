using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10866
	{
		static void Main_10866()
		{
			var sr = new StreamReader(OpenStandardInput());
			var sw = new StreamWriter(OpenStandardOutput()) { AutoFlush = true };
			var sb = new StringBuilder();

			var tc = int.Parse(sr.ReadLine());
			var list = new LinkedList<string>();


			for (var i = 0; i < tc; i++)
			{
				var exec = sr.ReadLine().Split().ToArray();

				Exec(list, sb, exec[0], exec.Length != 1 ? exec[1] : "0");
			}

			sw.Write(sb);
		}

		static void Exec(LinkedList<string> list, StringBuilder sb, string exec, string num)
		{
			switch (exec)
			{
				case "push_front":
					list.AddFirst(num);
					break;
				case "push_back":
					list.AddLast(num);
					break;
				case "pop_front":
					if (list.Count != 0)
					{
						sb.AppendLine(list.First());
						list.RemoveFirst();
					}
					else
						sb.AppendLine("-1");
					break;
				case "pop_back":
					if (list.Count != 0)
					{
						sb.AppendLine(list.Last());
						list.RemoveLast();
					}
					else
						sb.AppendLine("-1");
					break;
				case "size":
					sb.AppendLine(list.Count().ToString());
					break;
				case "empty":
					if (list.Count() == 0)
						sb.AppendLine("1");
					else
						sb.AppendLine("0");
					break;
				case "front":
					if (list.Count != 0)
						sb.AppendLine(list.First());
					else
						sb.AppendLine("-1");
					break;
				case "back":
					if (list.Count != 0)
						sb.AppendLine(list.Last());
					else
						sb.AppendLine("-1");
					break;
				default:
					break;
			}
		}
	}
}
