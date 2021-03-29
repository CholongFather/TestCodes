using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Util
	{
		static void UtilMain()
		{
			//Read 한줄
			var testCase = int.Parse(ReadLine());

			// 0 5 0 한줄받기
			var numbers = ReadLine().Split(' ').Select(double.Parse).ToList();

			// 속도 느릴때.
			var sr = new StreamReader(OpenStandardInput());
			var sw = new StreamWriter(OpenStandardOutput());
		}
	}
}
