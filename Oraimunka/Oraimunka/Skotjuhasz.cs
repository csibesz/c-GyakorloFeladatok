using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class Skotjuhasz : Kutya, IValami
    {
        public void Eszik()
        {
            Console.WriteLine("Skotjuhasz eszik");
        }

        public void Iszik()
        {
            Console.WriteLine("Skotjuhasz eszik");
        }

        public void Ugat()
        {
            Console.WriteLine("Skotjuhasz eszik");
        }
    }
}
