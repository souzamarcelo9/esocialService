using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TEvt1210InfoExclusao
    {
        private string tpEventoField;

        private string nrRecEvtField;

        IdeTrabalhador ideTrabalhador;

        IdeFolhaPagto ideFolhaPagto;

        public string TpEventoField
        {
            get
            {
                return tpEventoField;
            }

            set
            {
                tpEventoField = value;
            }
        }

        public string NrRecEvtField
        {
            get
            {
                return nrRecEvtField;
            }

            set
            {
                nrRecEvtField = value;
            }
        }

        public IdeTrabalhador IdeTrabalhador
        {
            get
            {
                return ideTrabalhador;
            }

            set
            {
                ideTrabalhador = value;
            }
        }

        public IdeFolhaPagto IdeFolhaPagto
        {
            get
            {
                return ideFolhaPagto;
            }

            set
            {
                ideFolhaPagto = value;
            }
        }
    }
}
