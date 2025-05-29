using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes
{
    internal class Sportolo
    {
        public int Helyezes { get; set; }
        public double Eredmeny { get; set; }
        public string Nev { get; set; }
        public string OrszagKod { get; set; }
        public string Helyszin { get; set; }
        public DateOnly Datum { get; set; }

        public Sportolo(string sor)
        {
            var atmeneti = sor.Split(';');
            Helyezes = int.Parse(atmeneti[0]);
            Eredmeny = double.Parse(atmeneti[1]);
            Nev = atmeneti[2];
            OrszagKod = atmeneti[3];
            Helyszin = atmeneti[4];
            Datum = DateOnly.Parse(atmeneti[5]);
        }

        public override string ToString()
        {
            return $"{Helyezes}, {Eredmeny}, {Nev}, {OrszagKod}, {Helyszin}, {Datum}";
        }

    }
}
