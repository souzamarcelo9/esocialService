using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class IdeEstabLot
    {
        private sbyte tpInscField;

        private string nrInscField;

        private string codLotacaoField;

        private RemunPeriodoApuracao remunPerApuracao;
       

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

        /// <remarks/>
        public string codLotacao
        {
            get
            {
                return this.codLotacaoField;
            }
            set
            {
                this.codLotacaoField = value;
            }
        }

        public RemunPeriodoApuracao RemunPerApuracao
        {
            get
            {
                return remunPerApuracao;
            }

            set
            {
                remunPerApuracao = value;
            }
        }
    }
}
