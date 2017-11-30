using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int k = 0;
            input = input.ToLower();

            foreach(char l in input)
            {
                if (l == 'l')
                k++;
            }
            Console.WriteLine($"{k}");
            Console.ReadKey();
        }
    }
}
