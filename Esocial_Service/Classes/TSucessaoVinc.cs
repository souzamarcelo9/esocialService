using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TSucessaoVinc
    {
        sbyte tpInsc;

        string nrInsc;

        string matricAnt;

        string dtAdm;

        string observacao;

        public sbyte TpInsc
        {
            get
            {
                return tpInsc;
            }

            set
            {
                tpInsc = value;
            }
        }

        public string NrInsc
        {
            get
            {
                return nrInsc;
            }

            set
            {
                nrInsc = value;
            }
        }

        public string MatricAnt
        {
            get
            {
                return matricAnt;
            }

            set
            {
                matricAnt = value;
            }
        }

        public string DtAdm
        {
            get
            {
                return dtAdm;
            }

            set
            {
                dtAdm = value;
            }
        }

        public string Observacao
        {
            get
            {
                return observacao;
            }

            set
            {
                observacao = value;
            }
        }
    }
}
