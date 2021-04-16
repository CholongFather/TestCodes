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

class Solution_4
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        var x = s.Length;
        var aCount = s.Where(c => c == 'a').Count();

        var div = n / x;
        var rem = n % x;

        var remCount = 0;
        for (var i = 0; i < rem; i++)
        {
            if (s[i] == 'a')
                remCount++;
        }

        return aCount * div + remCount;
    }

    static void Main_4(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
