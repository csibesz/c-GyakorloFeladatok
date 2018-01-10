using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FelhasznalokMasodikAB
{
    static class session
    {
        static Felhasznalo jelenlegiFelhasznalo;

        internal static Felhasznalo JelenlegiFelhasznalo
        {
            get { return jelenlegiFelhasznalo; }
            set { jelenlegiFelhasznalo = value; }
        }

        public static string SHA1(string text)
        {
            return BitConverter.ToString(new SHA1CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(text))).Replace("-","").ToLower();
        }
    }
}
