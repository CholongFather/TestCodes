using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10828
	{
        static Stack<int> stack = new Stack<int>();
        static StringBuilder sb = new StringBuilder();
        
        static void Main_10828()
		{
            var sr = new StreamReader(OpenStandardInput());
            var sw = new StreamWriter(OpenStandardOutput());
            sw.AutoFlush = true;

            var count = int.Parse(sr.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var command = sr.ReadLine().Split(' ');

                switch (command[0])
                {
                    case "push":
                        stack.Push(int.Parse(command[1]));
                        break;
                    case "pop":
                        if (stack.Count != 0)
                            sb.AppendLine(stack.Pop().ToString());
                        else
                            sb.AppendLine("-1");
                        break;
                    case "size":
                        sb.AppendLine(stack.Count.ToString());
                        break;
                    case "empty":
                        if (stack.Count == 0)
                            sb.AppendLine("1");
                        else
                            sb.AppendLine("0");
                        break;
                    case "top":
                        if (stack.Count == 0)
                            sb.AppendLine("-1");
                        else
                            sb.AppendLine(stack.Peek().ToString());
                        break;
                    default:
                        break;
                }
            }

            sw.Write(sb.ToString());
        }
	}
}
