using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class IdeADC
    {
        DateTime dtAcConv;
        string tpAcConv;
        string dsc;
        string remunSuc;
        IdePeriodo idePeriodo;

        public DateTime DtAcConv
        {
            get
            {
                return dtAcConv;
            }

            set
            {
                dtAcConv = value;
            }
        }

        public string TpAcConv
        {
            get
            {
                return tpAcConv;
            }

            set
            {
                tpAcConv = value;
            }
        }

        public string Dsc
        {
            get
            {
                return dsc;
            }

            set
            {
                dsc = value;
            }
        }

        public string RemunSuc
        {
            get
            {
                return remunSuc;
            }

            set
            {
                remunSuc = value;
            }
        }

        public IdePeriodo IdePeriodo
        {
            get
            {
                return idePeriodo;
            }

            set
            {
                idePeriodo = value;
            }
        }
    }
}
