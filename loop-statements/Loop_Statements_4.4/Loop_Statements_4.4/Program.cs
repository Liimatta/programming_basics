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
            Console.WriteLine("Let's flip a coin 10000 times");

            string userinput1;
            userinput1 = Console.ReadLine();

            Random r = new Random();
            int klaava = 0;
            int kruuna = 0;
            int result = 0;
            

            
            for (int i = 0; i< 5; i++)
            {
                result = Rand.Next(0, 2);
                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine("heads was flipped {0} times",heads);
            Console.WriteLine("tails was flipped {0} times", tails);
            return result;



        }
        
    }
}
