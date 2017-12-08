using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.ToLower();
            s = s.Replace(" ", "");

            int l = s.Length - 1;
            int i = 0;
            while(i < l)
            {
                if (s[i] != s[l])
                {
                    Console.WriteLine("Syöte ei ole palindromi");
                    break;
                }

                i++;
                l--;

                if (i >= l)
                    Console.WriteLine("Syöte on palindromi");
            }
            Console.ReadKey();
        }
    }
}
