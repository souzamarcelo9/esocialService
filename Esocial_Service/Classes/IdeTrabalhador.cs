using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class IdeTrabalhador
    {       

            private string cpfTrabField;

            private string nisTrabField;   
        
            private TInfoMV infoMV;

            TInfoComplem infoComplem;

            List<TProcJudTrab> procJudTrab;

            List<TInfoInterm> infoInterm;
      

        /// <remarks/>
        public string CpfTrabField
            {
                get
                {
                    return this.cpfTrabField;
                }
                set
                {
                    this.cpfTrabField = value;
                }
            }

        public string NisTrabField
        {
            get
            {
                return nisTrabField;
            }

            set
            {
                nisTrabField = value;
            }
        }

        public TInfoMV InfoMV
        {
            get
            {
                return infoMV;
            }

            set
            {
                infoMV = value;
            }
        }

        public TInfoComplem InfoComplem
        {
            get
            {
                return infoComplem;
            }

            set
            {
                infoComplem = value;
            }
        }

        public List<TProcJudTrab> ProcJudTrab
        {
            get
            {
                return procJudTrab;
            }

            set
            {
                procJudTrab = value;
            }
        }

        public List<TInfoInterm> InfoInterm
        {
            get
            {
                return infoInterm;
            }

            set
            {
                infoInterm = value;
            }
        }
    }
}
