using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class PozitivNegativRandom
    {
        static void Main(string[] args)
        {
            int n;
            int[] szamok;

            int negativ = 0;
            int pozitiv = 0;

            Random rand = new Random();

            //tömb méretének bekérése
            Console.WriteLine("Adja meg a tömb méretét:");
            n = int.Parse(Console.ReadLine());
            szamok = new int[n];

            //tömb feltöltés
            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                szamok[i] = rand.Next(-50, 50);
            }

            foreach (int szam in szamok)
            {
                if (szam < 0)
                {
                    negativ++;
                }
                else 
                {
                    pozitiv++;
                }
            }

            Console.WriteLine("Pozitív számok:{0}", pozitiv);
            Console.WriteLine("Negativ számok:{0}", negativ);
            Console.ReadKey();
        }
    }
}

  
