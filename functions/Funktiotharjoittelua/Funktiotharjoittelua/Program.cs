using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiotharjoittelua
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for(int laskuri = 0; laskuri <4; laskuri++)
            {
                Console.WriteLine("Rivi {0}: {1}", laskuri + 1, luvutListaan(r));
            }
            Console.ReadLine();
        }
        static string luvutListaan(Random x)
        {
            int arpa = 0;
            string viesti = "";
            for(int luku = 0; luku <5; luku++)
            {
                arpa = x.Next(51);
                viesti += string.Format("{0},", muotoileLuku(arpa));
            }
            return viesti;
            
        }
        static string muotoileLuku(int y)
        {
            if (y < 10)
                return "0" + y.ToString();
            else
                return y.ToString();
        }
    }
}
