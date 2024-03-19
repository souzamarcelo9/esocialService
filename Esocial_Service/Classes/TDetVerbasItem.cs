using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
   public class TDetVerbasItem
    {
        private string codRubrField;

        private string ideTabRubrField;

        private decimal qtdRubrField;

        private bool qtdRubrFieldSpecified;

        private decimal vrUnitField;

        private bool vrUnitFieldSpecified;

        private decimal vrRubrField;

        private sbyte indApuracaoField;

        private decimal fatorRubr;


        /// <remarks/>
        public string codRubr
        {
            get
            {
                return this.codRubrField;
            }
            set
            {
                this.codRubrField = value;
            }
        }

        /// <remarks/>
        public string ideTabRubr
        {
            get
            {
                return this.ideTabRubrField;
            }
            set
            {
                this.ideTabRubrField = value;
            }
        }

        /// <remarks/>
        public decimal qtdRubr
        {
            get
            {
                return this.qtdRubrField;
            }
            set
            {
                this.qtdRubrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool qtdRubrSpecified
        {
            get
            {
                return this.qtdRubrFieldSpecified;
            }
            set
            {
                this.qtdRubrFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal vrUnit
        {
            get
            {
                return this.vrUnitField;
            }
            set
            {
                this.vrUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vrUnitSpecified
        {
            get
            {
                return this.vrUnitFieldSpecified;
            }
            set
            {
                this.vrUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal vrRubr
        {
            get
            {
                return this.vrRubrField;
            }
            set
            {
                this.vrRubrField = value;
            }
        }

        public sbyte IndApuracaoField
        {
            get
            {
                return indApuracaoField;
            }

            set
            {
                indApuracaoField = value;
            }
        }

        public decimal FatorRubr
        {
            get
            {
                return fatorRubr;
            }

            set
            {
                fatorRubr = value;
            }
        }
    }
}
