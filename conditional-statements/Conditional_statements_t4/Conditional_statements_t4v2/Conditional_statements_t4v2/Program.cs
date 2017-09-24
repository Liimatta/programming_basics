using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements_t4v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kolme numeroa. Ohjelma järjestää numerot pienimmästä suurimpaan.");
            Console.WriteLine("Anna ensimmäinen numero.");
            String userInput1;
            userInput1 = Console.ReadLine();

            int a;
            int.TryParse(userInput1, out a);

            Console.WriteLine("Anna toinen numero");
            String userInput2;
            userInput2 = Console.ReadLine();

            int b;
            int.TryParse(userInput2, out b);

            Console.WriteLine("Anna kolmas numero");
            String userInput3;
            userInput3 = Console.ReadLine();

            int c;
            int.TryParse(userInput3, out c);

                if (a > b && b < c) ;
                Console.WriteLine($"{b} {c} {a}");

                else.if (a > b && c < b) ;
                Console.WriteLine($"{c} {b} {a}");

                else.if (b > a && c < a) ;
                Console.WriteLine($"{b} {a} {c}");

                else.if (b > a && a < c) ;
                Console.WriteLine($"{b} {c} {a}");

                else.if (c > b && b > a) ;
                Console.WriteLine($"{c} {b} {a}");}

                else.if (c > a && a > b) ;
                Console.WriteLine($"{c} {a} {b}");
            
            Console.ReadKey();
                
        }
    }
}
