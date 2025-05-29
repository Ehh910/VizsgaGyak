using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendszerUzemelteto
{
    internal class Vizsgazo
    {
        public string Nev { get; set; }
        public double ItHalozat { get; set; }
        public double Progamozas { get; set; }
        public double HalozatA { get; set; }
        public double HalozatB { get; set; }
        public double HalozatC { get; set; }
        public double HalozatD { get; set; }
        public double SzobeliAngol { get; set; }
        public double SzobeliIT { get; set; }

        public Vizsgazo(string sor)
        {
            var atmeneti = sor.Split(';');
            Nev = atmeneti[0];
            ItHalozat = double.Parse(atmeneti[1]);
            Progamozas = double.Parse(atmeneti[2]);
            HalozatA = double.Parse(atmeneti[3]);
            HalozatB = double.Parse(atmeneti[4]);
            HalozatC = double.Parse(atmeneti[5]);
            HalozatD = double.Parse(atmeneti[6]);
            SzobeliAngol = double.Parse(atmeneti[7]);
            SzobeliIT = double.Parse(atmeneti[8]);

        }

        public override string ToString()
        {
            return $"{Nev}; {ItHalozat}; {Progamozas}; {HalozatA}; {HalozatB}; {HalozatC}; {HalozatD}; {SzobeliAngol}; {SzobeliIT}";
        }


        public double Vegeredmeny()
        {
            double total = ItHalozat + Progamozas + HalozatA + HalozatB + HalozatC + HalozatD + SzobeliAngol + SzobeliIT;
            double average = total / 8; 
            double percentage = Math.Round(average * 100.0);
            return percentage;
        }

        public string Erdemjegy()
        {
            if (ItHalozat < 0.51 || Progamozas < 0.51 || HalozatA < 0.51 || HalozatB < 0.51 ||
                HalozatC < 0.51 || HalozatD < 0.51 || SzobeliAngol < 0.51 || SzobeliIT < 0.51)
            {
                return "elégtelen";
            }

            double vegeredmeny = Vegeredmeny();

            if (vegeredmeny >= 81)
            {
                return "jeles"; 
            }
            else if (vegeredmeny >= 71)
            {
                return "jó"; 
            }
            else if (vegeredmeny >= 61)
            {
                return "közepes"; 
            }
            else if (vegeredmeny >= 51)
            {
                return "elégséges"; 
            }
            else
            {
                return "elégtelen"; 
            }
        }
    }
}
