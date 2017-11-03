using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_1._42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä 10 positiivista lukua");
            for (int rivit = 0; rivit < 11; rivit++)
            {
                Console.WriteLine("{0}:{1}", rivit + 1, xx());
            }
            Console.ReadLine();
        }

        static string xx()
        {
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            if (n <= 0)
                return "Luku ei kelpaa, syötä uusi";
            else
                return input;
        }














    }
}
