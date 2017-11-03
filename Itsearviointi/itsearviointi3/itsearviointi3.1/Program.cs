using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsearviointi3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä lukuja. Kun syötät -1, ohjelma laskee syötetyt luvut yhteen.");
            int summa = 0;
            while (true)
            {
                string luku = Console.ReadLine();
                int l = Convert.ToInt32(luku);

                if (l == -1)
                {
                    Console.WriteLine(summa);
                    break;
                }
                else
                    summa += l;
            }
            Console.ReadKey();

        }
    }
}
