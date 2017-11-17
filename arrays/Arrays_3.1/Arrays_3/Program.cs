using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[10];
            int i = 0;
            Random r = new Random();
            int k = 0;
            Console.WriteLine("[x] Arvo");
            for (i = 0; i < 10; i++)
            {
                k = r.Next(0, 20);
                taulukko[i] = k;
                if (k < 10)
                    Console.WriteLine($"[{i}] 0{taulukko[i]}");
                else
                    Console.WriteLine($"[{i}] {taulukko[i]}"); //Janne Liimatta
            }
            Console.ReadKey();
        }
    }
}
