using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service { 
    public class InfoAgNocivo
    {
        private sbyte grauExpField;

        /// <remarks/>
        public sbyte grauExp
        {
            get
            {
                return this.grauExpField;
            }
            set
            {
                this.grauExpField = value;
            }
        }
    }
}
