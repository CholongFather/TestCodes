using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
    class Problem
    {
        static void Main()
        {
            var input = ReadLine();
            var sb = new StringBuilder();

            switch (input)
            {
                case "Marathon Edition 우승자":
                    sb.AppendLine("대상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("sait2000");
                    break;
                case "Marathon Edition 준우승자 및 ReguIar Edition 준우승자":
                    sb.AppendLine("대상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("zigui");
                    break;
                case "ReguIar Edition 우승자 및 Speedrun Edition 우승자":
                    sb.AppendLine("대상");
                    sb.AppendLine("(도서) Speedrun Science: A Long Guide To Short Playthroughs");
                    sb.AppendLine("xiaowuc1");
                    break;
                case "Speedrun Edition 준우승자":
                    sb.AppendLine("대상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("rubix");
                    break;
                case "이 대회에 참가하지 않은 사람 중 2019년 대회 최고 등수":
                    sb.AppendLine("결근상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("namnamseo");
                    break;
                case "모든 에디션에서 총점이 160억점에 가장 가까운 사람":
                    sb.AppendLine("QA 상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("	xiaowuc1");
                    break;
                case "홀수와 짝수의 대결 문제의 오류를 발견한 사람":
                    //FIX
                    sb.AppendLine("QA 상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("namnamseo");
                    break;
                case "4차 산업 혁명을 기계학습 없이 서브태스크 2까지만 푼 사람 중 추첨":
                    sb.AppendLine("직관주의자상");
                    sb.AppendLine("(도서) 4차 산업혁명은 없다");
                    sb.AppendLine("201812106");
                    break;
                case "배중률교를 정해가 아닌 방법으로 푼 사람 중 추첨":
                    sb.AppendLine("QA 상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("namnamseo");
                    break;
                case "Marathon Edition에서 Nonogram QR을 마지막으로 1점 이상 획득한 사람":
                    sb.AppendLine("QA 상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("namnamseo");
                    break;
                case "연속합 2147483647 첫 0점자":
                    sb.AppendLine("QA 상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("namnamseo");
                    break;
                case "Beginning the Hunt 첫 만점자":
                    sb.AppendLine("QA 상");
                    sb.AppendLine("치킨 기프티콘");
                    sb.AppendLine("namnamseo");
                    break;
                case "대회에 참여하였고 A+B (MC)에 제출하지 않은 사람 중 추첨":
                    sb.AppendLine("You Need a Minecraft 상");
                    sb.AppendLine("Minecraft");
                    sb.AppendLine("zigui");
                    break;
                default:
                    break;
            }
			WriteLine(sb);
        }
    }
}