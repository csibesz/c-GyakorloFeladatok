using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class Kutya
    {
        protected string neve;
        private int eletKor;
        public int testSuly;

        public Kutya()
        {
            eletKor = 5;
            testSuly = 10;

        }
        public Kutya(string _neve, int _eletKor, int _testSuly)
        {
            this.neve = _neve;
            this.eletKor = _eletKor;
            this.testSuly = _testSuly;
        }
        private void Ugat()
        {
            Console.WriteLine("Vauvauvau");
        }
        public void Ugatas()
        {
            this.Ugat();
        }
        public void AdattagokKiiratasa()
        {
            Console.WriteLine("{2} életkora és testsúlya: {0}  - {1}", this.eletKor, this.testSuly, this.neve);
        }
    }
}
