using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_InfoComplContEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        int id_dmdev;
        string infoComplCont_codCBO;
        string infoComplCont_natAtividade;
        string infoComplCont_qtdDiasTrab;

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

        public int Id_dmdev
        {
            get
            {
                return id_dmdev;
            }

            set
            {
                id_dmdev = value;
            }
        }

        public string InfoComplCont_codCBO
        {
            get
            {
                return infoComplCont_codCBO;
            }

            set
            {
                infoComplCont_codCBO = value;
            }
        }

        public string InfoComplCont_natAtividade
        {
            get
            {
                return infoComplCont_natAtividade;
            }

            set
            {
                infoComplCont_natAtividade = value;
            }
        }

        public string InfoComplCont_qtdDiasTrab
        {
            get
            {
                return infoComplCont_qtdDiasTrab;
            }

            set
            {
                infoComplCont_qtdDiasTrab = value;
            }
        }
    }
}
