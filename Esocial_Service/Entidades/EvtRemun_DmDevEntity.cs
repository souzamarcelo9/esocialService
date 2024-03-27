using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_DmDevEntity
    {
        int id;
        int id_projeto;
        int id_usuario;
        int id_cad_evtremun;
        string dmDev_ideDmDev;
        string dmDev_icodCateg;
        int id_cadastro_envios;

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

        public int Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
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

        public string DmDev_ideDmDev
        {
            get
            {
                return dmDev_ideDmDev;
            }

            set
            {
                dmDev_ideDmDev = value;
            }
        }

        public string DmDev_icodCateg
        {
            get
            {
                return dmDev_icodCateg;
            }

            set
            {
                dmDev_icodCateg = value;
            }
        }

        public int Id_cadastro_envios
        {
            get
            {
                return id_cadastro_envios;
            }

            set
            {
                id_cadastro_envios = value;
            }
        }
    }
}
