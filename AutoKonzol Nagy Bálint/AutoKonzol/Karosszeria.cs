using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    public class Karosszeria
    {
        public int KarosszeriaID { get; set; }
        public string KarosszeriaNev { get; set; }

        public Karosszeria(int karosszeriaID, string karosszeriaNev)
        {
            KarosszeriaID = karosszeriaID;
            KarosszeriaNev = karosszeriaNev;
        }
    }
}
