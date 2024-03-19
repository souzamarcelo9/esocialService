using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class RemunPeriodoApuracao
    {
        private string matricula;

        private List<TItemRemuneracao> remunPerAntField;

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

        public List<TItemRemuneracao> RemunPerAntField
        {
            get
            {
                return remunPerAntField;
            }

            set
            {
                remunPerAntField = value;
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
    }
}
