using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bojomonPattern = @"[A-Za-z]+\-[A-Za-z]+";
            var didimonPattern = @"[^A-Za-z\-]+";

            var text = Console.ReadLine();

            int turn = 0;

            while (text.Length != 0)
            {
                var didimonMatch = Regex.Match(text, didimonPattern);
                var bojomonMatch = Regex.Match(text, bojomonPattern);

                if (turn % 2 == 0)
                {
                    if (!didimonMatch.Success)
                    {
                        break;
                    }
                    while(text.IndexOf(didimonMatch.Value) != 0)
                    {
                        text = new string(text.Skip(1).ToArray());
                    }
                    Console.WriteLine(didimonMatch.Value);
                    text = new string(text.Skip(didimonMatch.Value.Length).ToArray());
                }
                else
                {
                    if (!bojomonMatch.Success)
                    {
                        break;
                    }
                    while (text.IndexOf(bojomonMatch.Value) != 0)
                    {
                        text = new string(text.Skip(1).ToArray());
                    }
                    Console.WriteLine(bojomonMatch.Value);
                    text = new string(text.Skip(bojomonMatch.Value.Length).ToArray());
                }

                turn++;
            }
        }
    }
}
