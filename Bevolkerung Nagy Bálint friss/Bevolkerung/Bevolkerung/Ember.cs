using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevolkerung
{
    internal class Ember
    {
        public int Id { get; set; }
        public string Nem { get; set; }
        public int SzuletesiEv { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }
        public bool Dohanyzik { get; set; }
        public string Nemzetiseg { get; set; }
        public string Nepcsoport { get; set; }
        public string Tartomany { get; set; }
        public  int NettoJovedelem { get; set; }
        public string IskolaiVegzettseg { get; set; }
        public bool AktivSzavazo { get; set; }
        public int SorFogyasztasEvente { get; set; }
        public int KrumpliFogyasztasEvente { get; set; }

     
        public Ember(string sor)
        {

            var atmeneti = sor.Split(";");
            Id = Convert.ToInt32(atmeneti[0]);
            Nem = atmeneti[1];
            SzuletesiEv = Convert.ToInt32(atmeneti[2]);
            Suly = Convert.ToInt32(atmeneti[3]);
            Magassag = Convert.ToInt32(atmeneti[4]);
            Dohanyzik = Convert.ToBoolean(atmeneti[5]);
            Nemzetiseg = atmeneti[6];
            Nepcsoport = atmeneti[7];
            Tartomany = atmeneti[8];
            NettoJovedelem = Convert.ToInt32(atmeneti[9]);
            IskolaiVegzettseg = atmeneti[10];
            AktivSzavazo = Convert.ToBoolean(atmeneti[11]);
            SorFogyasztasEvente = Convert.ToInt32(atmeneti[12]);
            KrumpliFogyasztasEvente = Convert.ToInt32(atmeneti[13]);

            if(atmeneti[5] == "igen") /*segítséggel*/
            {
                Dohanyzik = true;
            }
            else
            {
               Dohanyzik = false;
            }

            if (atmeneti[11] == "igen")
            {
                AktivSzavazo = true;
            }
            else
            {
                AktivSzavazo = false;
            }

            if (atmeneti[7] == "")
            {
                Nepcsoport = "nem népcsoport tagja";
            }

            if(atmeneti[10] == "")
            {
                IskolaiVegzettseg = "nem ismert";
            }

            if (atmeneti[12] == "NA")
            {
                SorFogyasztasEvente = -1;
            }

            if (atmeneti[13] == "NA") 
            {
                KrumpliFogyasztasEvente = -1;
            
            }


        }

        public override string ToString()
        {
            return $"{Id}  {Nem}  {SzuletesiEv}  {Suly}  {Magassag}  {Dohanyzik}  {Nemzetiseg}  {Nepcsoport}  {Tartomany}  {NettoJovedelem} {IskolaiVegzettseg}  {AktivSzavazo}  {KrumpliFogyasztasEvente}";
        }
    }
}
