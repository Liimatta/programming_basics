using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_1._4
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int count = 0;
                int suurin = 0;
                
                while (count < 10)
                {
                    Console.WriteLine("Anna positiivinen kokonaisluku: ");

                    string input;
                    input = Console.ReadLine();
                    int n = Convert.ToInt32(input);

                    if (n >= 0)
                    {
                        count = n;
                        count++;
                    }
            

                    else

                    {
                        Console.WriteLine("Antamasi luku ei ole positiivinen kokonaisluku.");
                    }

                }

            for (int x = 0; x < 10; x++)
            {
                    if (x > suurin) ;
                
            }

            Console.WriteLine("Suurin luku oli {0}", suurin);


            }

        }
    }
}
