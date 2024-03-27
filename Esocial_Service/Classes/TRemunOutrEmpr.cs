using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Classes
{
    public class TRemunOutrEmpr
    {
        sbyte tpInsc;
        string nrInsc;
        sbyte codCateg;
        Decimal vlrRemunOE;

        public sbyte TpInsc
        {
            get
            {
                return tpInsc;
            }

            set
            {
                tpInsc = value;
            }
        }

        public string NrInsc
        {
            get
            {
                return nrInsc;
            }

            set
            {
                nrInsc = value;
            }
        }

        public sbyte CodCateg
        {
            get
            {
                return codCateg;
            }

            set
            {
                codCateg = value;
            }
        }

        public decimal VlrRemunOE
        {
            get
            {
                return vlrRemunOE;
            }

            set
            {
                vlrRemunOE = value;
            }
        }
    }
}
