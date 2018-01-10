using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    // 1.Feladat
    public class Tábla
    {
        //2.feladat
        private char[,] T;
        private char ÜresCella;

        //3.feladat
        public Tábla(char _üresCella)
        {
            T = new char[8, 8];
            ÜresCella = _üresCella;

            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i, j] = ÜresCella;
                }
            }
        }

        //4.feladat
        public void Megjelenít()
        {
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    Console.Write(T[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }

        //5.feladat
        public void Elhelyez(int N)
        {
            int sor = 0, oszlop = 0, szamlalo = 0;
            Random sorOszlopSzam = new Random();

            while (szamlalo < N)
            {
                sor = sorOszlopSzam.Next(0, 8);
                oszlop = sorOszlopSzam.Next(0, 8);

                if (T[sor, oszlop] != 'K')
                {
                    T[sor, oszlop] = 'K';
                    szamlalo++;
                }
            }
        }

        //7.feladat
        public bool ÜresOszlop(int oszlop)
        {
            bool talaltKiralyno = false;

            for (int i = 0; i < T.GetLength(0); i++)
            {
                if (T[i, oszlop] == 'K')
                {
                    talaltKiralyno = true;
                }
            }

            if (talaltKiralyno == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ÜresSor(int sor)
        {
            bool talaltKiralyno = false;

            for (int i = 0; i < T.GetLength(1); i++)
            {
                if (T[sor, i] == 'K')
                {
                    talaltKiralyno = true;
                }
            }

            if (talaltKiralyno == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //8.feladat
        public int ÜresOszlopokSzáma()
        {
            int uresOszlopokSzama = 0;

            for (int i = 0; i < T.GetLength(1); i++)
            {
                if (this.ÜresOszlop(i))
                {
                    uresOszlopokSzama++;
                }
            }

            return uresOszlopokSzama;
        }
        public int ÜresSorokSzáma()
        {
            int uresSorokSzama = 0;

            for (int i = 0; i < T.GetLength(0); i++)
            {
                if (this.ÜresSor(i))
                {
                    uresSorokSzama++;
                }
            }

            return uresSorokSzama;
        }

        public void Fájlbaír()
        {
            StreamWriter sw = new StreamWriter("tablak64.txt", true);

            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    sw.Write(T[i, j]);
                }
                sw.Write(Environment.NewLine);
            }
            sw.Write(Environment.NewLine);

            sw.Close();
        }
    }
}
