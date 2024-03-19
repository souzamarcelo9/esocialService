using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class TEmpregador
    {
        private sbyte tpInscField;

        private string nrInscField;

        /// <remarks/>
        public sbyte tpInsc
        {
            get
            {
                return this.tpInscField;
            }
            set
            {
                this.tpInscField = value;
            }
        }

        /// <remarks/>
        public string nrInsc
        {
            get
            {
                return this.nrInscField;
            }
            set
            {
                this.nrInscField = value;
            }
        }
    }
}
