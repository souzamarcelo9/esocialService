using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Eventos
{
    public class EvtDeslig2299
    {
        private string id;

        TIdeEveFopag ideEvento;

        /// <summary>
        /// 
        /// </summary>
        TEmpregador ideEmpregador;

        IdeVinculo ideVinculo;

        TInfoDeslig infoDeslig;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public TIdeEveFopag IdeEvento
        {
            get
            {
                return ideEvento;
            }

            set
            {
                ideEvento = value;
            }
        }

        public TEmpregador IdeEmpregador
        {
            get
            {
                return ideEmpregador;
            }

            set
            {
                ideEmpregador = value;
            }
        }

        public IdeVinculo IdeVinculo
        {
            get
            {
                return ideVinculo;
            }

            set
            {
                ideVinculo = value;
            }
        }

        public TInfoDeslig InfoDeslig
        {
            get
            {
                return infoDeslig;
            }

            set
            {
                infoDeslig = value;
            }
        }
    }
}
