using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokaalit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita jotain. Ohjelma laskee vokaalien määrän syötteestä");
            string s = Console.ReadLine();
            var konsonantit = new string[] { "q", "w", "r", "t", "p", "s", "d", "f", "g", "h", "j", "k", "l", "m", "n", "b", "v", "c", "x", "z"};
            foreach (var k in konsonantit)
            {
                s = s.Replace(k, string.Empty);
            }

            Console.WriteLine($"Vokaalien määrä syötteessä on {s.Length}");
            Console.ReadKey();
        }
    }
}
