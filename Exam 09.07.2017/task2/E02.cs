using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonDistances = Console.ReadLine().Split().Where(p => p != "").Select(int.Parse).ToList();

            var sumOfRemovedElems = 0;

            var removedElement = 0;

            while (pokemonDistances.Count != 0)
            {
                var index = int.Parse(Console.ReadLine());

                if(index < 0)
                {
                    removedElement = pokemonDistances.First();
                    pokemonDistances.RemoveAt(0); // 1 2 3 4
                    pokemonDistances.Reverse(); // 4 3 2
                    pokemonDistances.Add(pokemonDistances[0]); // 4 3 2 4
                    pokemonDistances.Reverse();
                }
                else if(index > pokemonDistances.Count - 1)
                {
                    removedElement = pokemonDistances.Last();
                    pokemonDistances.RemoveAt(pokemonDistances.Count - 1);
                    pokemonDistances.Add(pokemonDistances[0]);
                }
                else
                {
                    removedElement = pokemonDistances.ElementAt(index);
                    pokemonDistances.RemoveAt(index);
                }

                sumOfRemovedElems += removedElement;

                for (int i = 0; i < pokemonDistances.Count; i++)
                {
                    if(pokemonDistances[i] <= removedElement)
                    {
                        pokemonDistances[i] += removedElement;
                    }
                    else
                    {
                        pokemonDistances[i] -= removedElement;
                    }
                }
            }

            Console.WriteLine(sumOfRemovedElems);
        }
    }
}
