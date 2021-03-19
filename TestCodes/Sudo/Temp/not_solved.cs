using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodes.Sudo.Temp
{
	class not_solved
	{
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


//var testCase = int.Parse(ReadLine());

//for (var i = 0; i < testCase; i++)
//{
//	var list = new List<int[]>();
//	var persons = int.Parse(ReadLine());

//	for (var j = 0; j < persons; j++)
//	{
//		list.Add(ReadLine().Split(' ').Select(Int32.Parse).ToArray());
//	}

//	list = list.OrderBy(c => c[0]).ToList();

//	foreach (var item in list)
//	{
//		list = list.Except(list.Where(c => c[0] > item[0] && c[1] > item[1])).ToList();
//	}

//	WriteLine(list.Count);
//}