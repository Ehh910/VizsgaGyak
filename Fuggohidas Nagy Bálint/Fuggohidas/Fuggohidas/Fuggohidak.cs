using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggohidas
{
    internal class Fuggohidak
    {
        public int Helyezes { get; set; }
        public string Hid { get; set; }
        public string Hely { get; set; }
        public string Orszag { get; set; }
        public int Hossz { get; set; }
        public int Ev { get; set; }

       public Fuggohidak(int helyezes, string hid, string hely, string orszag, int hossz, int ev)
        {
            Helyezes = helyezes;
            Hid = hid;
            Hely = hely;
            Orszag = orszag;
            Hossz = hossz;
            Ev = ev;
        }

        public static List<Fuggohidak> LoadFromCSV(string path)
        {
            List<Fuggohidak> Fuggohidaks = new List<Fuggohidak>();

            string[] temp = File.ReadAllLines(path);

            foreach (string s in temp.Skip(1)) 
            {
                string[] v = s.Split("\t");

                int Helyezes = int.Parse(v[0]);
                string Hid = v[1];
                string Hely = v[2];
                string Orszag = v[3];
                int hossz = int.Parse(v[4]);
                int ev = int.Parse(v[5]);

                Fuggohidak fuggohidak = new Fuggohidak(Helyezes, Hid, Hely, Orszag, hossz, ev);
                Fuggohidaks.Add(fuggohidak);
            
            }
            return Fuggohidaks;

        }
    }
}
