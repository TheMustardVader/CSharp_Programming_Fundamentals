using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        class Evolution
        {
            public string EvolutionType { get; set; }
            public int EvolutionIndex { get; set; }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pokemon = new Dictionary<string, List<Evolution>>();

            while (input != "wubbalubbadubdub")
            {
                var pokemonTokens = input.Split(' ', '-', '>').Where(t => t != "").ToArray();

                var pokemonName = pokemonTokens[0];

                if (pokemonTokens.Length == 1)
                {
                    if (pokemon.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var evolution in pokemon[pokemonName])
                        {
                            Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                        }
                    }
                    input = Console.ReadLine();
                    continue;
                }

                if (!pokemon.ContainsKey(pokemonName))
                {
                    pokemon[pokemonName] = new List<Evolution>();
                }

                var evolutionType = pokemonTokens[1];
                var evolutionIndex = int.Parse(pokemonTokens[2]);

                var newEvolution = new Evolution
                {
                    EvolutionType = evolutionType,
                    EvolutionIndex = evolutionIndex
                };

                pokemon[pokemonName].Add(newEvolution);

                input = Console.ReadLine();
            }

            foreach (var pok in pokemon)
            {
                Console.WriteLine($"# {pok.Key}");

                foreach (var evolution in pokemon[pok.Key].OrderByDescending(e => e.EvolutionIndex))
                {
                    Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                }
            }
        }
    }
}
