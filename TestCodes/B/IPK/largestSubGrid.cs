using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result_la
{
    /*
     * Complete the 'largestSubgrid' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. 2D_INTEGER_ARRAY grid
     *  2. INTEGER maxSum
     */

    public static int largestSubgrid(List<List<int>> grid, int maxSum)
    {
        var gridSize = grid.Count();
        var arrMax = new int[gridSize + 1];

        for (var i = 1; i <= gridSize; i++)
        {
            for (var j = 0; j < gridSize - (i - 1); j++)
            {
                for (var k = 0; k < gridSize - (i - 1); k++)
                {
                    var sum = 0;

                    for (var n = j; n < j + i; n++)
                    {
                        for (var m = k; m < k + i; m++)
                        {
                            sum += grid[n][m];
                        }
                    }

                    if (sum > maxSum)
                        return i - 1;
                }
            }
        }

        return 0;
    }

    static void Main_la()
    {
        var grid = new int[3][];

        var gridSize = grid.Count();
        var arrMax = new long[gridSize + 1];
        var arrSums = new long[gridSize, gridSize];

        for (var i = 0; i < gridSize; i++)
        {
            for (var j = 0; j < gridSize; j++)
            {
                if (i == 0)
                {
                    if (j == 0)
                        arrSums[i, j] = grid[i][j];
                    else
                        arrSums[i, j] = arrSums[i, j - 1] + grid[i][j];
                }
                else
                {
                    if (j == 0)
                        arrSums[i, j] = arrSums[i - 1, j] + grid[i][j];
                    else
                        arrSums[i, j] = arrSums[i - 1, j] + arrSums[i, j - 1] - arrSums[i - 1, j - 1] + grid[i][j];
                }
            }
        }

        for (var i = gridSize; i >= 1; i++)
        {
            for (var j = 0; j < gridSize - (i - 1); j++)
            {
                for (var k = 0; k < gridSize - (i - 1); k++)
                {
                    long sum = 0;
                    if (k == 0 && j == 0)
                    {
                        sum = arrSums[j + i - 1, k + i - 1];
					}
                    else if (k - 1 < 0)
                    {
                        if (j - 1 >= 0)
                            sum = arrSums[j + i - 1, k + i - 1] - arrSums[j - 1, k + i - 1];
                        else
                            sum = arrSums[j + i - 1, k + i - 1];
                    }
                    else if (k - 1 >= 0)
                    {
                        if (j - 1 >= 0)
                            sum = arrSums[j + i - 1, k + i - 1] - arrSums[j - 1, k + i - 1] - arrSums[j + i - 1, k - 1] + arrSums[j - 1, k - 1];
                        else
                            sum = arrSums[j + i - 1, k + i - 1] - arrSums[j + i - 1, k - 1];
                    }

					Console.WriteLine(sum);
                }
            }
        }

    }
}