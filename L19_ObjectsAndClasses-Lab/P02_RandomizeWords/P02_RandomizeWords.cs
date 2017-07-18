using System;
using System.Linq;

namespace P02_RandomizeWords
{
    class P02_RandomizeWords
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var wordsList = Console.ReadLine()
                .Split(' ')
                .ToList();
            var wordsCount = wordsList.Count;
            for (int i = 0; i < wordsCount - 1; i++)
            {
                int j = rand.Next(0, wordsCount);
                if (i != j)
                {
                    var old = wordsList[i];
                    wordsList[i] = wordsList[j];
                    wordsList[j] = old;
                }
            }

            foreach (var word in wordsList)
            {
                Console.WriteLine(word);
            }
        }
    }
}

/////////////////////////////////////////////////////////////////////////////////

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;
    using System.Net;
    using System.IO;


    namespace P1.DateTime
    {
        class Program
        {
            static void Main(string[] args)
            {
                var words = Console.ReadLine().Split(' ');

                var random = new Random();

                var result = new List<string>();
                for (int i = 0; i < words.Length; i++)
                {
                    var currentWord = words[i];
                    var randomIndex = random.Next(0, words.Length);

                    var tempWord = words[randomIndex];
                    words[i] = tempWord;
                    words[randomIndex] = currentWord;

                }
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
