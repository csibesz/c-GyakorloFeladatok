using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRaktar
{
    enum TejTermekTipus
    {
        Tej,
        Sajt,
        Vaj,
        Egyéb
    }

    class TejTermekek : Termekek
    {
        double zsirTartalom;

        public double ZsirTartalom
        {
            get { return zsirTartalom; }
            set { zsirTartalom = (value >= 0 && value <= 100) ? value: 0;
            }
        }

        TejTermekTipus tipus;

        internal TejTermekTipus Tipus
        {
            get { return tipus; }
            set { tipus = value; }
        }

        public TejTermekek(double zsirTartalom, TejTermekTipus tipus, string megnevezes, string cikkszam, int db, int ar) : base(megnevezes, cikkszam, db, ar)
        {
            ZsirTartalom = zsirTartalom;
            Tipus = tipus;
        }

        public override string ToString()
        {
            return base.ToString() + " (Tejtermék)";
        }
    }
}
