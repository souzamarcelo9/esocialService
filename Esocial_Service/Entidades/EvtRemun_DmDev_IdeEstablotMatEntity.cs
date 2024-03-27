using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_DmDev_IdeEstablotMatEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        int id_s_1200_dmdev;
        int id_dmdev_periodo_ideestablot;
        string remunPerApur_matricula;
        string remunPerApur_indSimples;
        int id_cadastro_envio;

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

        public int Id_dmdev_periodo_ideestablot
        {
            get
            {
                return id_dmdev_periodo_ideestablot;
            }

            set
            {
                id_dmdev_periodo_ideestablot = value;
            }
        }

        public string RemunPerApur_matricula
        {
            get
            {
                return remunPerApur_matricula;
            }

            set
            {
                remunPerApur_matricula = value;
            }
        }

        public string RemunPerApur_indSimples
        {
            get
            {
                return remunPerApur_indSimples;
            }

            set
            {
                remunPerApur_indSimples = value;
            }
        }

        public int Id_cadastro_envio
        {
            get
            {
                return id_cadastro_envio;
            }

            set
            {
                id_cadastro_envio = value;
            }
        }
    }
}
