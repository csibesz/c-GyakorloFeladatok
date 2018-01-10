using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevekFajlbaVegjelig
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter f = new StreamWriter("nevekfajlba.txt", true);
            string nevek;
            do
            {
                Console.Write("Kérem adja meg a nevet: ");
                nevek = Console.ReadLine();
                if (nevek != "kilép")
                {
                    f.WriteLine(nevek);
                    f.Flush();
                }
            } while (nevek != "kilép");
            f.Close();
        }
    }
}
