using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool vali = true;

            while(vali)
            {
            Console.WriteLine("Syötä numero välillä 0-100.");
            string input = Console.ReadLine();
            int k;

                if (int.TryParse(input, out k) && k >= 0 && k <= 100)
                {
                    Console.WriteLine("Numero OK!");
                    vali = false;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Syöte ei kelpaa.");//Janne L
                }
            }

        }
    }
}
