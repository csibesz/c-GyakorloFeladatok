using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelhasznalokMasodikAB
{
    class Felhasznalo
    {
        int id;
        string felhasznaloNev;
        string jelszo;
        DateTime regisztracioIdeje;


        public int Id
        {
            get { return id; }
            set
            {
                if (id == 0)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("Az ID mező értéke módosítása sikertelen");
                }
            }
        }

        public string FelhasznaloNev
        {
            get { return felhasznaloNev; }
            set { felhasznaloNev = value; }
        }

        public string Jelszo
        {
            get { return jelszo; }
            set { jelszo = value; }
        }

        public DateTime RegisztracioIdeje
        {
            get { return regisztracioIdeje; }
            set { regisztracioIdeje = value; }
        }

        public Felhasznalo(string felhasznaloNev, string jelszo, DateTime regisztracioIdeje)
        {
            FelhasznaloNev = felhasznaloNev;
            Jelszo = jelszo;
            RegisztracioIdeje = regisztracioIdeje;
        }

        public Felhasznalo(int id, string felhasznaloNev, string jelszo, DateTime regisztracioIdeje) : this(felhasznaloNev, jelszo, regisztracioIdeje)
        {
            Id = id;
        }
    }
}
