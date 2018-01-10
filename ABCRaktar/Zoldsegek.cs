using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRaktar
{
    class Zoldsegek : Termekek
    {
        bool gyumolcs;

        public bool Gyumolcs
        {
            get { return gyumolcs; }
            set { gyumolcs = value; }
        }

        public Zoldsegek(bool gyumolcs, string megnevezes, string cikkszam, int db, int ar) : base(megnevezes, cikkszam, db, ar)
        {
            Gyumolcs = gyumolcs;
        }

        public override string ToString()
        {
            return base.ToString() + " (Zöldségek)";
        }
    }
}
