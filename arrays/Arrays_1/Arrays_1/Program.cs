using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random r = new Random();
            double n = 0;
            for (int i = 0; i < 100; i++)
            {
                int k = r.Next(0, 51);
                array[i] = k;
                Console.WriteLine($"{i+1}. {array[i]}");
                n = k + n;
                
            }
            double y = n / 100;
            Console.WriteLine($"Summa on {n} ja keskiarvo on {y}");
            Console.ReadLine();
            
        }
        
        
    }
}
