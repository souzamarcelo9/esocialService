using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_InfoComplEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        string infoComplem_nmTrab;
        string infoComplem_dtNascto;

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

        public string InfoComplem_nmTrab
        {
            get
            {
                return infoComplem_nmTrab;
            }

            set
            {
                infoComplem_nmTrab = value;
            }
        }

        public string InfoComplem_dtNascto
        {
            get
            {
                return infoComplem_dtNascto;
            }

            set
            {
                infoComplem_dtNascto = value;
            }
        }
    }
}
