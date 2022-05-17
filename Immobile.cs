using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Gli immobili sono caratterizzati da:
-un codice alfanumerico,
- indirizzo,
- cap,
- città 
- una superficie espressa in mq attraverso un numero intero.*/ 

namespace csharp_agenzia
{
    public class Immobile
    {
        private string sCodice;
        public string Codice
        {
            get { return sCodice; }
            set { sCodice = value; }
        }
        private string sIndirizzo;
        public string Indirizzo
        {
            get { return sIndirizzo; }
            set { sIndirizzo = value; }
        }
        private string sCap;
        public string Cap
        {
            get { return sCap; }
            set { sCap = value; }
        }
        private string sCitta;
        public string Citta
        {
            get { return sCitta; }
            set { sCitta = value; }
        }
        private int iSup;

        public int Sup
        {
            get { return iSup; }
            set { iSup = value; }
        }

        public  Immobile(string sCodice, string sIndirizzo, string sCap, string sCitta, int iSup)
        {
            this.Codice = sCodice;
            this.Indirizzo = sIndirizzo;
            this.Cap = sCap;
            this.Citta = sCitta;
            this.Sup= iSup;

        }
        public override string ToString()
        {
            return string.Format("Immobile:\n{0}", Write());

        }
        public virtual string Write()
        {
            return string.Format("Codice : {0}\nIndirizzo : {1}\nCap : {2}\nCitta : {3}\nSup {4}",
                                            this.Codice,
                                            this.Indirizzo,
                                            this.Cap,
                                            this.Citta,
                                            this.Sup);
        }

        public virtual bool Contains(string key)
        {
            if (this.Codice.Contains(key)) return true;
            else if (this.Indirizzo.Contains(key)) return true;
            else if (this.Cap.Contains(key)) return true;
            else if (this.Citta.Contains(key)) return true;
            else if(this.Sup.ToString().Contains(key)) return true;
            else return false;
        }
    }
}
