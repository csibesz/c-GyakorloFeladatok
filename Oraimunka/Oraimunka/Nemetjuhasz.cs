using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class Nemetjuhasz : Kutya, IValami
    {
        public Nemetjuhasz()
        {
            this.testSuly = 10;
            this.neve = "NemetJuhasz";
        }

        public void Eszik()
        {
            Console.WriteLine("Németjuhász eszik");
        }

        public void Iszik()
        {
            Console.WriteLine("Németjuhász iszik");
        }

        public void Ugat()
        {
            Console.WriteLine("Németjuhász ugat");
        }
    }
}
