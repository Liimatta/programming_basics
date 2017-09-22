using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements_t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku. Ohjelma kertoo onko se positiivinen vai negatiivinen, sekä onko luku pariton vai parillinen");
            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            if (evaluatedNumber < 0 && evaluatedNumber % 2 == 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja parillinen");
            }
            else if (evaluatedNumber > 0 && evaluatedNumber % 2 ==0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on positiivinen ja parillinen");
            }
            else if (evaluatedNumber > 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on positiivinen ja pariton");
            }
            else if (evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja pariton");
            }
            else if (evaluatedNumber == 0)
            {
                Console.WriteLine($"Numero 0 on 0");
            }

            Console.WriteLine($"Syötetty arvo {userInput}");
            Console.ReadKey();
        }
    }
}
