using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Eventos
{
    public class EvtExclusao3000
    {

        private string id;

        TIdeEveFopag ideEvento;

        /// <summary>
        /// 
        /// </summary>
        TEmpregador ideEmpregador;

        TEvt1210InfoExclusao infoExclusao;

        public TEvt1210InfoExclusao InfoExclusao
        {
            get
            {
                return infoExclusao;
            }

            set
            {
                infoExclusao = value;
            }
        }

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
    }
}
