using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    public class Valto
    {
        public int ValtoID { get; set; }
        public string ValtoNev { get; set; }


        public Valto(int valtoID, string valtoNev)
        {
            this.ValtoID = valtoID;
            this.ValtoNev = valtoNev;


        }
    }

    
}
