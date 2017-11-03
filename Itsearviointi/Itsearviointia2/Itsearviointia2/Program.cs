using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita lause");
            int n = 0;
            string r = Console.ReadLine();
            foreach (char c in r)
                if (char.IsLetterOrDigit(c)) //jotte välejä ei lasketa
                {
                    n++;
                }
            int i = 1;

            do
            {
                Console.WriteLine(i+":"+r);
                i++;
            }
            while (i <= n);

            Console.ReadKey();
        }
    }
}
