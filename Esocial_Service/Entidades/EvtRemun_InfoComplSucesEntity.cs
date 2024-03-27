using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_InfoComplSucesEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        int id_infoComplem;
        string sucessaoVinc_tpInsc;
        string sucessaoVinc_nrInsc;
        string sucessaoVinc_matricAnt;
        string sucessaoVinc_dtAdm;
        string sucessaoVinc_observacao;

        public int Id
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

        public int Id_projeto
        {
            get
            {
                return id_projeto;
            }

            set
            {
                id_projeto = value;
            }
        }

        public int Id_cad_evtremun
        {
            get
            {
                return id_cad_evtremun;
            }

            set
            {
                id_cad_evtremun = value;
            }
        }

        public int Id_infoComplem
        {
            get
            {
                return id_infoComplem;
            }

            set
            {
                id_infoComplem = value;
            }
        }

        public string SucessaoVinc_tpInsc
        {
            get
            {
                return sucessaoVinc_tpInsc;
            }

            set
            {
                sucessaoVinc_tpInsc = value;
            }
        }

        public string SucessaoVinc_nrInsc
        {
            get
            {
                return sucessaoVinc_nrInsc;
            }

            set
            {
                sucessaoVinc_nrInsc = value;
            }
        }

        public string SucessaoVinc_matricAnt
        {
            get
            {
                return sucessaoVinc_matricAnt;
            }

            set
            {
                sucessaoVinc_matricAnt = value;
            }
        }

        public string SucessaoVinc_dtAdm
        {
            get
            {
                return sucessaoVinc_dtAdm;
            }

            set
            {
                sucessaoVinc_dtAdm = value;
            }
        }

        public string SucessaoVinc_observacao
        {
            get
            {
                return sucessaoVinc_observacao;
            }

            set
            {
                sucessaoVinc_observacao = value;
            }
        }
    }
}
