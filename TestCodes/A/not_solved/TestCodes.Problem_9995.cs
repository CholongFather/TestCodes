using System.Collections.Generic;
using System.Net;
using System.Linq;
using static System.Console;

namespace TestCodes
{
	class Problem_9995
	{
		public class Pokemon
		{
			public int Index { get; set; }
			public string Name { get; set; }
			public string Type { get; set; }
		}

		public static IEnumerable<Pokemon> pokemons => new List<Pokemon>
		{
			new Pokemon { Index = 001, Name = "Bulbasaur", Type = "Grass Poison" },
			new Pokemon { Index = 002, Name = "Ivysaur", Type = "Grass Poison" },
			new Pokemon { Index = 003, Name = "Venusaur", Type = "Grass Poison" },
			new Pokemon { Index = 004, Name = "Charmander", Type = "Fire" },
			new Pokemon { Index = 005, Name = "Charmeleon", Type = "Fire" },
			new Pokemon { Index = 006, Name = "Charizard", Type = "Fire Flying" },
			new Pokemon { Index = 007, Name = "Squirtle", Type = "Water" },
			new Pokemon { Index = 008, Name = "Wartortle", Type = "Water" },
			new Pokemon { Index = 009, Name = "Blastoise", Type = "Water" },
			new Pokemon { Index = 010, Name = "Caterpie", Type = "Bug" },
			new Pokemon { Index = 011, Name = "Metapod", Type = "Bug" },
			new Pokemon { Index = 012, Name = "Butterfree", Type = "Bug Flying" },
			new Pokemon { Index = 013, Name = "Weedle", Type = "Bug Poison" },
			new Pokemon { Index = 014, Name = "Kakuna", Type = "Bug Poison" },
			new Pokemon { Index = 015, Name = "Beedrill", Type = "Bug Poison" },
			new Pokemon { Index = 016, Name = "Pidgey", Type = "Normal Flying" },
			new Pokemon { Index = 017, Name = "Pidgeotto", Type = "Normal Flying" },
			new Pokemon { Index = 018, Name = "Pidgeot", Type = "Normal Flying" },
			new Pokemon { Index = 019, Name = "Rattata", Type = "Normal" },
			new Pokemon { Index = 020, Name = "Raticate", Type = "Normal" },
			new Pokemon { Index = 021, Name = "Spearow", Type = "Normal Flying" },
			new Pokemon { Index = 022, Name = "Fearow", Type = "Normal Flying" },
			new Pokemon { Index = 023, Name = "Ekans", Type = "Poison" },
			new Pokemon { Index = 024, Name = "Arbok", Type = "Poison" },
			new Pokemon { Index = 025, Name = "Pikachu", Type = "Electric" },
			new Pokemon { Index = 026, Name = "Raichu", Type = "Electric" },
			new Pokemon { Index = 027, Name = "Sandshrew", Type = "Ground" },
			new Pokemon { Index = 028, Name = "Sandslash", Type = "Ground" },
			new Pokemon { Index = 029, Name = "Nidoran-f", Type = "Poison" },
			new Pokemon { Index = 030, Name = "Nidorina", Type = "Poison" },
			new Pokemon { Index = 031, Name = "Nidoqueen", Type = "Poison Ground" },
			new Pokemon { Index = 032, Name = "nidoran-m", Type = "Poison" },
			new Pokemon { Index = 033, Name = "Nidorino", Type = "Poison" },
			new Pokemon { Index = 034, Name = "Nidoking", Type = "Poison Ground" },
			new Pokemon { Index = 035, Name = "Clefairy", Type = "Fairy" },
			new Pokemon { Index = 036, Name = "Clefable", Type = "Fairy" },
			new Pokemon { Index = 037, Name = "Vulpix", Type = "Fire" },
			new Pokemon { Index = 038, Name = "Ninetales", Type = "Fire" },
			new Pokemon { Index = 039, Name = "Jigglypuff", Type = "Normal Fairy" },
			new Pokemon { Index = 040, Name = "Wigglytuff", Type = "Normal Fairy" },
			new Pokemon { Index = 041, Name = "Zubat", Type = "Poison Flying" },
			new Pokemon { Index = 042, Name = "Golbat", Type = "Poison Flying" },
			new Pokemon { Index = 043, Name = "Oddish", Type = "Grass Poison" },
			new Pokemon { Index = 044, Name = "Gloom", Type = "Grass Poison" },
			new Pokemon { Index = 045, Name = "Vileplume", Type = "Grass Poison" },
			new Pokemon { Index = 046, Name = "Paras", Type = "Bug Grass" },
			new Pokemon { Index = 047, Name = "Parasect", Type = "Bug Grass" },
			new Pokemon { Index = 048, Name = "Venonat", Type = "Bug Poison" },
			new Pokemon { Index = 049, Name = "Venomoth", Type = "Bug Poison" },
			new Pokemon { Index = 050, Name = "Diglett", Type = "Ground" },
			new Pokemon { Index = 051, Name = "Dugtrio", Type = "Ground" },
			new Pokemon { Index = 052, Name = "Meowth", Type = "Normal" },
			new Pokemon { Index = 053, Name = "Persian", Type = "Normal" },
			new Pokemon { Index = 054, Name = "Psyduck", Type = "Water" },
			new Pokemon { Index = 055, Name = "Golduck", Type = "Water" },
			new Pokemon { Index = 056, Name = "Mankey", Type = "Fighting" },
			new Pokemon { Index = 057, Name = "Primeape", Type = "Fighting" },
			new Pokemon { Index = 058, Name = "Growlithe", Type = "Fire" },
			new Pokemon { Index = 059, Name = "Arcanine", Type = "Fire" },
			new Pokemon { Index = 060, Name = "Poliwag", Type = "Water" },
			new Pokemon { Index = 061, Name = "Poliwhirl", Type = "Water" },
			new Pokemon { Index = 062, Name = "Poliwrath", Type = "Water Fighting" },
			new Pokemon { Index = 063, Name = "Abra", Type = "Psychic" },
			new Pokemon { Index = 064, Name = "Kadabra", Type = "Psychic" },
			new Pokemon { Index = 065, Name = "Alakazam", Type = "Psychic" },
			new Pokemon { Index = 066, Name = "Machop", Type = "Fighting" },
			new Pokemon { Index = 067, Name = "Machoke", Type = "Fighting" },
			new Pokemon { Index = 068, Name = "Machamp", Type = "Fighting" },
			new Pokemon { Index = 069, Name = "Bellsprout", Type = "Grass Poison" },
			new Pokemon { Index = 070, Name = "Weepinbell", Type = "Grass Poison" },
			new Pokemon { Index = 071, Name = "Victreebel", Type = "Grass Poison" },
			new Pokemon { Index = 072, Name = "Tentacool", Type = "Water Poison" },
			new Pokemon { Index = 073, Name = "Tentacruel", Type = "Water Poison" },
			new Pokemon { Index = 074, Name = "Geodude", Type = "Rock Ground" },
			new Pokemon { Index = 075, Name = "Graveler", Type = "Rock Ground" },
			new Pokemon { Index = 076, Name = "Golem", Type = "Rock Ground" },
			new Pokemon { Index = 077, Name = "Ponyta", Type = "Fire" },
			new Pokemon { Index = 078, Name = "Rapidash", Type = "Fire" },
			new Pokemon { Index = 079, Name = "Slowpoke", Type = "Water Psychic" },
			new Pokemon { Index = 080, Name = "Slowbro", Type = "Water Psychic" },
			new Pokemon { Index = 081, Name = "Magnemite", Type = "Electric Steel" },
			new Pokemon { Index = 082, Name = "Magneton", Type = "Electric Steel" },
			new Pokemon { Index = 083, Name = "farfetchd", Type = "Normal Flying" },
			new Pokemon { Index = 084, Name = "Doduo", Type = "Normal Flying" },
			new Pokemon { Index = 085, Name = "Dodrio", Type = "Normal Flying" },
			new Pokemon { Index = 086, Name = "Seel", Type = "Water" },
			new Pokemon { Index = 087, Name = "Dewgong", Type = "Water Ice" },
			new Pokemon { Index = 088, Name = "Grimer", Type = "Poison" },
			new Pokemon { Index = 089, Name = "Muk", Type = "Poison" },
			new Pokemon { Index = 090, Name = "Shellder", Type = "Water" },
			new Pokemon { Index = 091, Name = "Cloyster", Type = "Water Ice" },
			new Pokemon { Index = 092, Name = "Gastly", Type = "Ghost Poison" },
			new Pokemon { Index = 093, Name = "Haunter", Type = "Ghost Poison" },
			new Pokemon { Index = 094, Name = "Gengar", Type = "Ghost Poison" },
			new Pokemon { Index = 095, Name = "Onix", Type = "Rock Ground" },
			new Pokemon { Index = 096, Name = "Drowzee", Type = "Psychic" },
			new Pokemon { Index = 097, Name = "Hypno", Type = "Psychic" },
			new Pokemon { Index = 098, Name = "Krabby", Type = "Water" },
			new Pokemon { Index = 099, Name = "Kingler", Type = "Water" },
			new Pokemon { Index = 100, Name = "Voltorb", Type = "Electric" },
			new Pokemon { Index = 101, Name = "Electrode", Type = "Electric" },
			new Pokemon { Index = 102, Name = "Exeggcute", Type = "Grass Psychic" },
			new Pokemon { Index = 103, Name = "Exeggutor", Type = "Grass Psychic" },
			new Pokemon { Index = 104, Name = "Cubone", Type = "Ground" },
			new Pokemon { Index = 105, Name = "Marowak", Type = "Ground" },
			new Pokemon { Index = 106, Name = "Hitmonlee", Type = "Fighting" },
			new Pokemon { Index = 107, Name = "Hitmonchan", Type = "Fighting" },
			new Pokemon { Index = 108, Name = "Lickitung", Type = "Normal" },
			new Pokemon { Index = 109, Name = "Koffing", Type = "Poison" },
			new Pokemon { Index = 110, Name = "Weezing", Type = "Poison" },
			new Pokemon { Index = 111, Name = "Rhyhorn", Type = "Ground Rock" },
			new Pokemon { Index = 112, Name = "Rhydon", Type = "Ground Rock" },
			new Pokemon { Index = 113, Name = "Chansey", Type = "Normal" },
			new Pokemon { Index = 114, Name = "Tangela", Type = "Grass" },
			new Pokemon { Index = 115, Name = "Kangaskhan", Type = "Normal" },
			new Pokemon { Index = 116, Name = "Horsea", Type = "Water" },
			new Pokemon { Index = 117, Name = "Seadra", Type = "Water" },
			new Pokemon { Index = 118, Name = "Goldeen", Type = "Water" },
			new Pokemon { Index = 119, Name = "Seaking", Type = "Water" },
			new Pokemon { Index = 120, Name = "Staryu", Type = "Water" },
			new Pokemon { Index = 121, Name = "Starmie", Type = "Water Psychic" },
			new Pokemon { Index = 122, Name = "mr-mime", Type = "Psychic Fairy" },
			new Pokemon { Index = 123, Name = "Scyther", Type = "Bug Flying" },
			new Pokemon { Index = 124, Name = "Jynx", Type = "Ice Psychic" },
			new Pokemon { Index = 125, Name = "Electabuzz", Type = "Electric" },
			new Pokemon { Index = 126, Name = "Magmar", Type = "Fire" },
			new Pokemon { Index = 127, Name = "Pinsir", Type = "Bug" },
			new Pokemon { Index = 128, Name = "Tauros", Type = "Normal" },
			new Pokemon { Index = 129, Name = "Magikarp", Type = "Water" },
			new Pokemon { Index = 130, Name = "Gyarados", Type = "Water Flying" },
			new Pokemon { Index = 131, Name = "Lapras", Type = "Water Ice" },
			new Pokemon { Index = 132, Name = "Ditto", Type = "Normal" },
			new Pokemon { Index = 133, Name = "Eevee", Type = "Normal" },
			new Pokemon { Index = 134, Name = "Vaporeon", Type = "Water" },
			new Pokemon { Index = 135, Name = "Jolteon", Type = "Electric" },
			new Pokemon { Index = 136, Name = "Flareon", Type = "Fire" },
			new Pokemon { Index = 137, Name = "Porygon", Type = "Normal" },
			new Pokemon { Index = 138, Name = "Omanyte", Type = "Rock Water" },
			new Pokemon { Index = 139, Name = "Omastar", Type = "Rock Water" },
			new Pokemon { Index = 140, Name = "Kabuto", Type = "Rock Water" },
			new Pokemon { Index = 141, Name = "Kabutops", Type = "Rock Water" },
			new Pokemon { Index = 142, Name = "Aerodactyl", Type = "Rock Flying" },
			new Pokemon { Index = 143, Name = "Snorlax", Type = "Normal" },
			new Pokemon { Index = 144, Name = "Articuno", Type = "Ice Flying" },
			new Pokemon { Index = 145, Name = "Zapdos", Type = "Electric Flying" },
			new Pokemon { Index = 146, Name = "Moltres", Type = "Fire Flying" },
			new Pokemon { Index = 147, Name = "Dratini", Type = "Dragon" },
			new Pokemon { Index = 148, Name = "Dragonair", Type = "Dragon" },
			new Pokemon { Index = 149, Name = "Dragonite", Type = "Dragon Flying" },
			new Pokemon { Index = 150, Name = "Mewtwo", Type = "Psychic" },
			new Pokemon { Index = 151, Name = "Mew", Type = "Psychic" },
		};

