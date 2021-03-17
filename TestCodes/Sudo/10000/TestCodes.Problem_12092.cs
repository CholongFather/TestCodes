using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace TestCodes
{
	class Problem_12092
	{
		static List<int> PokemonCandy = new List<int>()
		{
			25,100,-1,25,100,-1,25,100,-1,12,50,-1,12,50,-1,12,50,-1,25,-1,50,-1,50,-1,50,-1,50,-1,25,100,-1,25,100,-1,50,-1,50,-1,50,-1,50,-1,25,100,-1,50,-1,50,-1,50,-1,50,-1,50,-1,50,-1,50,-1,25,100,-1,25,100,-1,25,100,-1,25,100,-1,50,-1,25,100,-1,50,-1,50,-1,50,-1,-1,50,-1,50,-1,50,-1,50,-1,25,100,-1,-1,50,-1,50,-1,50,-1,50,-1,50,-1,-1,-1,-1,50,-1,50,-1,-1,-1,-1,50,-1,50,-1,50,-1,-1,-1,-1,-1,-1,-1,-1,400,-1,-1,-1,25,-1,-1,-1,-1,50,-1,50,-1,-1,-1,-1,-1,-1,25,100,-1,-1,-1,
		};
		static void Main_12092()
		{
			int num = int.Parse(ReadLine());

			var pokemonCandy = PokemonCandy[num - 1];
			WriteLine(pokemonCandy);
		}
	}
}
