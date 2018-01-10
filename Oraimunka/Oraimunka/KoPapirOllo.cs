using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class KoPapirOllo
    {
        enum KoPapirOlloEnum { Kő = 1, Papír = 2, Olló = 3 };
        static void Main(string[] args)
        {
            KoPapirOlloEnum jatekos = KoPapirOlloEnum.Kő;
            KoPapirOlloEnum gep = KoPapirOlloEnum.Kő;
            int szam;
            bool ujra = true;
            Random rand = new Random();

            do
            {
                do
                {
                    Console.WriteLine("Válasszon az opciók közül!\nkő=1,papír=2,ollo=3");
                    szam = int.Parse(Console.ReadLine());
                    if (szam >= 1 && szam <= 3)
                    {
                        jatekos = (KoPapirOlloEnum)szam;
                        ujra = false;
                    }
                    else
                    {
                        Console.WriteLine("Helytelen opció!");
                    }


                } while (ujra);


                switch (rand.Next(1, 3))
                {
                    case 1:
                        gep = KoPapirOlloEnum.Kő;
                        break;
                    case 2:
                        gep = KoPapirOlloEnum.Papír;
                        break;
                    case 3:
                        gep = KoPapirOlloEnum.Olló;
                        break;
                }

                if (jatekos == KoPapirOlloEnum.Kő && gep == KoPapirOlloEnum.Olló
                    || jatekos == KoPapirOlloEnum.Olló && gep == KoPapirOlloEnum.Papír
                    || jatekos == KoPapirOlloEnum.Papír && gep == KoPapirOlloEnum.Kő)
                {
                    Console.WriteLine("Játékos vs Gép : {0} vs {1}", jatekos, gep);
                    Console.WriteLine("A játékos nyert!");
                }
                else if (jatekos == KoPapirOlloEnum.Olló && gep == KoPapirOlloEnum.Kő
                    || jatekos == KoPapirOlloEnum.Papír && gep == KoPapirOlloEnum.Olló
                    || jatekos == KoPapirOlloEnum.Kő && gep == KoPapirOlloEnum.Papír)
                {
                    Console.WriteLine("Játékos vs Gép : {0} vs {1}", jatekos, gep);
                    Console.WriteLine("A gép nyert!");
                }
                else
                {
                    Console.WriteLine("Játékos vs Gép : {0} vs {1}", jatekos, gep);
                    Console.WriteLine("Döntetlen!");
                }

                Console.WriteLine("Szeretné újra játszani? y/n");
                if (Console.ReadLine() == "y")
                    ujra = true;
                else
                    ujra = false;

            } while (ujra);

            Console.ReadKey();
        }
    }
}
