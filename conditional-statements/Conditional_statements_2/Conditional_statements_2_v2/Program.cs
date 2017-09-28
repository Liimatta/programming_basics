using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements_2_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä tiedot");
            Console.WriteLine("Ikä");
            String userInput1;
            userInput1 = Console.ReadLine();

            int a;
            int.TryParse(userInput1, out a);

            Console.WriteLine("Oletko MTK:n jäsen? y/n");
            String userInput2;
            userInput2 = Console.ReadLine();

            char b;
            char.TryParse(userInput2, out b);

            Console.WriteLine("Oletko varusmies? y/n");
            String userInput3;
            userInput3 = Console.ReadLine();

            char c;
            char.TryParse(userInput3, out c);

            Console.WriteLine("Oletko opiskelija? y/n");
            String userInput4;
            userInput4 = Console.ReadLine();

            char d;
            char.TryParse(userInput4, out d);

            if (a < 7)
                Console.WriteLine("0e");

            else if (b == 'y' && d == 'y')
                Console.WriteLine("Alennus-%  -60%  Hinta  6,40e");

            else if (a > 7 && a < 15)
                Console.WriteLine("Alennus-%  -50%  Hinta  8.00e");
            else if (a > 65)
                Console.WriteLine("Alennus-%  -50%  Hinta  8.00e");

            else if (c == 'y')
                Console.WriteLine("Alennus-%  -50%  Hinta  8.00e");

            else if (d == 'y')
                Console.WriteLine("Alennus-%  -45%  Hinta  8.80e");

            else if (b == 'y')
                Console.WriteLine("Alennus-%  -15%  Hinta  13,60e");
            else
                Console.WriteLine("Hinta  16e");

            Console.ReadKey();
        }
    }
}
