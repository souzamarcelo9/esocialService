using Esocial_Service.Classes;
using Esocial_Service.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Esocial_Service.Dominio
{
    public class EventoDeslig
    {
        public EvtDeslig2299 PreencheEventoS_2299()
        {
            EvtDeslig2299 evento2299 = new EvtDeslig2299();
            DmDev recibo;
            TDetVerbasItem itemRemun;

            evento2299.Id = "ID10123456200000202401123456789771";

            //Idevento
            evento2299.IdeEvento = new TIdeEveFopag();
            evento2299.IdeEvento.indRetif = 1;
            evento2299.IdeEvento.nrRecibo = "1.1.0000000012006838378";
            evento2299.IdeEvento.tpAmb = 2;
            evento2299.IdeEvento.procEmi = 1;
            evento2299.IdeEvento.verProc = "S_1.2.0";

            //IdeEmpregador
            evento2299.IdeEmpregador = new TEmpregador();
            evento2299.IdeEmpregador.tpInsc = 1;
            evento2299.IdeEmpregador.nrInsc = "03.572.731/0001-08";

            //ideVinculo
            evento2299.IdeVinculo = new IdeVinculo();
            evento2299.IdeVinculo.CpfTrabField = "11122233344";
            evento2299.IdeVinculo.Matricula = "SEDEMO0200000000000000000238";


            //infoDeslig
            evento2299.InfoDeslig = new TInfoDeslig();
            evento2299.InfoDeslig.DtDeslig = "2021-11-03";
            evento2299.InfoDeslig.MtvDeslig = "02";
            evento2299.InfoDeslig.IndPagtoAPI = "S";
            evento2299.InfoDeslig.DtProjFimAPI = "2021-12-21";
            evento2299.InfoDeslig.PensAlim = 0;

            //verbas rescisorias
            //DmDev  RECIBO 1          
            recibo = new DmDev();
            recibo.IdeDmDev = "DEMO020200A3953";

            recibo.IdeEstabLot = new IdeEstabLot();
            recibo.IdeEstabLot.tpInsc = 1;
            recibo.IdeEstabLot.nrInsc = "04400011000100";
            recibo.IdeEstabLot.codLotacao = "DEMO0200000000000000000001";

            recibo.IdeEstabLot.RemunPerApuracao = new RemunPeriodoApuracao();
            recibo.IdeEstabLot.RemunPerApuracao.Matricula = "DEMO0200000000000000000718";

            //inicia o array de recibos
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas = new List<TDetVerbasItem>();

            //ITEMS - RECIBOS DA FOLHA
            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000388";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 180;
            itemRemun.vrRubr = 3255.41M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000021";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 10.52M;
            itemRemun.FatorRubr = 60;
            itemRemun.vrRubr = 298.34M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000028";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 3.23M;
            //itemRemun.FatorRubr = 60;
            itemRemun.vrRubr = 57.37M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000064";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 1302.16M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000077";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 15;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000082";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 288.88M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000185";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 12;
            itemRemun.vrRubr = 342.33M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000086";
            itemRemun.ideTabRubr = "1";
            itemRemun.qtdRubr = 15;
            itemRemun.vrRubr = 107.08M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000095";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 0.5M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000390";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 0.5M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "DEMO0200000000000000000106";
            itemRemun.ideTabRubr = "1";
            itemRemun.vrRubr = 5;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "SB DED MENSAL";
            itemRemun.ideTabRubr = "SUP BASE";
            itemRemun.qtdRubr = 180;
            itemRemun.vrRubr = 600.05M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            itemRemun = new TDetVerbasItem();
            itemRemun.codRubr = "SB INF MENSAL";
            itemRemun.ideTabRubr = "SUP BASE";
            itemRemun.qtdRubr = 180;
            itemRemun.vrRubr = 600.05M;
            itemRemun.IndApuracaoField = 0;
            recibo.IdeEstabLot.RemunPerApuracao.DetVerbas.Add(itemRemun);

            //"INFOAGNOCIVO"
            recibo.IdeEstabLot.RemunPerApuracao.InfoAgNocivo = new InfoAgNocivo();
            recibo.IdeEstabLot.RemunPerApuracao.InfoAgNocivo.grauExp = 1;

            evento2299.InfoDeslig.VerbasResc = new TVerbasRescisorias();
            evento2299.InfoDeslig.VerbasResc.DmDev = new List<DmDev>();
            evento2299.InfoDeslig.VerbasResc.DmDev.Add(recibo);

            return evento2299;
            
        }

        public string GeraXmlEvento2299(EvtDeslig2299 evento)
        {
            string caminhoArquivo = String.Empty;
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtDeslig/v_S_01_02_00";
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", ""),
            new XElement(ns + "eSocial",
            new XElement(ns + "evtDeslig", new XAttribute("Id", evento.Id),
             new XElement(ns + "ideEvento",
                   new XElement(ns + "indRetif", evento.IdeEvento.indRetif),
                   new XElement(ns + "nrRecibo", evento.IdeEvento.perApur),
                   new XElement(ns + "tpAmb", evento.IdeEvento.tpAmb),
                   new XElement(ns + "procEmi", evento.IdeEvento.procEmi),
                   new XElement(ns + "verProc", evento.IdeEvento.verProc)),
             new XElement(ns + "ideEmpregador",
                          new XElement(ns + "tpInsc", evento.IdeEmpregador.tpInsc),
                          new XElement(ns + "nrInsc", evento.IdeEmpregador.nrInsc)
                          ),
             new XElement(ns + "ideVinculo",
                          new XElement(ns + "cpfTrab", evento.IdeVinculo.CpfTrabField),
                          new XElement(ns + "matricula", evento.IdeVinculo.CpfTrabField)),

             new XElement(ns + "infoDeslig",

                         new XElement(ns + "mtvDeslig", evento.InfoDeslig.MtvDeslig),
                         new XElement(ns + "dtDeslig", evento.InfoDeslig.DtDeslig),
                         new XElement(ns + "indPagtoAPI", evento.InfoDeslig.IndPagtoAPI),
                         new XElement(ns + "dtProjFimAPI", evento.InfoDeslig.DtProjFimAPI),
                         new XElement(ns + "pensAlim", evento.InfoDeslig.PensAlim),

                    //verbasResc                
                    evento.InfoDeslig.VerbasResc.DmDev.Select(dmDev =>
                 new XElement(ns + "dmDev",
                  new XElement(ns + "ideDmDev", dmDev.IdeDmDev),
                        new XElement(ns + "infoPerApur",
                               new XElement(ns + "ideEstabLot",
                                  new XElement(ns + "tpInsc", dmDev.IdeEstabLot.tpInsc),
                                  new XElement(ns + "nrInsc", dmDev.IdeEstabLot.nrInsc),
                                  new XElement(ns + "codLotacao", dmDev.IdeEstabLot.codLotacao)),

                 dmDev.IdeEstabLot.RemunPerApuracao.DetVerbas.Select(itemRemun =>
                                        new XElement(ns + "detVerbas",
                                         new XElement(ns + "codRubr", itemRemun.codRubr),
                                         new XElement(ns + "ideTabRubr", itemRemun.ideTabRubr),
                                         new XElement(ns + "qtdRubr", itemRemun.qtdRubr),
                                         new XElement(ns + "vrRubr", itemRemun.vrRubr),
                                         new XElement(ns + "indApurIR", itemRemun.IndApuracaoField))),
                                   new XElement(ns + "infoAgNocivo",
                                        new XElement(ns + "grauExp", dmDev.IdeEstabLot.RemunPerApuracao.InfoAgNocivo.grauExp)
                                   )
                              ))


                     ))//recibos

                    ))//eSocial

                ); //document                                                                                 


            caminhoArquivo = @"C:\temp\EvtDeslig2299.xml";
            doc.Save(caminhoArquivo);
            return caminhoArquivo;
            // }
        }

    }
}
