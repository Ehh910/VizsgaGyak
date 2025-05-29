using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaKonzol
{
    internal class Gazda
    {

        public int Id { get; private set; }
        public string Nev { get; private set; }
        public string Tel { get; private set; }

        public Gazda(string sor)
        {
            var atmeneti = sor.Split(";");
            Id = int.Parse(atmeneti[0]);
            Nev = atmeneti[1];
            Tel = atmeneti[2];
        
        }

    }
}
