using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
   public class TItemRemuneracao
    {
        private string codRubrField;

        private string ideTabRubrField;

        private string qtdRubrField;

        private bool qtdRubrFieldSpecified;

        private decimal vrUnitField;

        private bool vrUnitFieldSpecified;

        private string vrRubrField;

        private sbyte indApuracaoField;

        private string fatorRubr;


        /// <remarks/>
        public string CodRubr
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
        public string IdeTabRubr
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
        public string QtdRubr
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
        public bool QtdRubrSpecified
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
        public decimal VrUnit
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
        public bool VrUnitSpecified
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
        public string VrRubr
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

        public string FatorRubr
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
