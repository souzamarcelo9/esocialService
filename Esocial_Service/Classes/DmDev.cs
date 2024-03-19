using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class DmDev
    {
        private string ideDmDev;

        private string codCategField;

        private IdeEstabLot ideEstabLot;

        public string IdeDmDev
        {
            get
            {
                return ideDmDev;
            }

            set
            {
                ideDmDev = value;
            }
        }

        public string CodCategField
        {
            get
            {
                return codCategField;
            }

            set
            {
                codCategField = value;
            }
        }

        public IdeEstabLot IdeEstabLot
        {
            get
            {
                return ideEstabLot;
            }

            set
            {
                ideEstabLot = value;
            }
        }
    }
}
