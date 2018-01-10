using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRaktar
{
    class Termekek
    {
        string megnevezes;

        public string Megnevezes
        {
            get { return megnevezes; }
            set { megnevezes = value; }
        }

        string cikkszam;

        public string Cikkszam
        {
            get { return cikkszam; }
            set { cikkszam = value; }
        }

        int db;

        public int Db
        {
            get { return db; }
            set { db = (value >= 0 && value <= 10000) ? value : db; }
            //Készletnyilvántartás esetén, user error miatt érdemes beállítani, a minimum és a maximum értéket
        }

        int ar;

        public int Ar
        {
            get { return ar; }
            set { ar = (value > 0) ? value : 1; }
        }

        public Termekek(string megnevezes, string cikkszam, int db, int ar)
        {
            Megnevezes = megnevezes;
            Cikkszam = cikkszam;
            Db = db;
            Ar = ar;
        }

        public override string ToString()
        {
            //return base.ToString();
            return cikkszam + " - " + megnevezes;
        }
    }
}
