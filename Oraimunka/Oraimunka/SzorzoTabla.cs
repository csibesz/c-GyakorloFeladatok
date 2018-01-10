using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class SzorzoTabla
    {
        static void TömbFeltöltés(ref int[] _tmb)
        {
            Random rnd = new Random();
            for (int i = 0; i < _tmb.GetLength(0); i++)
            {
                _tmb[i] = rnd.Next(50);
            }
        }
        static void Main(string[] args)
        {
            int n,szam,osszeg;
            int[] tmb;
            int[] tmb3;
            int[] tmb4;
            Console.WriteLine("Adja meg a szorzótábla méretét:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a számot:");
            szam = int.Parse(Console.ReadLine());

            tmb = new int[n];
            tmb3 = new int[n];
            tmb4 = new int[n];

            TömbFeltöltés(ref tmb);
            TömbFeltöltés(ref tmb3);
            TömbFeltöltés(ref tmb4);

            Console.ReadKey();
        }
    }
}
