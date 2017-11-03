using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita lause. Ohjelma tulostaa sen viisi kertaa");
            string r = Console.ReadLine();
            int i = 1;
            do
            {
                Console.WriteLine(i+":"+r);
                i++;
            }
            while (i < 6);

            Console.ReadKey();

        }
    }
}
