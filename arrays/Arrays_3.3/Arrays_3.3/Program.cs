using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      01 02 03 04 05 06 07 08 09 10");
            Console.WriteLine("___________________________________");
            int i = 0;
            Random r1 = new Random();

            int[] arr1 = new int[10]; //ensimmäisen taulukon muuttujat
            int l1 = 0;

            int[] arr2 = new int[10]; //toisen taulukon muuttujat
            int l2 = 0;

            Console.Write("Arr1: ");
            for (i = 0; i < 10; i++)
            {
                l1 = r1.Next(0, 99);
                arr1[i] = l1;
                if(l1<10)
                    Console.Write($"0{arr1[i]} ");
                else
                    Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine();
            Console.Write("Arr2: ");

            for (i=0;i<10;i++)
            {
                l2 = r1.Next(0, 99);
                arr2[i] = l2;
                if(l2<10)
                    Console.Write($"0{arr2[i]} ");
                else
                    Console.Write($"{arr2[i]} ");

            }
            Console.WriteLine();
            Console.Write("Arr3: ");
            int[] arr3 = new int[10];
            for (i = 0; i < 10; i++)
            {
                if (arr1[i] > arr2[i])
                    arr3[i] = arr1[i];
                else
                    arr3[i] = arr2[i];
            }
            for(i=0; i<10;i++)
            {
                if (arr3[i] < 10)
                    Console.Write($"0{arr3[i]} ");
                else
                    Console.Write($"{arr3[i]} ");
            }
            Console.ReadKey();
        }
    }
}
