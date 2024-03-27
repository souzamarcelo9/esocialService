using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;
using Esocial_Service.Database;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_InfoMVEntity
    {
        int id;
        int id_projeto;
        int id_usuario;
        int id_cad_evtremun;
        string infoMV_indMV;

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

        public string InfoMV_indMV
        {
            get
            {
                return infoMV_indMV;
            }

            set
            {
                infoMV_indMV = value;
            }
        }
    }
}
