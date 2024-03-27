using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class EvtRemun1200
    {
        private int idProjeto;

        private string id;

        TIdeEveFopag ideEvento;        

        /// <summary>
        /// 
        /// </summary>
        TEmpregador ideEmpregador;
        IdeTrabalhador ideTrabalhador;
       
        List<DmDev> dmDev;

        //TInfoPerApuracao infoPerApur;

        //TInfoPerAnt infoPerAnt;

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

        public List<DmDev> DmDev
        {
            get
            {
                return dmDev;
            }

            set
            {
                dmDev = value;
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

        public int IdProjeto
        {
            get
            {
                return idProjeto;
            }

            set
            {
                idProjeto = value;
            }
        }

        //public TInfoPerAnt InfoPerApur
        //{
        //    get
        //    {
        //        return infoPerApur;
        //    }

        //    set
        //    {
        //        infoPerApur = value;
        //    }
        //}

        //public TInfoPerAnt InfoPerAnt
        //{
        //    get
        //    {
        //        return infoPerAnt;
        //    }

        //    set
        //    {
        //        infoPerAnt = value;
        //    }
        //}
    }
}
