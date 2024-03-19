using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TInfoDeslig
    {
        string mtvDeslig;

        string dtDeslig;

        string indPagtoAPI;

        string dtProjFimAPI;

        sbyte pensAlim;

        TVerbasRescisorias verbasResc;

        public string MtvDeslig
        {
            get
            {
                return mtvDeslig;
            }

            set
            {
                mtvDeslig = value;
            }
        }

        public string DtDeslig
        {
            get
            {
                return dtDeslig;
            }

            set
            {
                dtDeslig = value;
            }
        }

        public string IndPagtoAPI
        {
            get
            {
                return indPagtoAPI;
            }

            set
            {
                indPagtoAPI = value;
            }
        }

        public string DtProjFimAPI
        {
            get
            {
                return dtProjFimAPI;
            }

            set
            {
                dtProjFimAPI = value;
            }
        }

        public sbyte PensAlim
        {
            get
            {
                return pensAlim;
            }

            set
            {
                pensAlim = value;
            }
        }

        public TVerbasRescisorias VerbasResc
        {
            get
            {
                return verbasResc;
            }

            set
            {
                verbasResc = value;
            }
        }
    }
}
