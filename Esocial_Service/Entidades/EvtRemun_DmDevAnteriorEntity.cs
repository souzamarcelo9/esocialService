using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class EvtRemun_DmDevAnteriorEntity
    {
        int id;
        int id_projeto;
        int id_cad_evtremun;
        int id_s_1200_dmdev;
        string dtAcConv;
        string tpAcConv;
        string compAcConv;
        string dtEfAcConv;
        string dsc;
        string remunSuc;

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

        public string DtAcConv
        {
            get
            {
                return dtAcConv;
            }

            set
            {
                dtAcConv = value;
            }
        }

        public string TpAcConv
        {
            get
            {
                return tpAcConv;
            }

            set
            {
                tpAcConv = value;
            }
        }

        public string CompAcConv
        {
            get
            {
                return compAcConv;
            }

            set
            {
                compAcConv = value;
            }
        }

        public string DtEfAcConv
        {
            get
            {
                return dtEfAcConv;
            }

            set
            {
                dtEfAcConv = value;
            }
        }

        public string Dsc
        {
            get
            {
                return dsc;
            }

            set
            {
                dsc = value;
            }
        }

        public string RemunSuc
        {
            get
            {
                return remunSuc;
            }

            set
            {
                remunSuc = value;
            }
        }
    }
}
