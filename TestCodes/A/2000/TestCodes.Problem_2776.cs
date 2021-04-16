using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2776
	{
		static void Main_2776()
		{
			
			var sr = new StreamReader(OpenStandardInput());
			var sw = new StreamWriter(OpenStandardOutput());
			var testCase = int.Parse(sr.ReadLine());
			sw.AutoFlush = true;

			for (var i = 0; i < testCase; i++)
			{
				var sb = new StringBuilder();
				var dic = new Dictionary<string, bool>();

				sr.ReadLine();
				foreach (var item in sr.ReadLine().Split(' '))
				{
					if (!dic.ContainsKey(item))
						dic.Add(item, true);
				}

				sr.ReadLine();
				foreach (var item in sr.ReadLine().Split(' '))
				{
					if (dic.ContainsKey(item))
						sb.AppendLine("1");
					else
						sb.AppendLine("0");
				}

				sw.Write(sb.ToString());
			}
		}
	}
}
