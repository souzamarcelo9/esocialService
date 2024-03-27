using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_ProcJudEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        string procJudTrab_tpTrib;
        string procJudTrab_nrProcJud;
        string procJudTrab_codSusp;

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

        public string ProcJudTrab_tpTrib
        {
            get
            {
                return procJudTrab_tpTrib;
            }

            set
            {
                procJudTrab_tpTrib = value;
            }
        }

        public string ProcJudTrab_nrProcJud
        {
            get
            {
                return procJudTrab_nrProcJud;
            }

            set
            {
                procJudTrab_nrProcJud = value;
            }
        }

        public string ProcJudTrab_codSusp
        {
            get
            {
                return procJudTrab_codSusp;
            }

            set
            {
                procJudTrab_codSusp = value;
            }
        }
    }
}
