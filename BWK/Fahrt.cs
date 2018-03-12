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
        private Dictionary<string, string> fahrzeug = new Dictionary<string, string>();
        private Dictionary<string, string> abholung = new Dictionary<string, string>();
        private Dictionary<string, string> zustellung = new Dictionary<string, string>();
        private int kmFahrt;
        private float preisKmFahrt;
        private float betragFahrt;
        private float mautFahrt;
        private int kmFahrer;
        private float betragFahrer;
        private Dictionary<string, float> bemerkung = new Dictionary<string, float>();

        public Kunde Kunde { get { return kunde; } set { } }

        public Fahrt(Kunde kunde, Fahrer fahrer, DateTime date, string referenz, Dictionary<string, string> fahrzeug, Dictionary<string, string> abholung, Dictionary<string, string> zustellung, int kmFahrt, float preisKmFahrt, float betragFahrt, float mautFahrt, int kmFahrer, float betragFahrer, Dictionary<string, float> bemerkung)
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
            this.bemerkung = bemerkung;
        }

        public Fahrt fahrt()
        {
            return this.fahrt();
        }
    }


    
}
