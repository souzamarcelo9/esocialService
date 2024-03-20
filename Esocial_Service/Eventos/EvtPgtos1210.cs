using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class EvtPgtos1210
    {
        private string id;

        TIdeEveFopag ideEvento;        

        /// <summary>
        /// 
        /// </summary>
        TEmpregador ideEmpregador;
        

        TEvt1210InfoInclusao infoPagto;
        

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
               this.id = value;
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
       

        public TEvt1210InfoInclusao InfoPagto
        {
            get
            {
                return this.infoPagto;
            }

            set
            {
                this.infoPagto = value;
            }
        }
    }
}
