using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class RemunPeriodoAnterior
    {
        private string matricula;

        private string indSimples;

        private List<TItemRemuneracao> remunPerField;

        private InfoAgNocivo infoAgNocivo;

        private List<TDetVerbasItem> detVerbas;

        public string Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public List<TItemRemuneracao> RemunPerField
        {
            get
            {
                return remunPerField;
            }

            set
            {
                remunPerField = value;
            }
        }

        public InfoAgNocivo InfoAgNocivo
        {
            get
            {
                return infoAgNocivo;
            }

            set
            {
                infoAgNocivo = value;
            }
        }

        public List<TDetVerbasItem> DetVerbas
        {
            get
            {
                return detVerbas;
            }

            set
            {
                detVerbas = value;
            }
        }

        public string IndSimples
        {
            get
            {
                return indSimples;
            }

            set
            {
                indSimples = value;
            }
        }
    }
}
