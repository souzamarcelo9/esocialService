using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        int id_s_1200_dmdev;
        int id_dmdev_anterior_ideadc;
        int id_anterior_ideadc_perref;
        string anterior_ideEstabLot_tpInsc;
        string anterior_ideEstabLot_nrInsc;
        string anterior_ideEstabLot_codLotacao;

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

        public string Anterior_ideEstabLot_tpInsc
        {
            get
            {
                return anterior_ideEstabLot_tpInsc;
            }

            set
            {
                anterior_ideEstabLot_tpInsc = value;
            }
        }

        public string Anterior_ideEstabLot_nrInsc
        {
            get
            {
                return anterior_ideEstabLot_nrInsc;
            }

            set
            {
                anterior_ideEstabLot_nrInsc = value;
            }
        }

        public string Anterior_ideEstabLot_codLotacao
        {
            get
            {
                return anterior_ideEstabLot_codLotacao;
            }

            set
            {
                anterior_ideEstabLot_codLotacao = value;
            }
        }
    }
}
