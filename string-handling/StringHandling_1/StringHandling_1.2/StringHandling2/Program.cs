using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = Console.ReadLine();
            i = i.ToLower();
            i = i.Replace("e" , "@");
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
