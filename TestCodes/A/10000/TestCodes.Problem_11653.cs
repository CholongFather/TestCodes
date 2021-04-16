using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_11653
	{
		static void Main_11653()
		{
            var num = int.Parse(ReadLine());
            var list = new List<int>();

            if (num == 1)
                return;

            while (num != 1)
            {
                for (int i = 2; i < num + 1; i++)
                {
                    if (num % i == 0)
                    {
                        list.Add(i);
                        num /= i;
                        break;
                    }
                }
            }

            foreach (var item in list.OrderBy(c => c))
            {
                WriteLine(item);
            }
        }
	}
}
