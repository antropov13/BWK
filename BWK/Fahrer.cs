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
        private List<Fahrt> fahrten = new List<Fahrt>();
        private int kmColumn;
        private int betragColumn;
        private string nameFahrer;
        public string NameFahrer { get { return nameFahrer; } set { nameFahrer = value ;} }
        public List<Fahrt> Fahrten { get { return fahrten; } set {} }


        public Fahrer(string nameFahrer)
        {
            this.nameFahrer = nameFahrer;
        }

        public void AddFahrt(Fahrt fahrt)
        {
            this.fahrten.Add(fahrt);
        }

    }
}
