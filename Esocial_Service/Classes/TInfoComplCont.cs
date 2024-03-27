using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TInfoComplCont
    {
        string codCBO;
        string natAtividade;
        string qtdDiasTrab;

        public string CodCBO
        {
            get
            {
                return this.codCBO;
            }
            set
            {
                this.codCBO = value;
            }
        }

        public string NatAtividade
        {
            get
            {
                return natAtividade;
            }

            set
            {
                natAtividade = value;
            }
        }

        public string QtdDiasTrab
        {
            get
            {
                return qtdDiasTrab;
            }

            set
            {
                qtdDiasTrab = value;
            }
        }
    }
}
