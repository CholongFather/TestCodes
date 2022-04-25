using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//레코드 타입 

namespace WhatsNewCsharp9
{
	public partial class Csharp9
	{
		static void RecordTypeMain()
		{
			var recodeType = new RecordType("name", "desc");

			//밑의 주석은 레코드 타입에서 해당 Type이 없기때문에 에러납니다
			//recodeType.Name = "notset";
			//recodeType.Description = "notset";

			//역의 참조는 가능합니다.
			var recordTypeName = recodeType.Name;
			var recordTypeDescription = recodeType.Description;

			//비 파괴적 변경의 예시 with
			var recordType2 = recodeType with { Name = "name2" };
			var recordType3 = recodeType with { };
		}
	}

	record RecordType(string Name, string Description);

	//Record Type 상속 예시
	public abstract record Person(string FirstName, string LastName);
	public record Teacher(string FirstName, string LastName, int Grade)
		:Person(FirstName, LastName);
	public record Student(string FirstName, string LastName, int Grade)
		:Person(FirstName, LastName);

	//레코드 형식은 변경 불가능한 것은 아니지만 사용하기에 따라 불변성을 가질수 있음.
	//readonly가 아닌 set 접근자 및 필드를 사용하여 속성을 선언할 수 있습니다.
	//그러나 레코드는 변경할 수 있지만 이를 통해 변경할 수 없는 데이터 모델을 쉽게 만들 수 있습니다. 위치 구문을 사용하여 만든 속성은 변경할 수 없습니다.
	//불변성은 데이터 중심 형식이 스레드로부터 안전해야 하는 경우 또는 해시 코드가 해시 테이블에서 동일하게 남아 있어야 하는 경우에 유용할 수 있습니다.
	//불변성은 메서드에 대한 참조로 인수를 전달할 때, 그리고 메서드가 예기치 않게 인수 값을 변경할 때 발생하는 버그를 방지할 수 있습니다.
	//레코드 형식에 고유한 기능이 컴파일러 합성 메서드로 구현되고, 이러한 메서드는 개체 상태를 수정하여 불변성을 손상하지 않습니다.
}