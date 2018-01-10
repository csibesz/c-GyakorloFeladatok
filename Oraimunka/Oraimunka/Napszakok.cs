using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class Napszakok
    {
        static void Main(string[] args)
        {
            string nev;
            DateTime ido = DateTime.Now;
            
            Console.WriteLine("Adja meg a nevét!");
            nev = Console.ReadLine();

            if (ido.Hour > 5 && ido.Hour < 9)
                Console.WriteLine("Jóreggelt {0}!",nev);
            else if(ido.Hour > 9 && ido.Hour < 18)
                Console.WriteLine("Jó napot {0}!", nev);
            else 
                Console.WriteLine("Jó estét {0}!", nev);

            Console.ReadKey();
        }
    }
}
