//성능 및 상호 운용성
using System.Runtime.CompilerServices;

namespace TestCodes.CSharp9
{
	public partial class Csharp9
	{
		//static이어야 함
		//argument가 없어야 함
		//void를 반환해야됨
		//제네릭이 아니거나 제네릭 형식에 포함되서는 안됨
		//포함하는 모듈에서 엑세스할수 있어야함 internal / public 만 가능
		[ModuleInitializer]
		internal static void Test1()
		{
			//해당 모듈이 호출될때 Initalizer를 우선 호출
		}

		static void SupportForCodeGeneratorsMain()
		{
		}
	}
}