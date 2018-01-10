using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulokOOP
{
    class Tanulo
    {
        private string nev;
        private double atlag;
        private string szemSzam;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public double Atlag
        {
            get { return atlag; }
            set { atlag = value; }
        }

        public string SzemSzam
        {
            get { return szemSzam; }
            set { szemSzam = value; }
        }

        public Tanulo(string nev, double atlag, string szemSzam)
        {
            Nev = nev;
            Atlag = atlag;
            SzemSzam = szemSzam;
            //this.nev = nev; //Közvetlenül a változót állítjuk be
        }
    }
}
