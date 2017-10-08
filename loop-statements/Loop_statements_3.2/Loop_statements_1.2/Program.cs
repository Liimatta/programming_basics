using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_statements_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä arvo");

            String userinput1;
            userinput1 = Console.ReadLine();


            int a = Convert.ToInt32(userinput1);
            int i = 1;
            int f = 1;


            if (a < 0)
                Console.WriteLine("Määrittelemätön");
            else

                do
                {

                    i = i + 1;
                    f = i + f;
                }

                while (i < a);
            

            Console.WriteLine("Summa");
            Console.WriteLine(f);


            Console.ReadKey();
        }
    }
}
