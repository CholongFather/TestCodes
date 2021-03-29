using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_13717
	{
		static void Main_13717()
		{
			var input = int.Parse(ReadLine());
			var myPokemons = new List<MyPokemon>();

			for (int i = 0; i < input; i++)
			{
				var myPokemon = new MyPokemon();
				var (name, candys) = (ReadLine(), ReadLine().Split(' ').Select(double.Parse).ToList());

				myPokemon.Name = name;
				myPokemon.Evolution = 0;

				var e = candys[1];
				var n = candys[0];

				while (e >= 0)
				{
					var c = e - n + 2;

					if (c >= 0)
						myPokemon.Evolution++;

					e = c;
				}

				myPokemons.Add(myPokemon);
			}

			WriteLine(myPokemons.Sum(c => c.Evolution));
			var max = myPokemons.Max(c => c.Evolution);
			WriteLine(myPokemons.FirstOrDefault(c => c.Evolution == max).Name);
		}

		public class MyPokemon
		{
			public string Name { get; set; }
			public int Evolution { get; set; }
		}
	}
}
