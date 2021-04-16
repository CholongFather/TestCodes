using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_10172
	{
		static void Main_10172()
		{
			StringBuilder returnStr = new StringBuilder();

			returnStr.AppendLine("|\\_/|");
			returnStr.AppendLine("|q p|   /}");
			returnStr.AppendLine("( 0 )\"\"\"\\");
			returnStr.AppendLine("|\"^\"`    |");
			returnStr.AppendLine("||_/=\\\\__|");

			WriteLine(returnStr.ToString());
		}
	}
}
