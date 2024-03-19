using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class EvtoPagtoInfoIRComplem
    {

        TEvtoPagtoPlanoSaude planSaude;

        public TEvtoPagtoPlanoSaude PlanSaude
        {
            get
            {
                return planSaude;
            }

            set
            {
                planSaude = value;
            }
        }
    }
}
