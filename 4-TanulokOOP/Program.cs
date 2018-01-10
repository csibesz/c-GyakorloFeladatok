using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TanulokOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanulo t = new Tanulo("Alma",3.4,"Körte");

            StreamReader f = new StreamReader("atlagok.txt");
            Tanulo[] tanulok = new Tanulo[Convert.ToInt32(f.ReadLine())];

            for (int i = 0; i < tanulok.Length && !f.EndOfStream; i++)
            {
                string nev = f.ReadLine();
                double atlag = Convert.ToDouble(f.ReadLine());
                string szamSzam = f.ReadLine();
                tanulok[i] = new Tanulo(nev, atlag, szamSzam);
                Console.WriteLine(tanulok[i].Nev + " - " + tanulok[i].SzemSzam );
            }
            f.Close();

            //Átlag
            double osztalyAtlag = 0;
            for (int i = 0; i < tanulok.Length; i++)
            {
                osztalyAtlag += tanulok[i].Atlag;
            }
            osztalyAtlag /= tanulok.Length;
            Console.WriteLine("A tanulók átlaga: " + osztalyAtlag);
        }
    }
}
