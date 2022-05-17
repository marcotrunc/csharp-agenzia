using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public  class Box : Immobile
    {
        private int iNumPostiAuto;
        public int PostiAuto
        {
            get { return iNumPostiAuto; }
            set { iNumPostiAuto = value; }
        }
        
        public Box(string sCodice, string sIndirizzo, string sCap, string sCitta, int iSup, int iNumPostiAuto) : base(sCodice, sIndirizzo, sCap, sCitta, iSup)
        {
            this.PostiAuto = iNumPostiAuto;
        }
        public override string ToString()
        {
            return string.Format("Box:\n{0}", Write());
        }

        public override string Write()
        {
            return string.Format("{0}\nPostiAuto: {1}", base.Write(), this.PostiAuto);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.PostiAuto.ToString().Contains(key)) return true;
            else return false;
        }
    }
}

