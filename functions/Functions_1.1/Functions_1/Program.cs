using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä numero");

            string userinput1;
            userinput1 = Console.ReadLine();
            int n = Convert.ToInt32(userinput1);
            if (n > 0)

                Console.WriteLine(new String('*', n));
            else
                Console.WriteLine("luku {0} ei ole sallittu", n);
            //Janne L
            Console.ReadKey();
        }
    }
}
