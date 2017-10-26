using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako kertaa kolikkoa heitetään?");

            int k = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int klaava = 0;
            int kruuna = 0;
            int result = 0;
            

            
            for (int i = 0; i<k; i++)
            {
                result = r.Next(0, 2);
                if (result == 1)
                {
                    kruuna++;
                }
                else
                {
                    klaava++;
                }
            }
            Console.WriteLine("Kruuna heitettiin {0} kertaa", kruuna);
            Console.WriteLine("Klaava heitettiin {0} kertaa", klaava);

            Console.ReadKey();


            //Janne L
        }
        
    }
}
