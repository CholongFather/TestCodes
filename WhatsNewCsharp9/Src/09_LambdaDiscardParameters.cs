//성능 및 상호 운용성
using System;
using System.Runtime.CompilerServices;

namespace TestCodes.CSharp9
{
	public partial class Csharp9
	{
		static void LambdaDiscardParameters()
		{
			//람다와 익명 함수 정의시 사용하지않는 인자 1개까지만 생략구문을 제공했지만
			//이제는 2개 이상 사용하는 것이 가능해짐
			//C#에서는 _을 discard로 사용중
			Func<int, int, int> func2 = (_, _) => 1;
			Func<int, int, int, int> func3 = (_, _, _) => 1;
			Func<int, int, int, int> func4 = (int _, int _, int _) => 1;
			Func<int, int, int, int> func5 = delegate (int _, int _, int _) { return 1; };

			var a = func2(1, 2);


			Func<int, int> oldfunc1 = (_) => 1;
			Func<int, int, int> oldfunc2 = (arg, _) => arg;
			Func<int, int, int, int> oldfunc3 = (_, arg1, arg2) => arg1;
			Func<int, int, int, int> oldfunc4 = (arg1, arg2, _) => arg1;
			Func<int, int, int, int> oldfunc5 = (arg1, _, arg2_) => arg1;

			var b = oldfunc5(1, 2, 3);
		}
	}
}