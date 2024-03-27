using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_DmDevAntPerRefEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        int id_s_1200_dmdev;
        int id_dmdev_anterior_ideadc;
        string idePeriodo_perRef;

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

        public int Id_s_1200_dmdev
        {
            get
            {
                return id_s_1200_dmdev;
            }

            set
            {
                id_s_1200_dmdev = value;
            }
        }

        public int Id_dmdev_anterior_ideadc
        {
            get
            {
                return id_dmdev_anterior_ideadc;
            }

            set
            {
                id_dmdev_anterior_ideadc = value;
            }
        }

        public string IdePeriodo_perRef
        {
            get
            {
                return idePeriodo_perRef;
            }

            set
            {
                idePeriodo_perRef = value;
            }
        }
    }
}
