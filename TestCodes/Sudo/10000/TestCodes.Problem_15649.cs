using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_15649
	{
        static List<string> list = new List<string>();
        static void Main_15649()
		{
            var num = ReadLine().Split(' ').Select(int.Parse).ToList();
            A(num[0], num[1]);

            foreach (var item in list)
            {
                WriteLine(item);
            }
        }

        static void A(int range, int position)
        {
            if (list.Count == 0)
            {
                for (var i = 1; i < range + 1; i++)
                {
                    list.Add(i.ToString());
                }
            }
            else
            {
                var newList = new List<string>();
                foreach (var item in list)
                {
                    for (var i = 1; i < range + 1; i++)
                    {
                        if (!item.Contains(i.ToString()))
                            newList.Add($"{item} {i}");
                    }
                }

                list = newList;
            }

            if (position == 1)
                return;
            else
                A(range, position - 1);
        }
    }
}
