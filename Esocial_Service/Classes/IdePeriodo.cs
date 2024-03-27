using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class IdePeriodo
    {
        string perRef;

        IdeEstabLot ideEstabLot;

        public string PerRef
        {
            get
            {
                return perRef;
            }

            set
            {
                perRef = value;
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
