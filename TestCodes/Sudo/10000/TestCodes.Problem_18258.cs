using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_18258
	{
        static Queue<int> queue = new Queue<int>();
        static StringBuilder sb = new StringBuilder();

        static void Main_18258()
        {
            var sr = new StreamReader(OpenStandardInput());
            var sw = new StreamWriter(OpenStandardOutput());
            sw.AutoFlush = true;

            var count = int.Parse(sr.ReadLine());
            var last = string.Empty;

            for (var i = 0; i < count; i++)
            {
                var command = sr.ReadLine().Split(' ');

                switch (command[0])
                {
                    case "push":
                        queue.Enqueue(int.Parse(command[1]));
                        last = command[1];
                        break;
                    case "pop":
                        if (queue.Count != 0)
                            sb.AppendLine(queue.Dequeue().ToString());
                        else
                            sb.AppendLine("-1");
                        break;
                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;
                    case "empty":
                        if (queue.Count == 0)
                            sb.AppendLine("1");
                        else
                            sb.AppendLine("0");
                        break;
                    case "front":
                        if (queue.Count == 0)
                            sb.AppendLine("-1");
                        else
                            sb.AppendLine(queue.Peek().ToString());
                        break;
                    case "back":
                        if (queue.Count == 0)
                            sb.AppendLine("-1");
                        else
                            sb.AppendLine(last);
                        break;
                    default:
                        break;
                }
            }

            sw.Write(sb.ToString());
        }
    }
}
