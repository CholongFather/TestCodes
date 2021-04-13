using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem
	{
		static void Main()
		{
			var sr = new StreamReader(OpenStandardInput());

			var data = sr.ReadLine().Split().Select(int.Parse).ToArray();

			var arr = new long[data[0]];

			for (var i = 0; i < arr.Length; i++)
			{
				arr[i] = long.Parse(sr.ReadLine());
			}

			var a = 0;
			while (true)
			{
				var c = arr.Sum() / (data[1] + a);

				long result = 0;
				for (var j = 0; j < arr.Length; j++)
					result += arr[j] / c;

				if (result >= data[1])
					break;

				a++;
			}

			var d = arr.Sum() / (data[1] + a - 1);
			for (var i = d; i > 0; i--)
			{
				long result = 0;
				for (var j = 0; j < arr.Length; j++)
					result += arr[j] / i;

				if (result >= data[1])
				{
					WriteLine(i);
					break;
				}
			}


			if (Debugger.IsAttached)
				Main();
		}
	}
}