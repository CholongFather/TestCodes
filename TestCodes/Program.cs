﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
    class Problem
    {
        static void Main()
        {
            var numbers = ReadLine().Split(' ').Select(int.Parse).ToList();
        }
    }
}