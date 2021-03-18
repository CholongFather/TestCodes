using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace TestCodes
{
	class Problem
	{
		static void Main()
		{
		}
	}
}

//static void Main()
//{
//	List<int> aa = new List<int>();
//	var num = int.Parse(ReadLine());

//	for (var i = 2; i < num; i++)
//	{
//		while (num % i == 0)
//		{
//			num = num / i;
//			aa.Add(i);
//		}
//	}

//	if (aa.Count() == 0)
//	{
//		WriteLine(0);
//		return;
//	}
//	var a = 0;
//	var j = 1;
//	while (true)
//	{
//		j *= 2;
//		a++;
//		if (aa.Count() <= j)
//		{
//			WriteLine(a);
//			break;
//		}
//	}
//}


///WTF 뒤집기
//var sequenceList = new List<string>();
//var (input, sequence) = (int.Parse(ReadLine()), ReadLine().Split(' ').ToList());

//for (int i = 1; i < input; i++)
//{
//	var sb = new StringBuilder();
//	sequence = sequence.Skip(1).Concat(sequence.Take(1)).ToList();

//	foreach (var cs in sequence)
//		sb.Append(cs).Append(' ');

//	sequenceList.Add(sb.ToString().TrimEnd(' '));
//	sequenceList = sequenceList.OrderBy(c => c).Take(1).ToList();
//}

//var item = sequenceList.FirstOrDefault();
//WriteLine(item);