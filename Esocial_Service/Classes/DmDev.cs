using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class DmDev
    {
        private string ideDmDev;

        private string codCategField;

        private TInfoPerApuracao infoPerApur;

        private TInfoPerAnt infoPerAnt;

        private TInfoComplCont infoComplCont;
        

        public string IdeDmDev
        {
            get
            {
                return ideDmDev;
            }

            set
            {
                ideDmDev = value;
            }
        }

        public string CodCategField
        {
            get
            {
                return codCategField;
            }

            set
            {
                codCategField = value;
            }
        }        

        public TInfoPerApuracao InfoPerApur
        {
            get
            {
                return infoPerApur;
            }

            set
            {
                infoPerApur = value;
            }
        }

        public TInfoPerAnt InfoPerAnt
        {
            get
            {
                return infoPerAnt;
            }

            set
            {
                infoPerAnt = value;
            }
        }

        public TInfoComplCont InfoComplCont
        {
            get
            {
                return infoComplCont;
            }

            set
            {
                infoComplCont = value;
            }
        }
    }
}
