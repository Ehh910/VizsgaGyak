using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orai0116.img
{
    internal class Hajo
    {
        public Hajo(string sor)
        {
            string[] atmeneti = sor.Split(',');
            Sorszam = int.Parse(atmeneti[0]);
            Nev = atmeneti[1];
            Tipusa = atmeneti[2];
            MaxUtas = int.Parse(atmeneti[3]);
            NapiBerlesiDij = int.Parse(atmeneti[4]);
        }

        public int Sorszam { get; set; }
        public string Nev { get; set; }
        public string Tipusa { get; set; }
        public int MaxUtas { get; set; }
        public int NapiBerlesiDij { get; set; }


        public override string ToString()
        {
            return$"{Sorszam}; {Nev}; {Tipusa}; {MaxUtas}; {NapiBerlesiDij}";
        }

        public double KiszamoltErtek(double nap)
        {
            return nap * NapiBerlesiDij;
        }
    }
}
