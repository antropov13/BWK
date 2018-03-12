using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWK
{
    class Kunde
    {
        private String nameKunde;

        public String NameKunde { get { return nameKunde; } set { } }

        public Kunde(String name)
        {
            this.nameKunde = name;
        }
    }
}
