using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.feladat
            Tábla tabla = new Tábla('#');
            tabla.Megjelenít();

            //6.feladat
            tabla.Elhelyez(8); 
            tabla.Megjelenít();

            //9.feladat
            Console.WriteLine("Üres oszlopok és sorok száma:");
            Console.WriteLine("Oszlopok: {0}",tabla.ÜresOszlopokSzáma());
            Console.WriteLine("Sorok: {0}", tabla.ÜresSorokSzáma());

            //10.feladat
            if(File.Exists("tablak64.txt"))
            {
                File.Delete("tablak64.txt");
            }

            for (int i = 0; i < 64; i++)
            {
                Tábla tablaPeldany = new Tábla('*');
                tablaPeldany.Elhelyez(i + 1);
                tablaPeldany.Fájlbaír();
            }

            Console.ReadKey();
        }
    }
}
