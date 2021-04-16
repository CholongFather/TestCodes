using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_3053
	{
		static void Main_3053()
		{
			var r = int.Parse(ReadLine());

			var circle = r * r * Math.PI;
			var taxiCircle = r * r * 2;

			WriteLine(string.Format("{0:0.000000}", circle));
			WriteLine(string.Format("{0:0.000000}", taxiCircle));
		}
	}
}
