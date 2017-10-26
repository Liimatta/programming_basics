using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vakioveikkausrivi");


            Random r = new Random();
            int result = 0;
            int k = 0;


            for (int i = 1; i < 1001; i++)
            {
                result = r.Next(1, 7);

                Console.Write(i);
                Console.Write("-");
                Console.WriteLine(result);
                if (result == 6)
                {
                    k++;
                }
            }
            Console.WriteLine("6 heitettiin {0} kertaa", k);
            //Janne L
            Console.ReadKey();
        }
    }
}
