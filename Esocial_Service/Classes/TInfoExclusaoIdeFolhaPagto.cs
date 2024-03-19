using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
   public class TInfoExclusaoIdeFolhaPagto
    {
        private sbyte indApuracaoField;

        private string perApurField;

        /// <remarks/>
        public sbyte indApuracao
        {
            get
            {
                return this.indApuracaoField;
            }
            set
            {
                this.indApuracaoField = value;
            }
        }

        /// <remarks/>
        public string perApur
        {
            get
            {
                return this.perApurField;
            }
            set
            {
                this.perApurField = value;
            }
        }


    }
}
