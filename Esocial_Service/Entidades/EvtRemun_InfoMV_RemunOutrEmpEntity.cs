using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_InfoMV_RemunOutrEmpEntity
    {
        int id;
        int id_projeto;
        int id_usuario;
        int id_cad_evtremun;
        int id_infoMV;
        string remunOutrEmpr_tpInsc;
        string remunOutrEmpr_nrInsc;
        string remunOutrEmpr_codCateg;
        Decimal remunOutrEmpr_vlrRemunOE;

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

        public int Id_infoMV
        {
            get
            {
                return id_infoMV;
            }

            set
            {
                id_infoMV = value;
            }
        }

        public string RemunOutrEmpr_tpInsc
        {
            get
            {
                return remunOutrEmpr_tpInsc;
            }

            set
            {
                remunOutrEmpr_tpInsc = value;
            }
        }

        public string RemunOutrEmpr_nrInsc
        {
            get
            {
                return remunOutrEmpr_nrInsc;
            }

            set
            {
                remunOutrEmpr_nrInsc = value;
            }
        }

        public string RemunOutrEmpr_codCateg
        {
            get
            {
                return remunOutrEmpr_codCateg;
            }

            set
            {
                remunOutrEmpr_codCateg = value;
            }
        }

        public Decimal RemunOutrEmpr_vlrRemunOE
        {
            get
            {
                return remunOutrEmpr_vlrRemunOE;
            }

            set
            {
                remunOutrEmpr_vlrRemunOE = value;
            }
        }


    }
}
