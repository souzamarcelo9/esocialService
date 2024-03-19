using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TIdeEveFopag
    {
        private sbyte indRetifField;

        private string nrReciboField;

        private sbyte indApuracaoField;

        private string perApurField;

        private sbyte tpAmbField;

        private sbyte procEmiField;

        private string verProcField;

        /// <remarks/>
        public sbyte indRetif
        {
            get
            {
                return this.indRetifField;
            }
            set
            {
                this.indRetifField = value;
            }
        }

        /// <remarks/>
        public string nrRecibo
        {
            get
            {
                return this.nrReciboField;
            }
            set
            {
                this.nrReciboField = value;
            }
        }

        /// <remarks/>
        public sbyte indApuracao
        {
            get
            {
                return this.indApuracaoField;
            }
            set
            {
                this.indApuracaoField = value;
            }
        }

        /// <remarks/>
        public string perApur
        {
            get
            {
                return this.perApurField;
            }
            set
            {
                this.perApurField = value;
            }
        }

        /// <remarks/>
        public sbyte tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public sbyte procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
            }
        }

        /// <remarks/>
        public string verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }
    }
}
