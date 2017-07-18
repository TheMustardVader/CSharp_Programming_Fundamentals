using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var pokes = 0;

            decimal halfN = n / 2m;

            while (n >= m)
            {
                n -= m;
                pokes++;

                if (n == halfN)
                {
                    try
                    {
                        n /= y;
                    }
                    catch
                    {

                    }
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}
