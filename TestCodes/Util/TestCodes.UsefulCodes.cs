using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;
using System.Diagnostics;

namespace TestCodes
{
	class Util
	{
		public static int GetI() => int.Parse(ReadLine());
		public static long GetL() => long.Parse(ReadLine());

		public static int[] GetIArray() => ReadLine().Trim().Split().Select(int.Parse).ToArray();
		public static long[] GetLArray() => ReadLine().Trim().Split().Select(long.Parse).ToArray();

		static void UtilMain()
		{
			// 0 5 0 한줄받기
			var numbers = ReadLine().Split(' ').Select(double.Parse).ToList();

			// 속도 느릴때.
			var sr = new StreamReader(OpenStandardInput());
			var sw = new StreamWriter(OpenStandardOutput()) { AutoFlush = true };
			var sb = new StringBuilder();

			//Main 계속 실행
			//if (Debugger.IsAttached)
			//	Main();



			var data = string.Empty;
			while ((data = ReadLine()) != "#")
			{

			}
		}
	}
}
