using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_InfoIntermEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        string infoInterm_dia;

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

        public string InfoInterm_dia
        {
            get
            {
                return infoInterm_dia;
            }

            set
            {
                infoInterm_dia = value;
            }
        }
    }
}
