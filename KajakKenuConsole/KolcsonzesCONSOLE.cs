using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KajakKenuConsole
{
    internal class KolcsonzesCONSOLE
    {
        public string Nev { get; set; }
        public int Azonosito { get; set; }
        public string Tipus { get; set; }
        public int SzemelySzam { get; set; }
        public int ElvitelOra { get; set; }
        public int ElvitelPerc { get; set; }
        public int VisszaOra { get; set; }
        public int VisszaPerc { get; set; }

        public KolcsonzesCONSOLE(string sor)
        {
            var atmeneti = sor.Split(';');
            Nev = atmeneti[0];
            Azonosito = int.Parse(atmeneti[1]);
            Tipus = atmeneti[2];
            SzemelySzam = int.Parse(atmeneti[3]);
            ElvitelOra = int.Parse(atmeneti[4]);
            ElvitelPerc = int.Parse(atmeneti[5]);
            VisszaOra = int.Parse(atmeneti[6]);
            VisszaPerc = int.Parse(atmeneti[7]);
        }

    }
}
