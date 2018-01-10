using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulokJegyeikkel
{
    class Tanulo
    {
        string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = (value.Length >= 3) ? value : "N/A"; }
        }

        byte[] jegyek;

        public byte[] Jegyek
        {
            get { return jegyek; }
        }

        int i;

        public Tanulo(string nev)
        {
            Nev = nev;
            jegyek = new byte[50];
            i = 0;
        }

        public string JegyekSzovegesen()
        {
            string szoveg = "";
            for (int i = 0; i < this.i; i++)
            {
                szoveg += jegyek[i] + "; ";
            }
            return szoveg;
        }

        public void UjJegy(byte jegy)
        {
            if( i < 50 && jegy > 0 && jegy < 6)
            {
                jegyek[i] = jegy;
                i++;
            }
        }

        public override string ToString()
        {
            return nev;
        }
    }
}
