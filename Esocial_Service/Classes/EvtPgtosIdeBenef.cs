using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
   public  class EvtPgtosIdeBenef
   {
       public string cpfBenefField;

       List<EvtPgtosIdeBenefInfoPgto> infoPgtoField;

       List<EvtoPagtoInfoIRComplem> infoIRComplem;

        /// <remarks/>
        public string cpfBenef
        {
            get
            {
                return this.cpfBenefField;
            }
            set
            {
                this.cpfBenefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infoPgto")]
        public List<EvtPgtosIdeBenefInfoPgto> InfoPgto
        {
            get
            {
                return this.infoPgtoField;
            }
            set
            {
                this.infoPgtoField = value;
            }
        }

        public List<EvtoPagtoInfoIRComplem> InfoIRComplem
        {
            get
            {
                return infoIRComplem;
            }

            set
            {
                infoIRComplem = value;
            }
        }
    }
}
