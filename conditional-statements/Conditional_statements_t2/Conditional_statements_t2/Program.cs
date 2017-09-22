using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements_t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita luku. Ohjelma kertoo onko se pariton vai parillinen");
            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            if (evaluatedNumber % 2 == 0)
            {
                Console.Write("Numero on parillinen");
                Console.Read();
            }
            
            else
            {
                Console.Write("Numero on pariton");
                Console.Read();
            }

        }
    }
}
