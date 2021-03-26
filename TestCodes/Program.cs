﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
    class Problem_
    {
        static void Main_(string[] args)
        {
            var sb = new StringBuilder();
            var ex = new char[] { '*', '/', '+', '-', '(', ')' };
            
            var expression = ReadLine();
            var stack = new Stack<char>();

            foreach(var item in expression)
            {
                if (ex.Contains(item))
                {
                    if (item.Equals(')'))
                    {
                        char s;
                        while (!(s = stack.Pop()).Equals('('))
                        {
                            sb.Append(s);
                        }

                        continue;
                    }

                    if (stack.Count > 0)
                    {
                        //우선순위 () */ +-
                        switch (item)
                        {
                            case '+':
                            case '-':
                                {
                                    while (!stack.Peek().Equals('('))
                                    {
                                        sb.Append(stack.Pop());
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        stack.Push(item);
                    }
                    else
                        stack.Push(item);
				}
                else
                {
                    sb.Append(item);
				}
			}

            while(stack.Count != 0)
            {
                sb.Append(stack.Pop());
            }

			WriteLine(sb.ToString());
        }
    }
}
