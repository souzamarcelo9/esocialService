using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class IdeTrabalhador
    {       

            private string cpfTrabField;

            private string nisTrabField;           

            /// <remarks/>
            public string CpfTrabField
            {
                get
                {
                    return this.cpfTrabField;
                }
                set
                {
                    this.cpfTrabField = value;
                }
            }

        public string NisTrabField
        {
            get
            {
                return nisTrabField;
            }

            set
            {
                nisTrabField = value;
            }
        }
    }
}
