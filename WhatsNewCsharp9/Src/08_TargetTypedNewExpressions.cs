//성능 및 상호 운용성
using System.Runtime.CompilerServices;

namespace TestCodes.CSharp9
{
	public partial class Csharp9
	{
		static void TargetTypedNewExpressions()
		{
			//이제는 Target을 지정하지 않고 new라는 구문으로 앞의 타겟을 선언이 가능해짐
			Point p = new(5, 6);

			//그러나 배열 선언에는 생략이 불가능함.
			//Point[] arr1 = new[5] { };
		}
	}

	struct Point
	{
		int _x;
		public int X { get { return _x; } }

		int _y;
		public int Y { get { return _y; } }

		public Point(int x, int y)
		{
			_x = x;
			_y = y;
		}
	}
}