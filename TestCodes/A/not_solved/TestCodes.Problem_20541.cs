using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_20541
	{
        static void Main_20541()
        {
            var dic = new Dictionary<string, Dictionary<string, int>>();
            var path = new Stack<string>();

            var tc = int.Parse(ReadLine());

            for (var i = 0; i < tc; i++)
            {
                var exec = ReadLine().Split(' ').ToArray();
                var ret = Exec(dic, path, exec[0], exec.Length > 1 ? exec[1] : "");

                if (string.IsNullOrWhiteSpace(ret) == false)
                    WriteLine(ret);
            }
        }

        static string Exec(Dictionary<string, Dictionary<string, int>> dic, Stack<string> path, string exec, string name)
        {
            var current = string.Empty;

            switch (exec)
            {
                case "mkalb":
                    if (dic.ContainsKey(name))
                        return "duplicated album name";
                    else
                        dic.Add(name, new Dictionary<string, int>());
                    break;
                case "rmalb":
                    switch (name)
                    {
                        case "0":
                            break;
                        case "1":
                            break;
                        case "-1":
                            break;
                        default:
                            break;
                    }
                    break;
                case "insert":
                    if (dic[current].ContainsKey(name))
                        return "duplicated photo name";
                    else
                        dic[current].Add(name, 0);
                    break;
                case "delete":
                    switch (name)
                    {
                        case "0":
                            break;
                        case "1":
                            break;
                        case "-1":
                            break;
                        default:
                            break;
                    }
                    break;
                case "ca":
                    switch (name)
                    {
                        case "/":
                            path.Clear();
                            break;
                        case "...":
                            path.Pop();
                            break;
                        default:
                            path.Push(name);
                            break;
                    }
                    break;
                default:
                    break;
            }

            return "";
        }
    }
}
