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

        private string qtdDiasAv;

        private RemunPeriodoApuracao remunPerApuracao;

        private RemunPeriodoAnterior remunPerAnt;


        /// <remarks/>
        public sbyte TpInsc
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
        public string NrInsc
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
        public string CodLotacao
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

        public string QtdDiasAv
        {
            get
            {
                return qtdDiasAv;
            }

            set
            {
                qtdDiasAv = value;
            }
        }

        public RemunPeriodoAnterior RemunPerAnt
        {
            get
            {
                return remunPerAnt;
            }

            set
            {
                remunPerAnt = value;
            }
        }
    }
}
