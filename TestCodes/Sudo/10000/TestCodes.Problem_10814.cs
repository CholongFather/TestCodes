using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.IO;

namespace TestCodes
{
	class Problem_10814
	{
		static void Main_10814()
		{
            var sb = new StringBuilder();
            var testCase = int.Parse(ReadLine());
            var list = new List<Person>();

            for (var i = 0; i < testCase; i++)
            {
                var data = ReadLine().Split(' ');
                var person = new Person()
                {
                    Age = int.Parse(data[0]),
                    Name = data[1],
                };

                list.Add(person);
            }

            foreach (var person in list.OrderBy(c => c.Age))
                sb.AppendLine($"{person.Age} {person.Name}");

            Write(sb.ToString());
        }

        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
    }
}
