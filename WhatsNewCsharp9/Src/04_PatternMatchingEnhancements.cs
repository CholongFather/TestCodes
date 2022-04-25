//패턴 일지 개선
namespace WhatsNewCsharp9
{
	public partial class Csharp9
	{
		static void PatternMatchingEnhancementsMain()
		{
			string test = null;

			if (test is not null)
			{
				//
			}
		}
	}

	public static class StaticTest
	{
		public static bool IsLetter(this char c) =>
			c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

		public static bool IsLetterOrSeparator(this char c) =>
			c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
	}
}

//새로생긴 유형들
//is
//and
//or
//not
