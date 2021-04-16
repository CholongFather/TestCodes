using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10989
	{
		static void Main_10989()
		{
			var sr = new StreamReader(OpenStandardInput());
			var sw = new StreamWriter(OpenStandardOutput());
			var arr = new int[10001];
			var testCase = int.Parse(sr.ReadLine());

			for (var i = 0; i < testCase; i++)
			{
				var num = int.Parse(sr.ReadLine());
				arr[num]++;
			}

			for (var i = 0; i < arr.Length; i++)
				for (var j = 0; j < arr[i]; j++)
					sw.WriteLine(i);

			sw.Flush();
			sr.Close();
			sw.Close();
		}
	}
}
