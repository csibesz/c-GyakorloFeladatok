using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class Oszthatosag
    {
        static void Main(string[] args)
        {
            int szam,maradek_3,maradek_4,maradek_9;

            Console.WriteLine("Adjon meg egy számot");
            szam = int.Parse(Console.ReadLine());

            maradek_3 = szam%3;
            maradek_4 = szam%4;
            maradek_9 = szam%9;

            if (maradek_3 == 0)
                Console.WriteLine("Osztható 3-mal!");
            else
                Console.WriteLine("Nem osztható 3-mal!");

            if (maradek_4 == 0)
                Console.WriteLine("Osztható 4-mal!");
            else
                Console.WriteLine("Nem osztható 4-mal!");

            if (maradek_9 == 0)
                Console.WriteLine("Osztható 9-mal!");
            else
                Console.WriteLine("Nem osztható 9-mal!");

            Console.ReadKey();
        }
    }
}
