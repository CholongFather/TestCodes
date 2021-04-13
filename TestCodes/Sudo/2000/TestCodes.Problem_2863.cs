using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_2863
	{
		static void Main_2863()
		{
			double max = 0;
			var maxRotate = 0;
			var a = ReadLine().Split(' ').Select(double.Parse).ToArray();
			var b = ReadLine().Split(' ').Select(double.Parse).ToArray();
			var arr = new double[2, 2] { { a[0], a[1] }, { b[0], b[1] } };

			for (var i = 0; i < 4; i++)
			{
				var result = arr[0, 0] / arr[1, 0] + arr[0, 1] / arr[1, 1];

				if (max < result)
				{
					maxRotate = i;
					max = result;
				}

				var arrRotation = new double[2, 2] { { arr[1, 0], arr[0, 0] }, { arr[1, 1], arr[0, 1] } };
				arr = arrRotation;
			}

			WriteLine(maxRotate);


		}
	}
}
