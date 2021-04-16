using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_6763
	{
		static void Main_6763()
		{
            var (speedLimit, carSpeed) = (int.Parse(ReadLine()), int.Parse(ReadLine()));
            var rt = string.Empty;

            if (carSpeed <= speedLimit)
                rt = "Congratulations, you are within the speed limit!";
            else if (carSpeed > speedLimit)
            {
                if (carSpeed - speedLimit < 21)
                    rt = "You are speeding and your fine is $100.";
                else if ((carSpeed - speedLimit < 31))
                    rt = "You are speeding and your fine is $270.";
                else
                    rt = "You are speeding and your fine is $500.";
            }
            WriteLine(rt);
        }
	}
}