		static void Main_9995()
		{
			var wc = new WebClient();
			var dic = new Dictionary<string, List<int>>();
			var machine = new HashSet<string>();
			machine.Add("HM01");
			machine.Add("HM02");
			machine.Add("HM03");
			machine.Add("HM04");
			machine.Add("HM05");
			machine.Add("HM06");
			machine.Add("HM07");
			machine.Add("HM08");
			machine.Add("TM01");
			machine.Add("TM02");
			machine.Add("TM03");
			machine.Add("TM04");
			machine.Add("TM05");
			machine.Add("TM06");
			machine.Add("TM07");
			machine.Add("TM08");
			machine.Add("TM09");
			machine.Add("TM10");
			machine.Add("TM11");
			machine.Add("TM12");
			machine.Add("TM13");
			machine.Add("TM14");
			machine.Add("TM15");
			machine.Add("TM16");
			machine.Add("TM17");
			machine.Add("TM18");
			machine.Add("TM19");
			machine.Add("TM20");
			machine.Add("TM21");
			machine.Add("TM22");
			machine.Add("TM23");
			machine.Add("TM24");
			machine.Add("TM25");
			machine.Add("TM26");
			machine.Add("TM27");
			machine.Add("TM28");
			machine.Add("TM29");
			machine.Add("TM30");
			machine.Add("TM31");
			machine.Add("TM32");
			machine.Add("TM33");
			machine.Add("TM34");
			machine.Add("TM35");
			machine.Add("TM36");
			machine.Add("TM37");
			machine.Add("TM38");
			machine.Add("TM39");
			machine.Add("TM40");
			machine.Add("TM41");
			machine.Add("TM42");
			machine.Add("TM43");
			machine.Add("TM44");
			machine.Add("TM45");
			machine.Add("TM46");
			machine.Add("TM47");
			machine.Add("TM48");
			machine.Add("TM49");
			machine.Add("TM50");


			foreach (var item in pokemons)
			{
				var ss = wc.DownloadString($"http://pokemondb.net/pokedex/{item.Name}/moves/3#tab-moves-6");

				foreach (var mac in machine)
				{
					if (ss.Contains($"title=\"{mac}\""))
					{
						if (!dic.ContainsKey(mac))
							dic.Add(mac, new List<int>() { item.Index });
						else
							dic[mac].Add(item.Index);
					}
				}
			}

			foreach (var kv in dic.OrderBy(c => c.Key))
			{
				Write(kv.Key + ", {");
				foreach (var v in kv.Value)
				{
					Write("\"" + v + "\",");
				}
				Write("}");
				WriteLine();
			}
		}
	}
}