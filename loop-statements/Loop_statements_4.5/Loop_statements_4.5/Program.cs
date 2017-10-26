using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_statements_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vakioveikkausrivi");


            Random r = new Random();
            int result = 0;



            for (int i = 1; i < 14; i++)
            {
                result = r.Next(0, 10);
                if (result <= 4)
                {
                    Console.Write(i);
                    Console.WriteLine(") 1");
                    
                }
                else if(result >= 6)
                {
                    Console.Write(i);
                    Console.WriteLine(") 2");
                }
                else
                {
                    Console.Write(i);
                    Console.WriteLine(") X");
                }
            }

            Console.ReadKey();


            //Janne L
        }
    }
}
