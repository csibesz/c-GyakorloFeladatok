using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("otos.csv");
            int[] szamtomb = new int[300];

            while (!f.EndOfStream)
            {
                string[] adatok = f.ReadLine().Split(';');
                int szamKulcs = 0;
                for (int i = 11; i <= 15; i++)
                {
                    szamtomb[szamKulcs] = Convert.ToInt32(adatok[i]);
                    Console.Write(szamtomb[szamKulcs] + ((i == 15) ? Environment.NewLine : " - "));
                    szamKulcs++;
                }
            }
            f.Close();
            Console.WriteLine("--------------------");
            int[] max5 = new int[5];
            for (int i = 0; i < max5.Length; i++)
            {
                int max = 0;
                for (int j = 1; j < szamtomb.Length; j++)
                {
                    if (szamtomb[j] > szamtomb[max])
                    {
                        max = j;
                    }
                }
                max5[i] = szamtomb[max];
                Console.Write(max5[i] + " ");
                szamtomb[max] = 0;
            }
            /*
            foreach (int item in szamtomb)
            {
                Console.Write(item + " - ");
            }
            */
        }
    }
}
