using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class EvtPgtosIdeBenefInfoPgto
    {
        private string dtPgtoField;

       // private eSocialEvtPgtosIdeBenefInfoPgtoIndResBr indResBrField;

        private sbyte tpPgtoField;        

        private EvtPgtosIdeBenefInfoPgtoDetPgtoFl detPgtoFlField;

        //private eSocialEvtPgtosIdeBenefInfoPgtoDetPgtoResc[] detPgtoRescField;

       // private TEndExteriortFiscal idePgtoExtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public string DtPgto
        {
            get
            {
                return this.dtPgtoField;
            }
            set
            {
                this.dtPgtoField = value;
            }
        }

        /// <remarks/>
        //public eSocialEvtPgtosIdeBenefInfoPgtoIndResBr indResBr
        //{
        //    get
        //    {
        //        return this.indResBrField;
        //    }
        //    set
        //    {
        //        this.indResBrField = value;
        //    }
        //}

        /// <remarks/>
        public sbyte TpPgto
        {
            get
            {
                return this.tpPgtoField;
            }
            set
            {
                this.tpPgtoField = value;
            }
        }



        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("detPgtoFl")]
        public EvtPgtosIdeBenefInfoPgtoDetPgtoFl DetPgtoFl
        {
            get
            {
                return this.detPgtoFlField;
            }
            set
            {
                this.detPgtoFlField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("detPgtoResc")]
        //public eSocialEvtPgtosIdeBenefInfoPgtoDetPgtoResc[] detPgtoResc
        //{
        //    get
        //    {
        //        return this.detPgtoRescField;
        //    }
        //    set
        //    {
        //        this.detPgtoRescField = value;
        //    }
        //}

        /// <remarks/>
        //public TEndExteriortFiscal idePgtoExt
        //{
        //    get
        //    {
        //        return this.idePgtoExtField;
        //    }
        //    set
        //    {
        //        this.idePgtoExtField = value;
        //    }
        //}
    }
}
