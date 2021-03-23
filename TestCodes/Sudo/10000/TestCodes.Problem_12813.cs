using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_12813
	{
		static void Main_12813()
		{
            var a = ReadLine();
            var b = ReadLine();

            var and = new StringBuilder();
            var or = new StringBuilder();
            var xor = new StringBuilder();
            var nota = new StringBuilder();
            var notb = new StringBuilder();

            for (var i = 0; i < a.Length; i++)
            {
                and.Append(a[i].Equals('1') && b[i].Equals('1') ? "1" : "0");
                or.Append(a[i].Equals('1') || b[i].Equals('1') ? "1" : "0");
                xor.Append(a[i] == b[i] ? "0" : "1");
                nota.Append(a[i].Equals('0') ? "1" : "0");
                notb.Append(b[i].Equals('0') ? "1" : "0");
            }

            WriteLine(and.ToString());
            WriteLine(or.ToString());
            WriteLine(xor.ToString());
            WriteLine(nota.ToString());
            WriteLine(notb.ToString());

        }
    }
}
