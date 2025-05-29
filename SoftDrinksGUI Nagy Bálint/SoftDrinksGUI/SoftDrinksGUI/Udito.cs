using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDrinksGUI
{
    internal class Udito
    {
        public string Nev { get; set; }
        public string EdesitoNev { get; set; }
        public int ArLiterenkent { get; set; }
        public string Csomagolas { get; set; }
        public int GyumolcsTart { get; set; }
        public int CsomagolasEgysege { get; set; }
        public string Gyarto { get; set; }

        public Udito(string sor)
        {
            string[] s = sor.Split(";");
            Nev = s[0];
            EdesitoNev = s[1];
            ArLiterenkent = int.Parse(s[2]);
            Csomagolas = s[3];
            GyumolcsTart = int.Parse(s[4]);
            CsomagolasEgysege = int.Parse(s[5]);
            
            
        }

        public override string ToString()
        {
            return $"{Nev}, {EdesitoNev}, {ArLiterenkent}, {Csomagolas}, {GyumolcsTart}, {CsomagolasEgysege}";
        }
    }
}
