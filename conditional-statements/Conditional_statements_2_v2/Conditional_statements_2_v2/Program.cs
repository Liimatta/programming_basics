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

            int b;
            int.TryParse(userInput2, out b);

            Console.WriteLine("Oletko varusmies? y/n");
            String userInput3;
            userInput3 = Console.ReadLine();

            int c;
            int.TryParse(userInput3, out c);

            Console.WriteLine("Oletko opiskelija? y/n");
            String userInput4;
            userInput4 = Console.ReadLine();

            int d;
            int.TryParse(userInput4, out d);

            if (a < 7)
                Console.WriteLine("0e");

            else if (b == 1 && d == 1)
                Console.WriteLine("-60%");

            else if (a > 7 && a < 15)
                Console.WriteLine("-50%");
            else if (a > 65)
                Console.WriteLine("-50%");

            else if (c == 1)
                Console.WriteLine("-50%");

            else if (d == 1)
                Console.WriteLine("-45");
            else if (b == 1)
                Console.WriteLine("-15%");
            else
                Console.WriteLine("16e");

            Console.ReadKey();
        }
    }
}
