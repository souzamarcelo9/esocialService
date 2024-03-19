using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class EvtPgtosIdeBenefInfoPgtoDetPgtoFl
    {
        private string perRefField;

        private string ideRecPgtoField;

        private decimal vlrPgtoField;

        /// <remarks/>
        public string perRef
        {
            get
            {
                return this.perRefField;
            }
            set
            {
                this.perRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ideRecPgto
        {
            get
            {
                return this.ideRecPgtoField;
            }
            set
            {
                this.ideRecPgtoField = value;
            }
        }

        /// <remarks/>
        public decimal vlrPgto
        {
            get
            {
                return this.vlrPgtoField;
            }
            set
            {
                this.vlrPgtoField = value;
            }
        }
    }
}
