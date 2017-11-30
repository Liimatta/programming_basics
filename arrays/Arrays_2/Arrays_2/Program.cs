using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = Enumerable.Range(1, 40).ToArray();
            int[] numerot = new int[9];
            Random r = new Random();
            Console.WriteLine("Lottonumerot:");


            for (int i = 0; i < 9; i++)
            {
                int l = r.Next(40);
                numerot[i] = lotto[l];
                lotto[l] = lotto[i];
            }



            for (int k = 0; k < 7; k++)
            {
                Console.Write($"{numerot[k]} ");
            }
            Console.WriteLine($"\n\nLisänumerot: {numerot[7]} {numerot[8]}");
            int tuplaus = r.Next(40);
            Console.WriteLine($"Tuplausnumero: {tuplaus}");
            
            
            Console.ReadKey();
        }


    }
}
