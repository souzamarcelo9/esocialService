using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Esocial_Service.Dominio
{
    public class EventoRemun
    {
        public EvtRemun1200 PreencheEventoS_1200()
        {
            EvtRemun1200 evento1200 = new EvtRemun1200();
            DmDev recibo;
            TItemRemuneracao itemRemun;

            evento1200.Id = "ID1044022770000002024013110122353124";

            //Idevento
            evento1200.IdeEvento = new TIdeEveFopag();
            evento1200.IdeEvento.indRetif = 2;
            evento1200.IdeEvento.nrRecibo = "1.1.0000000015625142093";
            evento1200.IdeEvento.indApuracao = 1;
            evento1200.IdeEvento.perApur = "2023 - 07";
            evento1200.IdeEvento.tpAmb = 2;
            evento1200.IdeEvento.procEmi = 1;
            evento1200.IdeEvento.verProc = "S_1.2.0";

            //IdeEmpregador
            evento1200.IdeEmpregador = new TEmpregador();
            evento1200.IdeEmpregador.tpInsc = 1;
            evento1200.IdeEmpregador.nrInsc = "03.572.731/0001-08";

            //idetrabalhador
            evento1200.IdeTrabalhador = new IdeTrabalhador();
            evento1200.IdeTrabalhador.CpfTrabField = "22251790004";

            //Inicia array de Recibos
            evento1200.DmDev = new List<DmDev>();

            //DmDev  RECIBO 1          
            recibo = new DmDev();
            recibo.IdeDmDev = "DEMO021032A1713";
            recibo.CodCategField = "101";

            recibo.IdeEstabLot = new IdeEstabLot();
            recibo.IdeEstabLot.tpInsc = 1;
            recibo.IdeEstabLot.nrInsc = "04400011000100";
            recibo.IdeEstabLot.codLotacao = "DEMO0200000000000000000001";

            recibo.IdeEstabLot.RemunPerApuracao = new RemunPeriodoApuracao();
            recibo.IdeEstabLot.RemunPerApuracao.Matricula = "DEMO0200000000000000000718";

            //inicia o array de recibos
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField = new List<TItemRemuneracao>();

            //ITEMS - RECIBOS DA FOLHA
            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000388";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 180;
            itemRemun.vrRubr = 3255.41M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000021";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 10.52M;
            itemRemun.FatorRubr = 60;
            itemRemun.vrRubr = 298.34M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000028";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 3.23M;
            //itemRemun.FatorRubr = 60;
            itemRemun.vrRubr = 57.37M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000064";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 1302.16M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000077";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 15;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000082";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 288.88M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000185";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 12;
            itemRemun.vrRubr = 342.33M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000086";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 15;
            itemRemun.vrRubr = 107.08M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000095";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 0.5M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000390";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 0.5M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000106";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 5;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "SB DED MENSAL";
            itemRemun.ideTabRubr = "SUP BASE";
            itemRemun.qtdRubr = 180;
            itemRemun.vrRubr = 600.05M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "SB INF MENSAL";
            itemRemun.ideTabRubr = "SUP BASE";
            itemRemun.qtdRubr = 180;
            itemRemun.vrRubr = 600.05M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            //"INFOAGNOCIVO"
            recibo.IdeEstabLot.RemunPerApuracao.InfoAgNocivo = new InfoAgNocivo();
            recibo.IdeEstabLot.RemunPerApuracao.InfoAgNocivo.grauExp = 1;

            evento1200.DmDev.Add(recibo);

            //RECIBO 2 

            recibo = new DmDev();
            recibo.IdeDmDev = "BICAMA021035A1713";
            recibo.CodCategField = "101";

            recibo.IdeEstabLot = new IdeEstabLot();
            recibo.IdeEstabLot.tpInsc = 1;
            recibo.IdeEstabLot.nrInsc = "04401122000100";
            recibo.IdeEstabLot.codLotacao = "DEMO0200000000000000000001";

            recibo.IdeEstabLot.RemunPerApuracao = new RemunPeriodoApuracao();
            recibo.IdeEstabLot.RemunPerApuracao.Matricula = "DEMO0200000000000000000718";
            //inicia o array de recibos
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField = new List<TItemRemuneracao>();

            itemRemun = new TItemRemuneracao();
            itemRemun.codRubr = "DEMO0200000000000000000063";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 1302.16M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Add(itemRemun);

            recibo.IdeEstabLot.RemunPerApuracao.InfoAgNocivo = new InfoAgNocivo();
            recibo.IdeEstabLot.RemunPerApuracao.InfoAgNocivo.grauExp = 1;

            evento1200.DmDev.Add(recibo);

            return evento1200;
           
        }

        public string GeraXmlEvento1200(EvtRemun1200 evento)
        {
            string pathS1200;
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtRemun/v_S_01_02_00";
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", ""),
            new XElement(ns + "eSocial",
            new XElement(ns + "evtRemun", new XAttribute("Id", evento.Id),
             new XElement(ns + "ideEvento",
                   new XElement(ns + "indRetif", evento.IdeEvento.indRetif),
                   new XElement(ns + "nrRecibo", evento.IdeEvento.nrRecibo),
                   new XElement(ns + "indApuracao", evento.IdeEvento.indApuracao),
                   new XElement(ns + "perApur", evento.IdeEvento.perApur),
                   new XElement(ns + "tpAmb", evento.IdeEvento.tpAmb),
                   new XElement(ns + "procEmi", evento.IdeEvento.procEmi),
                   new XElement(ns + "verProc", evento.IdeEvento.verProc)),
             new XElement(ns + "ideEmpregador",
                          new XElement(ns + "tpInsc", evento.IdeEmpregador.tpInsc),
                          new XElement(ns + "nrInsc", evento.IdeEmpregador.nrInsc)
                          ),
             new XElement(ns + "ideTrabalhador",
                          new XElement(ns + "cpfTrab", evento.IdeTrabalhador.CpfTrabField)
                          ),

             evento.DmDev.Select(dmDev =>
                 new XElement(ns + "dmDev",
                  new XElement(ns + "ideDmDev", dmDev.IdeDmDev),
                  new XElement(ns + "codCateg", dmDev.CodCategField),
                        new XElement(ns + "infoPerApur",
                               new XElement(ns + "ideEstabLot",
                                  new XElement(ns + "tpInsc", dmDev.IdeEstabLot.tpInsc),
                                  new XElement(ns + "nrInsc", dmDev.IdeEstabLot.nrInsc),
                                  new XElement(ns + "codLotacao", dmDev.IdeEstabLot.codLotacao),
                                  new XElement(ns + "remunPerApur",
                             new XElement(ns + "matricula", dmDev.IdeEstabLot.RemunPerApuracao.Matricula),
                 dmDev.IdeEstabLot.RemunPerApuracao.RemunPerAntField.Select(itemRemun =>
                                        new XElement(ns + "itensRemun",
                                         new XElement(ns + "codRubr", itemRemun.codRubr),
                                         new XElement(ns + "ideTabRubr", itemRemun.ideTabRubr),
                                         new XElement(ns + "qtdRubr", itemRemun.qtdRubr),
                                         new XElement(ns + "vrRubr", itemRemun.vrRubr),
                                         new XElement(ns + "indApurIR", itemRemun.IndApuracaoField))),
                                   new XElement(ns + "infoAgNocivo",
                                        new XElement(ns + "grauExp", dmDev.IdeEstabLot.RemunPerApuracao.InfoAgNocivo.grauExp))
                                   )
                              ))
                             ) //recibos

                         )//select recibos
                       )) //eSocial
                    ); //document                                                                                 


            //Console.WriteLine(doc);

            pathS1200 = @"C:\temp\EvtRemun1200.xml";
            doc.Save(pathS1200);

            return pathS1200;
            // }
        }

    }
}
