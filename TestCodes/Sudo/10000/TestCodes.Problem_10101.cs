using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10101
	{
		static void Main_10101()
		{
            var (x, y, z) = (int.Parse(ReadLine()), int.Parse(ReadLine()), int.Parse(ReadLine()));
            var tri = new int[] { x, y, z };

            if (tri.Sum() != 180)
                WriteLine("Error");
            else if (tri.Distinct().Count() == 1)
                WriteLine("Equilateral");
            else if (tri.Distinct().Count() == 2)
                WriteLine("Isosceles");
            else
                WriteLine("Scalene");
        }
	}
}
