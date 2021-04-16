using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_20125
	{
		static void Main_20125()
		{
            var cell = int.Parse(ReadLine());
            var isFindHead = false;
            var leftArm = 0;
            var rightArm = 0;
            var waist = 0;
            var leftLeg = 0;
            var rightLeg = 0;
            var heart = new int[2];

            for (var i = 0; i < cell; i++)
            {
                var row = ReadLine();
                if (row.Contains('*'))
                {
                    for (var j = 0; j < cell; j++)
                    {
                        if (!row[j].Equals('*'))
                            continue;

                        if (!isFindHead)
                        {
                            heart[0] = i + 2;
                            heart[1] = j + 1;
                            isFindHead = true;
                            continue;
                        }

                        if (isFindHead)
                        {
                            if (heart[0] == i + 1)
                            {
                                if (heart[1] > j + 1)
                                    leftArm++;
                                else if (heart[1] < j + 1)
                                    rightArm++;
                            }
                            else
                            {
                                if (row.Where(c => c == '*').Count() == 1 && heart[1] == j + 1)
                                {
                                    waist++;
                                    break;
                                }

                                if (heart[1] > j + 1)
                                    leftLeg++;
                                else if (heart[1] < j + 1)
                                    rightLeg++;
                            }
                        }
                    }
                }
                else
                    continue;
            }

            WriteLine($"{heart[0]} {heart[1]}");
            WriteLine($"{leftArm} {rightArm} {waist} {leftLeg} {rightLeg}");
        }
	}
}
