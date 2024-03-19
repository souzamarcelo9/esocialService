using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service
{
    public class EvtRemun1200
    {
        private string id;

        TIdeEveFopag ideEvento;        

        /// <summary>
        /// 
        /// </summary>
        TEmpregador ideEmpregador;
        IdeTrabalhador ideTrabalhador;

        List<DmDev> dmDev;

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
               this.id = value;
            }
        }

        public TIdeEveFopag IdeEvento
        {
            get
            {
                return ideEvento;
            }

            set
            {
                ideEvento = value;
            }
        }

        public List<DmDev> DmDev
        {
            get
            {
                return dmDev;
            }

            set
            {
                dmDev = value;
            }
        }

        public TEmpregador IdeEmpregador
        {
            get
            {
                return ideEmpregador;
            }

            set
            {
                ideEmpregador = value;
            }
        }

        public IdeTrabalhador IdeTrabalhador
        {
            get
            {
                return ideTrabalhador;
            }

            set
            {
                ideTrabalhador = value;
            }
        }


        //< ideEvento >
        //    < indRetif > 2 </ indRetif >
        //    < nrRecibo > 1.1.0000000015625142093</nrRecibo>
        //    <indApuracao>1</indApuracao>
        //    <perApur>2022-07</perApur>
        //    <tpAmb>1</tpAmb>
        //    <procEmi>1</procEmi>
        //    <verProc>S_1.2.0</verProc>
        //</ideEvento>

        //<ideEmpregador>
        //    <tpInsc>1</tpInsc>
        //    <nrInsc>0123456</nrInsc>
        //</ideEmpregador>
        //<ideTrabalhador>
        //    <cpfTrab>11122233322</cpfTrab>
        //</ideTrabalhador>
        //    <dmDev>
        //        <ideDmDev>DEMO021032A1713</ideDmDev>
        //        <codCateg>101</codCateg>
        //        <infoPerApur>
        //            <ideEstabLot>
        //                <tpInsc>1</tpInsc>
        //                <nrInsc>04400011000100</nrInsc>
        //                <codLotacao>DEMO0200000000000000000001</codLotacao>
        //                <remunPerApur>
        //                    <matricula>DEMO0200000000000000000718</matricula>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000388</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <qtdRubr>180</qtdRubr>
        //                        <vrRubr>3255.41</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000021</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <qtdRubr>10.52</qtdRubr>
        //                        <fatorRubr>60</fatorRubr>
        //                        <vrRubr>298.34</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000028</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <qtdRubr>3.23</qtdRubr>
        //                        <vrRubr>57.37</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000064</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>1302.16</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000077</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>15</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000082</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>288.88</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000185</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <qtdRubr>12</qtdRubr>
        //                        <vrRubr>342.33</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000086</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <qtdRubr>15</qtdRubr>
        //                        <vrRubr>107.08</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000095</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>0.5</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000390</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>0.5</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000106</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>5</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000108</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>37.66</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000109</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>0.5</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000120</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>0.5</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000324</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>98.88</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>SB DED MENSAL</codRubr>
        //                        <ideTabRubr>SUP BASE</ideTabRubr>
        //                        <qtdRubr>180</qtdRubr>
        //                        <vrRubr>600.05</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>SB INF MENSAL</codRubr>
        //                        <ideTabRubr>SUP BASE</ideTabRubr>
        //                        <qtdRubr>180</qtdRubr>
        //                        <vrRubr>600.05</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <infoAgNocivo>
        //                        <grauExp>1</grauExp>
        //                    </infoAgNocivo>
        //                </remunPerApur>
        //            </ideEstabLot>
        //        </infoPerApur>
        //    </dmDev>
        //    <dmDev>
        //        <ideDmDev>BICAMA021035A1713</ideDmDev>
        //        <codCateg>101</codCateg>
        //        <infoPerApur>
        //            <ideEstabLot>
        //                <tpInsc>1</tpInsc>
        //                <nrInsc>04401122000100</nrInsc>
        //                <codLotacao>DEMO0200000000000000000001</codLotacao>
        //                <remunPerApur>
        //                    <matricula>DEMO0200000000000000000718</matricula>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000063</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>1302.16</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <infoAgNocivo>
        //                        <grauExp>1</grauExp>
        //                    </infoAgNocivo>
        //                </remunPerApur>
        //            </ideEstabLot>
        //        </infoPerApur>
        //    </dmDev>
        //    <dmDev>
        //        <ideDmDev>BICAMA021036A1713</ideDmDev>
        //        <codCateg>101</codCateg>
        //        <infoPerApur>
        //            <ideEstabLot>
        //                <tpInsc>1</tpInsc>
        //                <nrInsc>04401122000100</nrInsc>
        //                <codLotacao>DEMO0200000000000000000001</codLotacao>
        //                <remunPerApur>
        //                    <matricula>DEMO0200000000000000000718</matricula>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000100</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>1220.78</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000102</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>1220.78</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <itensRemun>
        //                        <codRubr>DEMO0200000000000000000092</codRubr>
        //                        <ideTabRubr>1</ideTabRubr>
        //                        <vrRubr>9.1</vrRubr>
        //                        <indApurIR>0</indApurIR>
        //                    </itensRemun>
        //                    <infoAgNocivo>
        //                        <grauExp>1</grauExp>
        //                    </infoAgNocivo>
        //                </remunPerApur>
        //            </ideEstabLot>
        //        </infoPerApur>
        //    </dmDev>
        //</evtRemun>



    }
}
