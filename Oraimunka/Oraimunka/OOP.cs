using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class OOP
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[10];
            Nemetjuhasz ordas = new Nemetjuhasz();
            Kutya bodri = new Kutya("Bodri",6, 20);
            Kutya fules = new Kutya("Füles",2,10);

            bodri.AdattagokKiiratasa();
            fules.AdattagokKiiratasa();
            
           
            bodri.Ugatas();
            fules.Ugatas();
            Console.ReadKey();

        }
    }
   
}
