using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa lukujen 1-9 kertotaulut");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            int n = 0;
            do
            {
                int i = 0;
                int f = 1;
                n = n + 1;


                do
                {
                    i = i + 1;
                    f = i * n;

                    Console.Write(n);
                    Console.Write(" x ");
                    Console.Write(i);
                    Console.Write(" = ");
                    Console.WriteLine(f);
                }


                while (i < 9);

                Console.WriteLine("  ");
            }

            while (n < 9);
            Console.ReadKey();

        }
    }
}
