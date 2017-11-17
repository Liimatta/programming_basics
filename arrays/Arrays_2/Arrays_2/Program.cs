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
            int[] lotto = new int[40];
            Random r = new Random();
            for(int i = 0; i<7; i++)
            {
                lotto[i] = r.Next(1, 40);
            }
            Array.Sort(lotto);
            int k = 0;
            int j = 0;
            for (int i = 0; i < 40; i++)
            {
                if(lotto[i] == lotto[i+1])
                {
                    tulos[k] = lotto[i];

                }
            }
        }
    }
}
