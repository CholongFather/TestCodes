using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_15629
	{
		static Dictionary<string, int> dicNeedMoney = new Dictionary<string, int>()
		{
			["botswana"] = 0, //무비자
			["south-africa"] = 0, //무비자
			["kenya"] = 50, //1회 50 2회이상 100
			["ethiopia"] = 50, // 50
			["namibia"] = 140, //남아프리카에서 40 한국에서 140
			["tanzania"] = 50, //1회 50 2회이상 100 //킬리만자로 1일 70달러
			["zambia"] = 50, // 1회 50 2회 80
			["zimbabwe"] = 30, //1회입국 30 2회 45
		};
		static List<string> travelCountry = new List<string>();

		static void Main_15629()
		{
			int num = int.Parse(ReadLine());
			bool namivisa = false;
			bool unionvisa = false;

			for (int i = 0; i < num; i++)
			{
				string Key = ReadLine();
				travelCountry.Add(Key);

				if (Key == "south-africa" && !travelCountry.Contains("namibia"))
				{
					namivisa = true;
				}

			}

			//case 1 : 잠비아 - 짐바브웨 연합 비자.
			if (travelCountry.Contains("zambia") && travelCountry.Contains("zimbabwe"))
			{
				var index = travelCountry.FindIndex(c => c == "zambia");
				if (index != 0 && travelCountry[index - 1] == "zimbabwe")
					unionvisa = true;
				else if (index != 7 && travelCountry[index + 1] == "zimbabwe")
					unionvisa = true;

				if (unionvisa)
				{
					dicNeedMoney["zambia"] = 25;
					dicNeedMoney["zimbabwe"] = 25;
				}
			}

			//case 2 : 남아프리카에서 나미비아 비자 발급
			if (namivisa && travelCountry.Contains("namibia"))
			{
				dicNeedMoney["namibia"] = 40;
			}

			var resultMoney = 0;

			foreach (var country in travelCountry)
			{
				resultMoney += dicNeedMoney[country];
			}

			WriteLine(resultMoney);
		}
	}
}
