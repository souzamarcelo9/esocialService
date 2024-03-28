using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_DmDev_IdeEstablotEntity
    {
        int id;
        int id_projeto;
        int id_usuario;
        int id_cad_evtremun;
        int id_s_1200_dmdev;
        int ideEstabLot_tpInsc;
        string ideEstabLot_nrInsc;
        string ideEstabLot_codLotacao;
        string ideEstabLot_qtdDiasAv;
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

        public int IdeEstabLot_tpInsc
        {
            get
            {
                return ideEstabLot_tpInsc;
            }

            set
            {
                ideEstabLot_tpInsc = value;
            }
        }

        public string IdeEstabLot_nrInsc
        {
            get
            {
                return ideEstabLot_nrInsc;
            }

            set
            {
                ideEstabLot_nrInsc = value;
            }
        }

        public string IdeEstabLot_codLotacao
        {
            get
            {
                return ideEstabLot_codLotacao;
            }

            set
            {
                ideEstabLot_codLotacao = value;
            }
        }

        public string IdeEstabLot_qtdDiasAv
        {
            get
            {
                return ideEstabLot_qtdDiasAv;
            }

            set
            {
                ideEstabLot_qtdDiasAv = value;
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
