//성능 및 상호 운용성
using System;
using System.Runtime.CompilerServices;

namespace TestCodes.CSharp9
{
	public partial class Csharp9
	{
		//unsafe한 컨텍스트에서만 유효함 (Localsinit 플래그 내보내기 무시)
		[SkipLocalsInit]
		static void PerformanceAndInteropMain()
		{
			//1. native-sized integers (원시 크기 정수
			//플랫폼 의존적인 타입을 갖는 네이티브 모듈과 연동하기 위해서 IntPtr / UintPtr을 사용해야 되었지만 해당 타입이 대체함
			nint a = 0; //32bit 환경에서는 4byte, 64bit 환경에서는 8byte로 정의됨
			nuint b = 0;

			//---------------------------------------------------------------------------------------
			//2. SkipLocalInit 속성에 의한 unsafe context 내에서 실행하는 함수
			//그러나 출력 결과를 예상 할 수 없고 스레드 스택에 남아있는 값을 그대로 이용하게됨
			unsafe
			{
				int i;
				int j;

				int* pi = &i;
				int* pj = &j;

				Console.WriteLine(*pi);
				Console.WriteLine(*pj);

				//0초기화 됨
				int[] arrs = new int[100];
				//해당 값은 int 배열의 요소가 0임을 보장 할 수가 없다. (코드에서 arr 초기화를 강제시킬 수 있다...)
				Span<int> arr = stackalloc int[100];
			}

			//---------------------------------------------------------------------------------------
			//3. Local 함수 내에 Attribute 지정이 가능해짐
			//Local 함수 사용 이유. 메소드 밖에서는 다시 쓸일 없는 반복적인 작업을 하나의 이름으로 묶을 수 있음
			[SkipLocalsInit]
			static void DebugLog(string text)
			{

			}
		}
	}
}