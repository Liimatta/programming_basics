using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä tiedot");
            Console.WriteLine("Ikä");
            String userInput1;
            userInput1 = Console.ReadLine();

            int a;
            int.TryParse(userInput1, out a);

            Console.WriteLine("Oletko MTK:n jäsen? y/n");
            String userInput2;
            userInput2 = Console.ReadLine();

            int b;
            int.TryParse(userInput2, out b);

            Console.WriteLine("Oletko varusmies? y/n");
            String userInput3;
            userInput3 = Console.ReadLine();

            int c;
            int.TryParse(userInput3, out c);

            Console.WriteLine("Oletko opiskelija? y/n");
            String userInput4;
            userInput4 = Console.ReadLine();

            int d;
            int.TryParse(userInput4, out d);

            // alle 7 v
            if (a < 7)
                Console.WriteLine("Lipun hinta 0e");
            // 7-15 v
            else if (7 < a && a < 15 && b == 'y' && c == 'y' && d == 'y') // opiskelija, mtk, varusmies
                Console.WriteLine("Lipun hinta 6,4e");
            else if (7 < a && a < 15 && b == 'y' && c == 'n' && d == 'y') // opiskelija, mtk, ei varusmies
                Console.WriteLine("Lipun hinta 6,4e");
            else if (7 < a && a < 15 && b == 'n' && c == 'y' && d == 'y') // opiskelija, ei mtk, varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (7 < a && a < 15 && b == 'n' && c == 'y' && d == 'n') // ei opiskelija, mtk, varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (7 < a && a < 15 && b == 'n' && c == 'n' && d == 'y') // opiskelija, ei mtk, ei varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (7 < a && a < 15 && b == 'y' && c == 'n' && d == 'n') // ei opiskelija, mtk, ei varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (7 < a && a < 15 && b == 'n' && c == 'n' && d == 'n') // ei opiskelija, ei mtk, ei varusmies
                Console.WriteLine("Lipun hinta 8e");


            // 15-65
            else if (15< a && a < 65 && b == 'y' && c == 'y' && d == 'y') // opiskelija, mtk, varusmies
                Console.WriteLine("Lipun hinta 6,4e");
            else if (15< a && a < 65 && b == 'y' && c == 'n' && d == 'y') // opiskelija, mtk, ei varusmies
                Console.WriteLine("Lipun hinta 6,4e");
            else if (15< a && a < 65 && b == 'n' && c == 'y' && d == 'y') // opiskelija, ei mtk, varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (15< a && a < 65 && b == 'n' && c == 'y' && d == 'n') // ei opiskelija, mtk, varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (15< a && a < 65 && b == 'n' && c == 'n' && d == 'y') // opiskelija, ei mtk, ei varusmies
                Console.WriteLine("Lipun hinta 8,8e");
            else if (15< a && a < 65 && b == 'y' && c == 'n' && d == 'n') // ei opiskelija, mtk, ei varusmies
                Console.WriteLine("Lipun hinta 13,6e");
            else if (15< a && a < 65 && b == 'n' && c == 'n' && d == 'n') // ei opiskelija, ei mtk, ei varusmies
                Console.WriteLine("Lipun hinta 16e");

            // 65<
            else if (65< a && b == 'y' && c == 'y' && d == 'y') // opiskelija, mtk, varusmies
                Console.WriteLine("Lipun hinta 6,4e");
            else if (65< a && b == 'y' && c == 'n' && d == 'y') // opiskelija, mtk, ei varusmies
                Console.WriteLine("Lipun hinta 6,4e");
            else if (65< a && b == 'n' && c == 'y' && d == 'y') // opiskelija, ei mtk, varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (65< a && b == 'n' && c == 'y' && d == 'n') // ei opiskelija, mtk, varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (65< a && b == 'n' && c == 'n' && d == 'y') // opiskelija, ei mtk, ei varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (65< a && b == 'y' && c == 'n' && d == 'n') // ei opiskelija, mtk, ei varusmies
                Console.WriteLine("Lipun hinta 8e");
            else if (65< a && b == 'n' && c == 'n' && d == 'n') // ei opiskelija, ei mtk, ei varusmies
                Console.WriteLine("Lipun hinta 8e");

            Console.ReadKey();

            
        }
    }
}
