using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class PozitivNegativ
    {
        static void Main(string[] args)
        {
            int szam = 0;
            int count = 0;
            int negativ = 0;
            int pozitiv = 0;
            string input;

            do
            {
                Console.WriteLine("Adja meg a {0}. számot:",count+1);
                input = Console.ReadLine();
                if(input != "x" && int.Parse(input) < 0)
                {
                    negativ++;
                }
                else if(input != "x")
                {
                    pozitiv++;
                }

                count++;
            } while (input!="x");

            Console.WriteLine("Pozitív számok:{0}", pozitiv);
            Console.WriteLine("Negativ számok:{0}", negativ);
            Console.ReadKey();
        }
    }
}
