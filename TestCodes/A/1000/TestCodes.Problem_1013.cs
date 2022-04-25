using static System.Console;
using System.Text.RegularExpressions;

namespace TestCodes
{
	class Problem_1013
	{
		static void Main_1013()
		{
			var l = int.Parse(ReadLine());
			var r1 = new Regex($"^{ReadLine()}");

			for (var i = 0; i < l; i++)
			{
				if (r1.IsMatch(ReadLine())) WriteLine("YES");
				else WriteLine("NO");
			}
		}
	}
}
