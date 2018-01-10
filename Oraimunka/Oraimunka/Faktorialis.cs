using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class Faktorialis
    {
        static public int Fact(int x)
        {
            if (x == 0) { return 1; }
            else return x * Fact(x - 1);
        }

        static void Main(string[] args)
        {
            int result = Fact(10);
            double res = Math.Pow(2, 10);
        }
    }
}
