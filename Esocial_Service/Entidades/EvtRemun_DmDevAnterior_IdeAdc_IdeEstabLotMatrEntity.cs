using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotMatrEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        int id_s_1200_dmdev;
        int id_dmdev_anterior_ideadc;
        int id_anterior_ideadc_perref;
        int id_anterior_ideadc_idePeriodo_ideEstabLot;
        string remunPerAnt_matricula;
        string remunPerAnt_indSimples;

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

        public int Id_anterior_ideadc_perref
        {
            get
            {
                return id_anterior_ideadc_perref;
            }

            set
            {
                id_anterior_ideadc_perref = value;
            }
        }

        public int Id_anterior_ideadc_idePeriodo_ideEstabLot
        {
            get
            {
                return id_anterior_ideadc_idePeriodo_ideEstabLot;
            }

            set
            {
                id_anterior_ideadc_idePeriodo_ideEstabLot = value;
            }
        }

        public string RemunPerAnt_matricula
        {
            get
            {
                return remunPerAnt_matricula;
            }

            set
            {
                remunPerAnt_matricula = value;
            }
        }

        public string RemunPerAnt_indSimples
        {
            get
            {
                return remunPerAnt_indSimples;
            }

            set
            {
                remunPerAnt_indSimples = value;
            }
        }
    }
}
