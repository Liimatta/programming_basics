using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_statements_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä arvo");

            String userinput1;
            userinput1 = Console.ReadLine();


            int a = Convert.ToInt32(userinput1);
            int i = 0;
            int f = 0;
            int k = 1;
            int b = 0;

            if (a < 0)
                Console.WriteLine("Määrittelemätön");
            else

                do
                {

                    i = i + 2;
                    f = i + f;
                }

                while (i < a);

            do
            {

                b = k + b;
                k = k + 2;

            }
            while (k <= a);

            Console.WriteLine("Parillisten summa");
            Console.WriteLine(f);
            Console.WriteLine("Parittomien summa");
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
