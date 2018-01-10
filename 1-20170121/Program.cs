using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány számot szeretne bevinni: ");
            int[] szamok = new int[Convert.ToInt16(Console.ReadLine())];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("Kérem a {0} számot: ", i + 1);
                szamok[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(szamok[i]);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Az {0} index eredménye {1}", i, szamok[i]);
            }

            int index = 0;
            while (index < szamok.Length)
            {
                Console.WriteLine("Az {0} index eredménye {1}", index, szamok[index]);
                index++;
            }

            foreach (int item in szamok)
            {
                Console.WriteLine("A bevitt eredemény: " + item);
            }

            Console.ReadKey();
        }
    }
}
