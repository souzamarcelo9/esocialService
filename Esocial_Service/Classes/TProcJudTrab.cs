using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TProcJudTrab
    {
        sbyte tpTrib;
        string nrProcJud;
        string codSusp;

        public sbyte TpTrib
        {
            get
            {
                return tpTrib;
            }

            set
            {
                tpTrib = value;
            }
        }

        public string NrProcJud
        {
            get
            {
                return nrProcJud;
            }

            set
            {
                nrProcJud = value;
            }
        }

        public string CodSusp
        {
            get
            {
                return codSusp;
            }

            set
            {
                codSusp = value;
            }
        }
    }
}
