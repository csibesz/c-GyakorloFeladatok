using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class Homerseklet
    {

        static void Main(string[] args)
        {
          
            int[,] homersekletek = new int[12, 30];
            int min = 50, max =-10, minIndex=0,maxIndex=0;
            int counter = 0, elozoHonap = 0;
            bool volte = false;
            Random rand = new Random();
            
            
            //hőmérséklet generálás
            for (int i = 0; i < homersekletek.GetLength(0); i++)
            {
                for (int j = 0; j < homersekletek.GetLength(2); j++)
                {
                    if (i >= 0 && i <= 2)
                        homersekletek[i, j] = rand.Next(-5, 2);
                    if (i >= 3 && i <= 4)
                        homersekletek[i, j] = rand.Next(15, 35);
                    if (i >= 7 && i <= 11)
                        homersekletek[i, j] = rand.Next(-5, 15);

                }
            }

            for (int i = 0; i < homersekletek.GetLength(0); i++)
            {
                if (i != elozoHonap)
                    counter = 0;

                for (int j = 0; j < homersekletek.GetLength(1); j++)
                {
                    if(elozoHonap == i)
                    {
                        if (homersekletek.GetLength(1)!= j+1
                            && homersekletek[i,j] < 0 
                            && homersekletek[i, j + 1] < 0)
                        {
                            counter++;
                            if(counter==5)
                            {
                                volte = true;
                            }
                        }
                    }
                    else
                    {
                        elozoHonap = i;
                    }

                    if (homersekletek[i,j] < min)
                    {
                        minIndex = i;
                        min = homersekletek[i, j];
                    }

                    if (homersekletek[i, j] > max)
                    {
                        maxIndex = i;
                        max = homersekletek[i, j];
                    }

                    Console.Write(homersekletek[i, j]+ " ");
                }
                elozoHonap = i;
                Console.Write("\n");
            }

            Console.WriteLine("Az év leghidegebb hónapja és hőmérséklete: {0}  , {1}",minIndex+1,min);
            Console.WriteLine("Az év legmelegebb hónapja és hőmérséklete: {0}  , {1}", maxIndex+1, max);
            Console.WriteLine("VOLT–E EGYMÁST KÖVETŐ ÖT NAP (EGY HÓNAPON BELÜL), AMIKOR MÍNUSZ FOKOT MÉRTÜNK? :  {0}", volte);
            Console.ReadKey();
        }
             
        }
}
