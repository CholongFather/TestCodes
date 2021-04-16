using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace TestCodes
{
	class Problem_2742
	{
		static void Main_2742()
		{
			var sw = new StreamWriter(OpenStandardOutput());
			var sb = new StringBuilder();
			var num = int.Parse(ReadLine());

			for (var i = num; i > 0; i--)
				sb.AppendLine(i.ToString());

			sw.WriteLine(sb.ToString());
			sw.Flush();
			sw.Close();
		}
	}
}
