using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haromszogek
{
    //1.2 feladat
    public class DHaromszog
    {
        #region Fields / Értékek
        private double aOldal;
        private double bOldal;
        private double cOldal;
        #endregion

        //1.3. feladat: Osztály Konstruktor
        public DHaromszog(string sor, int sorSzáma)
        {
            string[] tomb = sor.Split(' ');

            this.a = double.Parse(tomb[0]);
            this.b = double.Parse(tomb[1]);
            this.c = double.Parse(tomb[2]);

            this.SorSzama = sorSzáma;

            if(!this.EllNovekvoSorrend)
            {
                throw new Exception(this.SorSzama + ".sor: Az adatok nincsenek növekvő sorrendben!");
            }

            if (!this.EllDerekszogu)
            {
                throw new Exception(this.SorSzama + ".sor: A háromszög nem derékszögű!");
            }

            if (!this.EllMegszerkesztheto)
            {
                throw new Exception(this.SorSzama + ".sor: A háromszöget nem lehet megszerkeszteni!");
            }
            
        }

        #region Properties / Tulajdonságok
        //1.4 feladat
        public double a
        {
            get { return aOldal; }
            set
            {
                if (value > 0)
                {
                    aOldal = value;
                }
                else
                {
                    throw new Exception(this.SorSzama + ".sor: A(z) a oldal nem lehet nulla vagy negítív!");
                }
            }
        }
        //1.4 feladat
        public double b
        {
            get { return bOldal; }
            set
            {
                if (value > 0)
                {
                    bOldal = value;
                }
                else
                {
                    throw new Exception(this.SorSzama + ".sor: A(z) b oldal nem lehet nulla vagy negítív!");
                }
            }
        }
        //1.4 feladat
        public double c
        {
            get { return cOldal; }
            set
            {
                if (value > 0)
                {
                    cOldal = value;
                }
                else
                {
                    throw new Exception(this.SorSzama + ".sor: A(z) c oldal nem lehet nulla vagy negítív!");
                }
            }
        }
        //1.3 feladat
        private bool EllDerekszogu
        {
            get
            {
                double c2 = Math.Pow(c, 2);
                double ab2 = Math.Pow(a, 2) + Math.Pow(b, 2);
                if (c2 == ab2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //1.3 feladat
        private bool EllMegszerkesztheto
        {
            get
            {
                if (c < a + b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //1.3 feladat
        private bool EllNovekvoSorrend
        {
            get
            {
                if (a<=b && b<=c)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //1.5 feladat
        public double Kerulet
        {
            get
            {
                return (a + b + c);
            }
        }

        //1.5 feladat
        public double Terulet
        {
            get
            {
                return (a * b / 2);
            }
        }

        public int SorSzama { get; set; }
        #endregion

        //1.9 feladat
        public override string ToString()
        {
            return this.SorSzama + ".sor: a=" + this.a + " b=" + this.b + " c=" + this.c; 
        }
    }
}
