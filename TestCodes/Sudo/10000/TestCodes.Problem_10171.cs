using System;
using System.Linq;
using System.Text;
using static System.Console;

namespace TestCodes
{
	class Problem_10171
	{
		static void Main_10171()
		{
			StringBuilder returnStr = new StringBuilder();

			returnStr.AppendLine("\\    /\\");
			returnStr.AppendLine(" )  ( ')");
			returnStr.AppendLine("(  /  )");
			returnStr.AppendLine(" \\(__)|");

			WriteLine(returnStr.ToString());
		}
	}
}
