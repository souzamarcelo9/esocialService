using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TInfoMV
    {
        sbyte indMV;

        List<TRemunOutrEmpr> remunOutrEmpr;

        public sbyte IndMV
        {
            get
            {
                return indMV;
            }

            set
            {
                indMV = value;
            }
        }

        public List<TRemunOutrEmpr> RemunOutrEmpr
        {
            get
            {
                return remunOutrEmpr;
            }

            set
            {
                remunOutrEmpr = value;
            }
        }
    }
}
