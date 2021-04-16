using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_6764
	{
		static void Main_6764()
		{
            var prev = 0;
            var check = 0;
            var constant = true;

            for (var i = 0; i < 4; i++)
            {
                var current = int.Parse(ReadLine());
                if (i != 0)
                {
                    if (prev != current)
                    {
                        if (prev < current)
                            check++;
                        else if (prev > current)
                            check--;

                        constant = false;
                    }
                }
                prev = current;
            }

            if (check == 3)
                WriteLine("Fish Rising");
            else if (check == -3)
                WriteLine("Fish Diving");
            else if (constant)
                WriteLine("Fish At Constant Depth");
            else
                WriteLine("No Fish");
        }
	}
}
