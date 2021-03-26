using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_2447
	{
        static char[,] star = new char[3, 3] { { '*', '*', '*' }, { '*', ' ', '*' }, { '*', '*', '*' } };
        static void Main_2447(string[] args)
        {
            var size = int.Parse(ReadLine());
            Star(size);
            Draw(size);
        }

        static void Star(int size)
        {
            if (size % 3 != 0 || size == 3)
                return;
            else
                Star(size / 3);

            var newStar = new char[size, size];

            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                {
                    var x = (double)i / size;
                    var y = (double)j / size;

                    if (x >= 1.0 / 3.0 && x < 2.0 / 3.0 && y >= 1.0 / 3.0 && y < 2.0 / 3.0)
                        newStar[i, j] = ' ';
                    else
                        newStar[i, j] = star[i % (size / 3), j % (size / 3)];
                }

            star = newStar;
        }

        static void Draw(int size)
        {
            var sb = new StringBuilder();

            if (size == 0)
                sb.Append(' ');

            if (size == 1)
                sb.Append('*');

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    sb.Append(star[i, j]);
                }
                sb.AppendLine();
            }

            WriteLine(sb.ToString());
        }
    }
}
