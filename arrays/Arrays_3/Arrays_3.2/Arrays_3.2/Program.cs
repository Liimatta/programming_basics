using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] taulukko = new int[10,20];
            int i = 0;
            Random r = new Random();
            int y = 0;
            Console.WriteLine("[x] Arvo");
            for (i = 0; i < 10; i++)
            {
                {
                    for(y=0; y<20; y++)
                    {
                        int k = r.Next(0, 100);
                        taulukko[i, y] = k;
                        if (k < 10)
                            Console.WriteLine($"{i},{y} 0{k}");
                        else
                            Console.WriteLine($"{i},{y} {k}");
                    }

                }

            }
            Console.ReadKey();
        }
    }
}
