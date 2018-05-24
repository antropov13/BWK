using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWK
{
    class Fahrt
    {
        private Kunde kunde;
        private Fahrer fahrer;
        private DateTime date;
        private string referenz;
        private string fahrzeug_mz;
        private string fahrzeug_typ;
        private string abholungPLZ;
        private string abholung;
        private string zustellungPLZ;
        private string zustellung;
        private int kmFahrt;
        private float preisKmFahrt;
        private float betragFahrt;
        private float mautFahrt;
        private int kmFahrer;
        private float betragFahrer;
        private string bemerkungText;
        private float bemerkungPreis;
        private string mount;

        public Kunde Kunde { get { return kunde; } set { } }
        internal Fahrer Fahrer { get => fahrer; set => fahrer = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Referenz { get => referenz; set => referenz = value; }
        public string AbholungPLZ { get => abholungPLZ; set => abholungPLZ = value; }
        public string Abholung { get => abholung; set => abholung = value; }
        public string ZustellungPLZ { get => zustellungPLZ; set => zustellungPLZ = value; }
        public string Zustellung { get => zustellung; set => zustellung = value; }
        public int KmFahrt { get => kmFahrt; set => kmFahrt = value; }
        public float PreisKmFahrt { get => preisKmFahrt; set => preisKmFahrt = value; }
        public float BetragFahrt { get => betragFahrt; set => betragFahrt = value; }
        public float MautFahrt { get => mautFahrt; set => mautFahrt = value; }
        public int KmFahrer { get => kmFahrer; set => kmFahrer = value; }
        public float BetragFahrer { get => betragFahrer; set => betragFahrer = value; }
        public string BemerkungText { get => bemerkungText; set => bemerkungText = value; }
        public float BemerkungPreis { get => bemerkungPreis; set => bemerkungPreis = value; }
        public string Mount { get => mount; set => mount = value; }
        public string Fahrzeug_mz { get => fahrzeug_mz; set => fahrzeug_mz = value; }
        public string Fahrzeug_typ { get => fahrzeug_typ; set => fahrzeug_typ = value; }

        public Fahrt(Kunde kunde, Fahrer fahrer, DateTime date, string referenz, string fahrzeug_mz, string fahrzeug_typ, string abholungPLZ, string abholung, string zustellungPLZ, string zustellung, int kmFahrt, float preisKmFahrt, float betragFahrt, float mautFahrt, int kmFahrer, float betragFahrer, string bemerkungText, float bemerkungPreis, string mount)
        {
            this.kunde = kunde;
            this.fahrer = fahrer;
            this.date = date;
            this.referenz = referenz;
            this.fahrzeug_mz = fahrzeug_mz;
            this.fahrzeug_typ = fahrzeug_typ;
            this.abholungPLZ = abholungPLZ;
            this.abholung = abholung;
            this.zustellungPLZ = zustellungPLZ;
            this.zustellung = zustellung;
            this.kmFahrt = kmFahrt;
            this.preisKmFahrt = preisKmFahrt;
            this.betragFahrt = betragFahrt;
            this.mautFahrt = mautFahrt;
            this.kmFahrer = kmFahrer;
            this.betragFahrer = betragFahrer;
            this.bemerkungText = bemerkungText;
            this.bemerkungPreis = bemerkungPreis;
            this.mount = mount;
        }

        public Fahrt fahrt()
        {
            return this.fahrt();
        }
    }


    
}
