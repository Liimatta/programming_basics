using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Random r = new Random();

            Console.WriteLine("Ohjelma tulostaa 20 satunnaista numeroa välillä 1-50");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            do

            {
                i = i + 1;

                Console.Write(r.Next(50));
                Console.Write(", ");
                Console.Write(r.Next(50));
                Console.Write(", ");
                Console.Write(r.Next(50));
                Console.Write(", ");
                Console.Write(r.Next(50));
                Console.Write(", ");
                Console.Write(r.Next(50));
                Console.WriteLine();
            }

            while (i < 4);


            Console.ReadKey();
        }
    }
}
