using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Per gli appartamenti è 
riportato in numero di vani e il numero di bagni. */
namespace csharp_agenzia
{
    public class Appartamento : Immobile
    {
        private int iNumVani;

        public int NumVani
        {
            get { return iNumVani; }
            set { iNumVani = value; }
        }

        private int iNumBagni;
        public int NumBagni
        {
            get { return iNumBagni; }
            set { iNumBagni = value; }
        }
        public Appartamento(string sCodice, string sIndirizzo, string sCap, string sCitta, int iSup,int iNumVani,int iNumBagni) : base(sCodice, sIndirizzo, sCap, sCitta, iSup)
        {
            this.NumVani = iNumVani;
            this.NumBagni = iNumBagni;
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.NumVani.ToString().Contains(key)) return true;
            else if (this.NumBagni.ToString().Contains(key)) return true;
            else return false;
        }
        public override string ToString()
        {
            return string.Format("Appartamento:\n{0}", Write());

        }
        public override string Write()
        {
            return string.Format("{0}\nNumeroVani: {1}\nNumeroBagni: {2}", base.Write(), this.NumVani, this.NumBagni);
        }

    }
}
