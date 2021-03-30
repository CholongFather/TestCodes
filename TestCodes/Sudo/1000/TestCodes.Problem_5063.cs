﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_5063
	{
		static void Main_5063()
		{
			var testCase = int.Parse(ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var data = ReadLine().Split(' ').Select(int.Parse).ToList();

				if (data[0] < data[1] - data[2])
					WriteLine("advertise");
				else if (data[0] == data[1] - data[2])
					WriteLine("does not matter");
				else
					WriteLine("do not advertise");
			}
		}
	}
}
