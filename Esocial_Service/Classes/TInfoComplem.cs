using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TInfoComplem
    {
        string nmTrab;

        string dtNascto;

        List<TSucessaoVinc> sucessaoVinc;

        public string NmTrab
        {
            get
            {
                return nmTrab;
            }

            set
            {
                nmTrab = value;
            }
        }

        public string DtNascto
        {
            get
            {
                return dtNascto;
            }

            set
            {
                dtNascto = value;
            }
        }

        public List<TSucessaoVinc> SucessaoVinc
        {
            get
            {
                return sucessaoVinc;
            }

            set
            {
                sucessaoVinc = value;
            }
        }
    }
}
