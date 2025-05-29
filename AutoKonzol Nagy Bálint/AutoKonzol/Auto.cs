using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    public  class Auto
    {
        public int Azonosito { get; set; }
        public int Evjarat { get; set; }
        public Gyarto Gyarto { get; set; }
        public string Modell { get; set; }
        public int Kilometer { get; set; }
        public Karosszeria Karosszeria { get; set; }
        public int Hengerek { get; set; }
        public Valto Valto { get; set; }
        public string KulsoSzin { get; set; }
        public string BelsoSzin { get; set; }
        public int SzemelyekSzama { get; set; }
        public int Ajtok { get; set; }
        public double VarosiFogy { get; set; }
        public double AutoPalyaFogy { get; set; }
        public int VetelAr { get; set; }

        public Auto(int azonosito, int evjarat, Gyarto gyarto, string modell, int kilometer, Karosszeria karosszeria, int hengerek, Valto valto, string kulsoSzin, string belsoSzin, int szemelyekSzama, int ajtok, double varosiFogy, double autoPalyaFogy, int vetelAr)
        {
            Azonosito = azonosito;
            Evjarat = evjarat;
            Gyarto = gyarto;
            Modell = modell;
            Kilometer = kilometer;
            Karosszeria = karosszeria;
            Hengerek = hengerek;
            Valto = valto;
            KulsoSzin = kulsoSzin;
            BelsoSzin = belsoSzin;
            SzemelyekSzama = szemelyekSzama;
            Ajtok = ajtok;
            VarosiFogy = varosiFogy;
            AutoPalyaFogy = autoPalyaFogy;
            VetelAr = vetelAr;
        }

        public static List<Auto> LoadFromCsv(string path)
        {
            List<Auto> Autok = new List<Auto>();
            string[] temp = File.ReadAllLines(path);
           
            foreach (string t in temp.Skip(1))
            {
                string[] v = t.Split(';');

                int Azonosito = int.Parse(v[0]);
                int Evjarat = int.Parse((string)v[1]);
                Gyarto Gyarto = new Gyarto(int.Parse(v[2]), v[3]);
                string Modell = v[4];
                int Kilometer = int.Parse(v[5]);
                Karosszeria karosszeria = new Karosszeria(int.Parse(v[6]), v[7]);
                int Hengerek = int.Parse(v[8]);
                Valto Valto = new Valto(int.Parse(v[9]), v[10]);
                string KulsoSzin = v[11];
                string BelsoSzin = v[12];
                int SzemelyekSzama = int.Parse(v[13]);
                int Ajtok = int.Parse(v[14]);
                double VaroisFogy = double.Parse(v[15]);
                double AutoPalyaFogy = double.Parse(v[16]);
                int VetelAr = int.Parse(v[17]);

                Auto autok = new Auto(Azonosito, Evjarat, Gyarto, Modell, Kilometer, karosszeria, Hengerek, Valto, KulsoSzin, BelsoSzin, SzemelyekSzama, Ajtok, VaroisFogy, AutoPalyaFogy, VetelAr);

                Autok.Add(autok);
            
            }
            return Autok;

          
        }

        public override string ToString()
        {
            return $"Gyártó - modell: {Gyarto.GyartoNev} - {Modell} \n Fogyasztás: {Math.Round(VarosiFogy/AutoPalyaFogy * 100) ,2} \n Kilométeróra állása: {Kilometer} \n Váltó Típusa: {Valto.ValtoNev} \n Ára (CAD): {VetelAr} ";
        }
    }
}
