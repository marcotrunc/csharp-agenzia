using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Per le ville è previsto, 
in aggiunta rispetto all’appartamento, la dimensione in mq di giardino. */
namespace csharp_agenzia
{
    public class Villa : Appartamento
    {
        private int iDimensioneGiardino;

        public int DimensioneGiardino
        {
            get { return iDimensioneGiardino; }
            set { iDimensioneGiardino = value; }
        }

        public Villa(string sCodice, string sIndirizzo, string sCap, string sCitta, int iSup, int iNumVani, int iNumBagni, int iDimesioneGiardino) : base (sCodice, sIndirizzo, sCap, sCitta, iSup, iNumVani, iNumBagni)
        {
            this.DimensioneGiardino= iDimesioneGiardino;
        }

        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.DimensioneGiardino.ToString().Contains(key)) return true;
            else return false;
        }
        public override string ToString()
        {
            return string.Format("Villa:\n{0}", Write());

        }
        public override string Write()
        {
            return string.Format("{0}\nDimensioneGiardino: {1}", base.Write(), this.DimensioneGiardino);
        }
    }
}
