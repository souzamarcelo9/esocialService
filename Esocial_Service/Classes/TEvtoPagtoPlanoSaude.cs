using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TEvtoPagtoPlanoSaude
    {
        string cnpjOper;

        string regANS;

        decimal vlrSaudeTit;

        public string CnpjOper
        {
            get
            {
                return cnpjOper;
            }

            set
            {
                cnpjOper = value;
            }
        }

        public string RegANS
        {
            get
            {
                return regANS;
            }

            set
            {
                regANS = value;
            }
        }

        public decimal VlrSaudeTit
        {
            get
            {
                return vlrSaudeTit;
            }

            set
            {
                vlrSaudeTit = value;
            }
        }
    }
}
