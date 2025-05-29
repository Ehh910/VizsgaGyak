using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    public class Gyarto
    {
        public int GyartoID { get; set; }
        public string GyartoNev { get; set; }

        public Gyarto(int gyartoID, string gyartoNev)
        {
            GyartoID = gyartoID;
            GyartoNev = gyartoNev;
        }
    }
}
