using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita jotain. Ohjelma laskee montako merkkiä syötit");
            string i = Console.ReadLine();
            Console.WriteLine($"Merkkijono oli {i.Length} merkkiä pitkä, sisältäen välilyönnit");
            Console.ReadKey();
        }
    }
}
