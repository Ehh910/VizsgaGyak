using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaKonzol
{
    internal class Fajta
    {

        public int FajtaId { get; set; }
        public string FajtaNev { get; set; }

        public Fajta(string sor)
        {
            var atmeneti = sor.Split(";");
              FajtaId = int.Parse(atmeneti[0]);
            FajtaNev = atmeneti[1];

          
        }

        
    }
}
