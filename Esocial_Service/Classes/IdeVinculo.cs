using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class IdeVinculo
    {       

            private string cpfTrabField;

            private string matriculaField;           

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

        public string Matricula
        {
            get
            {
                return matriculaField;
            }

            set
            {
                matriculaField = value;
            }
        }
    }
}
