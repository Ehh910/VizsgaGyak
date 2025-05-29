using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaKonzol
{
    internal class Kutya
    {

        public DateTime ChipDatum { get; private set; }
        public Fajta Fajta { get; private set; }
        public Gazda Gazda { get; private set; }
        public int Id { get; private set; }
        public bool Kan { get; private set; }
        public string KepUrl { get; private set; }
        public int Kor { get; private set; }
        public string Nev { get; private set; }

       public Kutya(string sor)
        {
           var atmeneti = sor.Split(";");
            ChipDatum = Convert.ToDateTime(atmeneti[0]);
            Id = int.Parse(atmeneti[1]);
            Kan = Convert.ToBoolean(atmeneti[2]);
            KepUrl = atmeneti[3];
            Kor = int.Parse(atmeneti[4]);
            Nev = atmeneti[5];
        }

        public override string ToString()
        {
            return $"ID: {Id}\nNév: {Nev}\nKan: {(Kan ? "Igen" : "Nem")}\nKor: {Kor}\nChip Dátum: {ChipDatum.Date}\nKép URL: {KepUrl}\nFajta: {Fajta.FajtaNev}\nGazda neve: {Gazda.Nev}\n";
        }

      //static void LoadFromCSV()
      //  {
      //      List<Kutya> Kutyak = new List<Kutya>();
      //      foreach (var item in File.ReadAllLines(@"..\..\..\src\adatok.csv").Skip(1))
      //      {
      //          Kutyak.Add(new Kutya(item));
      //      }
      //  }
    }
}
