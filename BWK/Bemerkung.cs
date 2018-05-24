using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWK
{
    class Bemerkung
    {
        private String typ;
        private float preis;

        public string Typ { get => typ; set => typ = value; }
        public float Preis { get => preis; set => preis = value; }

        public Bemerkung(string typ, float preis)
        {
            this.typ = typ;
            this.preis = preis;

        }
    }
}
