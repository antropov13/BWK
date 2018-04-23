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
        private string fahrzeug;
        private string abholung;
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
        public string Fahrzeug { get => fahrzeug; set => fahrzeug = value; }
        public string Abholung { get => abholung; set => abholung = value; }
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

        public Fahrt(Kunde kunde, Fahrer fahrer, DateTime date, string referenz, string fahrzeug, string abholung, string zustellung, int kmFahrt, float preisKmFahrt, float betragFahrt, float mautFahrt, int kmFahrer, float betragFahrer, string bemerkungText, float bemerkungPreis, string mount)
        {
            this.kunde = kunde;
            this.fahrer = fahrer;
            this.date = date;
            this.referenz = referenz;
            this.fahrzeug = fahrzeug;
            this.abholung = abholung;
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
