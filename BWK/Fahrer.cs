using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWK
{
    class Fahrer
    {
        private string name;
        private List<Fahrt> fahrten;
        private int kmColumn;
        private int betragColumn;
        private string nameFahrer;
        public string NameFahrer { get { return nameFahrer; } set { nameFahrer = value ;} }


        public Fahrer(string nameFahrer)
        {
            this.nameFahrer = nameFahrer;
        }

    }
}
