using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRaktar
{
    class Pekaru : Termekek
    {
        bool teljesKiorlesu;

        public bool TeljesKiorlesu
        {
            get { return teljesKiorlesu; }
            set { teljesKiorlesu = value; }
        }

        public Pekaru(bool teljesKiorlesu, string megnevezes, string cikkszam, int db, int ar) : base(megnevezes,cikkszam,db,ar)
        {
            TeljesKiorlesu = teljesKiorlesu;
        }

        public override string ToString()
        {
            return base.ToString() + " (Pékárú)";
        }
    }
}
