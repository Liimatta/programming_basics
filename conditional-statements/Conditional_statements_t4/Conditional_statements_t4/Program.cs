using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements_t4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int i, j, tmp;
            Console.WriteLine("Kirjoita kolme numeroa:");
            
            

                for (i = 0; i < 3; i++)
                {
                Console.Write(
                    "Numero {0} : ",i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
            for (i=0; i<3; i++)
            {
                for (j=i+1; j<3; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
                Console.Write("Nousevassa järjestyksessä");
                for (i=0; i<3; i++)
                {
                    Console.Write("{0} ", arr1[i]);
                }
                Console.Write("\n\n");
                Console.Read();
            }
        }
    }
}