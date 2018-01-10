using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class MinMaxKereses
    {
        static void Main(string[] args)
        {
            int n,min=400,max=-1;
            int[] tomb;
            Random rand = new Random();

            Console.WriteLine("Adja meg a tömb méretét!");
            n = int.Parse(Console.ReadLine());

            tomb = new int[n];

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                tomb[i] = rand.Next(300);
            }

            foreach (int szam in tomb)
            {
                if(szam<min)
                {
                    min = szam;
                }
                
                if(szam>max)
                {
                    max = szam;
                }
            }

            Console.WriteLine("A tömb legkisebb eleme:{0}", min);
            Console.WriteLine("A tömb legnagyobb eleme:{0}", max);

            Console.ReadKey();

        }
    }
}
