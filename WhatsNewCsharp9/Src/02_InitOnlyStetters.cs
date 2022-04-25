//초기화 전용 설정자 Init
namespace WhatsNewCsharp9
{
	public partial class Csharp9
	{
		static void InitOnlySetterMain()
		{
			var initSetter = new InitOnlySetter
			{
				Name = "name",
				Description = "desc",
			};

			//밑은 초기화 전용 한정자라 Set이 없어 Error
			//initSetter.Name = "notset";
			//initSetter.Description = "notset";
		}
	}

	public class InitOnlySetter
	{
		public string Name { get; init; }

		public string Description { get; init; }
	}
}
