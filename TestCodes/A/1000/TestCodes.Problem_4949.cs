using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_4949
	{
		static void Main_4949()
		{
            while (true)
            {
                var stack = new Stack<char>();
                var word = ReadLine();
                var sb = new StringBuilder();

                if (word == ".")
                    break;

                foreach (var c in word)
                {
                    switch (c)
                    {
                        case '(':
                        case '[':
                            stack.Push(c);
                            break;
                        case ')':
                            if (stack.Count == 0 || !stack.Pop().Equals('('))
                            {
                                sb.AppendLine("no");
                                goto Next;
                            }
                            break;
                        case ']':
                            if (stack.Count == 0 || !stack.Pop().Equals('['))
                            {
                                sb.AppendLine("no");
                                goto Next;
                            }
                            break;
                        case '.':
                            if (stack.Count != 0)
                                sb.AppendLine("no");
                            else
                                sb.AppendLine("yes");
                            break;
                        default:
                            break;
                    }
                }
            Next:;
                Write(sb);
            }
        }
	}
}
