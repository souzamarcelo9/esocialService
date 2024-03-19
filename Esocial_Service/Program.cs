using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Esocial_Service.Classes;
using System.Xml.Linq;
using System.Collections;
using System.Net;
using System.ServiceModel;
using Esocial_Service;
using Esocial_Service.Service;
using Esocial_Service.Eventos;

namespace Esocial_Service
{
    class Program
    {
        public static string pathS1200;
        public static string pathS1210;
        static void Main(string[] args)
        {   
            Console.WriteLine("Qual evento deseja gerar:");
            string evento = Console.ReadLine();

            switch (evento)
            {
                case "S-1200":
                    S_1200();
                    break;

                case "S-1210":
                    S_1210();
                    break;

                case "S-2299":
                    S_2299();
                    break;

                case "S-3000":
                    S_3000();
                    break;

                default:
                    Console.WriteLine("Nenhuma opção escolhida");
                    break;
            }
                        
            
        }

        public static void AddXmlns(string path)
        {
            var xmldoc = new XmlDocument();

            xmldoc.LoadXml(path);

            xmldoc.DocumentElement.SetAttribute("xmlns", "http://www.esocial.gov.br/schema/evt/evtRemun/v_S_01_02_00");
            xmldoc.Save(@"C:\temp\temp.xml");
        }

        public static void S_1200()
        {            
            string arquivoAssinado = String.Empty;            
            PreencheEventoS_1200();
            arquivoAssinado = AssinaXML("evtRemun",pathS1200);
            AdicionaXmlS1200Lote(arquivoAssinado);
            //
            EsocialService.EnviaLoteEventos(pathS1200);
        }

        public static void S_2299()
        {
            string arquivoAssinado = String.Empty;
            PreencheEventoS_2299();
            arquivoAssinado = AssinaXML("evtDeslig", pathS1210);
            AdicionaXmlSLote(arquivoAssinado, "http://www.esocial.gov.br/schema/evt/evtDeslig/v_S_01_02_00", "evtDeslig");
            //
            EsocialService.EnviaLoteEventos(pathS1200);
        }

        public static void S_1210()
        {   //inclusão
            string arquivoAssinado = String.Empty;
            PreencheEventoS_1210();
            arquivoAssinado = AssinaXML("evtPgtos", pathS1210);
            AdicionaXmlSLote(arquivoAssinado, "http://www.esocial.gov.br/schema/evt/evtPgtos/v_S_01_02_00", "evtPgtos");
            //
            EsocialService.EnviaLoteEventos(pathS1200);

        }

        public static void S_3000()
        {

            //Exclusão
            string arquivoAssinado = String.Empty;            
            PreencheEventoS_3000();
            arquivoAssinado = AssinaXML("evtExclusao", pathS1210);
            AdicionaXmlSLote(arquivoAssinado, "http://www.esocial.gov.br/schema/evt/evtExclusao/v_S_01_02_00", "evtExclusao");
            //
            EsocialService.EnviaLoteEventos(pathS1200);
        }

        public static XmlNodeList getXmlNodeList(string XmlNodeName, XmlDocument doc)
        {
            XmlNodeList elemList = doc.GetElementsByTagName(XmlNodeName);
            return elemList;
        }        

        public static void RemoveNamespaceXsi(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            foreach (var node in doc.DocumentElement.ChildNodes)
            {
                var el = node as XmlElement;
                if (el != null)
                {
                    if (el.HasAttribute("xmlns"))
                    {
                        var ns = el.GetAttribute("xmlns");
                        if (ns == "" || String.IsNullOrEmpty(ns))
                        {
                            el.RemoveAttribute("xmlns");
                            doc.Save(@"C:\temp\EvtRemun1200_new.xml");
                        }
                    }
                }
                
            }
            
        }
       
        public static void PreencheEventoS_1200()
        {
            EvtRemun1200 evento1200 = new EvtRemun1200();
            DmDev[] listarecibos;
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

            GeraXmlEvento1200(evento1200);
        }

        public static void PreencheEventoS_1210()
        {
            EvtPagtos1210 evento1210 = new EvtPagtos1210();           
            EvtPgtosIdeBenefInfoPgto infoPagto;
            evento1210.Id = "ID1713221500000001112223334441222492";

            //Idevento
            evento1210.IdeEvento = new TIdeEveFopag();
            evento1210.IdeEvento.indRetif = 1;
            evento1210.IdeEvento.perApur = "2023 - 07";
            evento1210.IdeEvento.tpAmb = 2;
            evento1210.IdeEvento.procEmi = 1;
            evento1210.IdeEvento.verProc = "S_1.2.0";
            
            //IdeEmpregador
            evento1210.IdeEmpregador = new TEmpregador();
            evento1210.IdeEmpregador.tpInsc = 1;
            evento1210.IdeEmpregador.nrInsc = "03.572.731/0001-08";

            //ideBenef
            evento1210.InfoPagto = new TEvt1210InfoInclusao();
            evento1210.InfoPagto.IdeBenef = new EvtPgtosIdeBenef();

            evento1210.InfoPagto.IdeBenef.cpfBenef = "22251790004";

            //Inicia array de Recibos
            evento1210.InfoPagto.IdeBenef.InfoPgto = new List<EvtPgtosIdeBenefInfoPgto>();
                        
            //DmDev  RECIBO 1                      
            infoPagto = new EvtPgtosIdeBenefInfoPgto();

            infoPagto.DtPgto = "2023-06-06";            
            infoPagto.TpPgto = 1;
            infoPagto.DetPgtoFl.perRef = "2023-05";
            infoPagto.DetPgtoFl.ideRecPgto = "5";
            infoPagto.DetPgtoFl.vlrPgto = 1067.28M;
            evento1210.InfoPagto.IdeBenef.InfoPgto.Add(infoPagto);

            infoPagto = new EvtPgtosIdeBenefInfoPgto();

            infoPagto.DtPgto = "2023-06-07";
            infoPagto.TpPgto = 1;
            infoPagto.DetPgtoFl.perRef = "2023-06";
            infoPagto.DetPgtoFl.ideRecPgto = "6";
            infoPagto.DetPgtoFl.vlrPgto = 9071.98M;

            evento1210.InfoPagto.IdeBenef.InfoPgto.Add(infoPagto);

            GeraXmlEvento1210_Inclusao(evento1210);
        }

        public static void PreencheEventoS_2299()
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


            GeraXmlEvento2299(evento2299);
        }
      

        public static void PreencheEventoS_3000()
        {
            EvtExclusao3000  evento3000 = new EvtExclusao3000();

            evento3000.Id = "ID1044022770000001234564879512311";

            //Idevento
            evento3000.IdeEvento = new TIdeEveFopag();
            evento3000.IdeEvento.tpAmb = 2;
            evento3000.IdeEvento.procEmi = 1;
            evento3000.IdeEvento.verProc = "S_1.2.0";

            //IdeEmpregador
            evento3000.IdeEmpregador = new TEmpregador();
            evento3000.IdeEmpregador.tpInsc = 1;
            evento3000.IdeEmpregador.nrInsc = "03.572.731/0001-08";

            //infoExclusao
            evento3000.InfoExclusao = new TEvt1210InfoExclusao();

            evento3000.InfoExclusao.TpEventoField = "S-1210";
            evento3000.InfoExclusao.NrRecEvtField = "1.1.0000000017821052981";

            //ideTrabalhador
            evento3000.InfoExclusao.IdeTrabalhador = new IdeTrabalhador();
            evento3000.InfoExclusao.IdeTrabalhador.CpfTrabField = "11122233344";

            evento3000.InfoExclusao.IdeFolhaPagto = new IdeFolhaPagto();
            evento3000.InfoExclusao.IdeFolhaPagto.perApur = "2022-12";


            GeraXmlEvento3000(evento3000);
        }


        public static void GeraXmlEvento1200(EvtRemun1200 evento)
        {
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtRemun/v_S_01_02_00";            
            XDocument doc = new XDocument(            
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
                                  new XElement(ns + "codLotacao", dmDev.IdeEstabLot.codLotacao)),
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
                                        new XElement(ns + "grauExp", dmDev.IdeEstabLot.RemunPerApuracao.InfoAgNocivo.grauExp)             
                                   )
                              ))
                             ) //recibos

                         )//select recibos
                       )) //eSocial
                    ); //document                                                                                 


            //Console.WriteLine(doc);

            pathS1200 = @"C:\temp\EvtRemun1200.xml";
            doc.Save(pathS1200);
                 
           // }
        }

        public static void GeraXmlEvento1210_Inclusao(EvtPagtos1210 evento)
        {
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtPgtos/v_S_01_02_00";
            XDocument doc = new XDocument(
            new XElement(ns + "eSocial",
            new XElement(ns + "evtPgtos", new XAttribute("Id", evento.Id),
             new XElement(ns + "ideEvento",
                   new XElement(ns + "indRetif", evento.IdeEvento.indRetif),
                   new XElement(ns + "perApur", evento.IdeEvento.perApur),
                   new XElement(ns + "tpAmb", evento.IdeEvento.tpAmb),
                   new XElement(ns + "procEmi", evento.IdeEvento.procEmi),
                   new XElement(ns + "verProc", evento.IdeEvento.verProc)),
             new XElement(ns + "ideEmpregador",
                          new XElement(ns + "tpInsc", evento.IdeEmpregador.tpInsc),
                          new XElement(ns + "nrInsc", evento.IdeEmpregador.nrInsc)
                          ),
             new XElement(ns + "ideBenef",
                          new XElement(ns + "cpfBenef", evento.InfoPagto.IdeBenef.cpfBenef),

                 evento.InfoPagto.IdeBenef.InfoPgto.Select(dmDev =>
                 new XElement(ns + "infoPgto",
                         new XElement(ns + "dtPgto", dmDev.DtPgto),
                         new XElement(ns + "tpPgto", dmDev.TpPgto),
                         new XElement(ns + "perRef", dmDev.DetPgtoFl.perRef),
                         new XElement(ns + "ideDmDev", dmDev.DetPgtoFl.ideRecPgto),
                         new XElement(ns + "vrLiq", dmDev.DetPgtoFl.vlrPgto)
                     )),
                     GetinfoIRComplemEvt1210(evento,ns)
                    ))
                   ) //recibos

                   //select recibos
                   //eSocial
                ); //document                                                                                 


            pathS1210 = @"C:\temp\EvtPgto1210.xml";
            doc.Save(pathS1210);

            // }
        }

        public static void GeraXmlEvento2299(EvtDeslig2299 evento)
        {
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtDeslig/v_S_01_02_00";
            XDocument doc = new XDocument(
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


            pathS1210 = @"C:\temp\EvtDeslig2299.xml";
            doc.Save(pathS1210);

            // }
        }

        public static void GeraXmlEvento3000(EvtExclusao3000 evento)
        {
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtExclusao/v_S_01_02_00";
            XDocument doc = new XDocument(
            new XElement(ns + "eSocial",
            new XElement(ns + "evtExclusao", new XAttribute("Id", evento.Id),
             new XElement(ns + "ideEvento",                  
                   new XElement(ns + "tpAmb", evento.IdeEvento.tpAmb),
                   new XElement(ns + "procEmi", evento.IdeEvento.procEmi),
                   new XElement(ns + "verProc", evento.IdeEvento.verProc)),
             new XElement(ns + "ideEmpregador",
                          new XElement(ns + "tpInsc", evento.IdeEmpregador.tpInsc),
                          new XElement(ns + "nrInsc", evento.IdeEmpregador.nrInsc)
                          ),
             new XElement(ns + "infoExclusao",
                          new XElement(ns + "tpEvento", evento.InfoExclusao.TpEventoField),
                          new XElement(ns + "nrRecEvt", evento.InfoExclusao.NrRecEvtField),
                          new XElement(ns + "ideTrabalhador", 
                                     new XElement(ns+"cpfTrab", evento.InfoExclusao.IdeTrabalhador.CpfTrabField)),
                          new XElement(ns+"ideFolhaPagto",
                                     new XElement("perApur", evento.InfoExclusao.IdeFolhaPagto.perApur)))
                    ))
                    //recibos

                //select recibos
                //eSocial
                ); //document                                                                                 

            pathS1210 = @"C:\temp\EvtExclusao3000.xml";
            doc.Save(pathS1210);

            // }
        }

        public static List<XElement> GetinfoIRComplemEvt1210(EvtPagtos1210 evt,XNamespace ns)
        {
            var result = new List<XElement>();

            foreach(EvtoPagtoInfoIRComplem infoIR in evt.InfoPagto.IdeBenef.InfoIRComplem)
            {
                result.Add(new XElement(ns+"infoIRComplem",
                               new XElement(ns+ "planSaude",
                                  new XElement(ns+ "cnpjOper", infoIR.PlanSaude.CnpjOper),
                                  new XElement(ns + "regANS", infoIR.PlanSaude.RegANS),
                                  new XElement(ns + "vlrSaudeTit", infoIR.PlanSaude.VlrSaudeTit))
                                  

                    ));

            }

            return result;

        }
        public static void AdicionaXmlS1200Lote(string arquivoAssinado)
        {
            XDocument doc = XDocument.Load(arquivoAssinado);
            int count = 0;                             

            Dictionary<string, string> content = new Dictionary<string, string>();
            XNamespace ns = "http://www.esocial.gov.br/schema/lote/eventos/envio/v1_1_1";
            XNamespace nsEvento = "http://www.esocial.gov.br/schema/evt/evtRemun/v_S_01_02_00";

            XDocument docLote = new XDocument(new XDeclaration("1.0", "utf-8", ""),
            new XElement(ns + "eSocial",
            new XElement(ns + "envioLoteEventos", new XAttribute("grupo", "1"),
             new XElement(ns + "ideEmpregador",
                            new XElement(ns + "tpInsc", "1"),
                            new XElement(ns + "nrInsc", "0123456")),
             new XElement(ns + "ideTransmissor",
                            new XElement(ns + "tpInsc", "1"),
                            new XElement(ns + "nrInsc", "12345678000195")),
            new XElement(ns + "eventos",
                         new XElement(ns + "evento",
                                    new XAttribute("Id", "ID1123456780000002017082410324100001"),

                                GetElementsFromXml("eSocial", nsEvento, arquivoAssinado)
                          
            )))));

            pathS1200 = @"C:\temp\EvtRemun1200_Lote.xml";
            docLote.Save(pathS1200);           
        }

        public static XElement[] GetElementsFromXml(string evento,XNamespace ns,string path)
        {
            var result = new List<XElement>();
            XDocument doc = XDocument.Load(path);
            List<XElement> xElementList = doc.Descendants(ns+evento).ToList();
            int count = 0;

            foreach (XElement element in xElementList)
            {
               
                if (element.HasElements)
                {
                    if (element.Name.LocalName.Equals(evento) && count > 2)
                    {
                        break;
                    }
                    else {
                        
                    result.Add(new XElement(element));
                    }
                }
                count++;

            }

           // for (int i = 0; i < numericUpDownNoOfAssessments.Value; i++)
           // {
             //   result.Add(new XElement("Assessment Type", (comboBoxAssessments[i] as ComboBox).Text));
             //   result.Add(new XElement("Assessment Grade", ""));
             //   result.Add(new XElement("Assessment Weighting", ""));
            //}
            return result.ToArray();
        }

        //}
        public static string AssinaXML(string noAssinatura,string path)
        {
            string _arquivo = path;
            string arquivoAssinado = String.Empty;

            if (_arquivo == null)
            {
                Console.Write("Nome do arquivo xml não informado.");
            }

            string _uri = noAssinatura;
            //
            //   le o arquivo xml
            //
            StreamReader SR;
            string _stringXml;
            SR = File.OpenText(_arquivo);
            _stringXml = SR.ReadToEnd();
            SR.Close();
            //
            //  realiza assinatura
            //
            AssinaturaDigital AD = new AssinaturaDigital();
            //
            //  cria cert
            //
            X509Certificate2 cert = new X509Certificate2();
            //
            //  seleciona certificado do repositório MY do windows
            //
            Certificado certificado = new Certificado();
            cert = certificado.BuscaNome("AUTO POSTO GLOBO LTDA");
            // X509Certificate2 cert2 = new X509Certificate2("AUTO POSTO GLOBO LTDA", "BRQ@050109");

            try
            {                
                System.Xml.XmlDocument evt1200XDoc = new XmlDocument();
                evt1200XDoc.Load(path);

                arquivoAssinado = AD.SignXmlDoc(evt1200XDoc, cert, noAssinatura);//AD.Assinar(_stringXml, _uri, cert);
                if (!String.IsNullOrEmpty(arquivoAssinado))  //sucesso
                {
                    return arquivoAssinado;
                   // string nomeArquivo = "EvtRemun1200_assinado.xml";
                  //  string caminhoDestino = "C:\\temp" + "\\" + nomeArquivo;
                    //
                    //  grava arquivo assinado
                    //
                   // StreamWriter SW;
                    //if (File.Exists(caminhoDestino))
                   // {
                     //   File.Delete(caminhoDestino.Trim());
                     //   SW = File.CreateText(caminhoDestino.Trim());
                   // }
                   // else
                   // {
                   //     SW = File.CreateText(caminhoDestino);
                   // }
                  //  SW.Write(AD.XMLStringAssinado);
                  //  SW.Close();
                   // Console.Write(AD.mensagemResultado);
                }
                else
                {
                    return arquivoAssinado;
                }
            }
            catch (Exception erro)
            {               
                throw new InvalidOperationException(erro.Message);
            }
        }

        public static void AdicionaXmlSLote(string arquivoAssinado,XNamespace nsEvento,string evento)
        {
            XDocument doc = XDocument.Load(arquivoAssinado);
            string nomeArquivo = String.Empty;

            Dictionary<string, string> content = new Dictionary<string, string>();
            XNamespace ns = "http://www.esocial.gov.br/schema/lote/eventos/envio/v1_1_1";           

            XDocument docLote = new XDocument(new XDeclaration("1.0", "utf-8", ""),
            new XElement(ns + "eSocial",
            new XElement(ns + "envioLoteEventos", new XAttribute("grupo", "1"),
             new XElement(ns + "ideEmpregador",
                            new XElement(ns + "tpInsc", "1"),
                            new XElement(ns + "nrInsc", "0123456")),
             new XElement(ns + "ideTransmissor",
                            new XElement(ns + "tpInsc", "1"),
                            new XElement(ns + "nrInsc", "12345678000195")),
            new XElement(ns + "eventos",
                         new XElement(ns + "evento",
                                    new XAttribute("Id", "ID1123456780000002017082410324100001"),

                               GetElementsFromXml("eSocial", nsEvento, arquivoAssinado)

            )))));

            switch (evento)
            {
                case "evtRemun":
                    nomeArquivo = "EvtRemun1200_assinado.xml";
                    break;

                case "evtInfoEmpregador":
                    nomeArquivo = "EvtInfoEmpregador_assinado.xml";
                    break;

                case "evtPgtos":
                    nomeArquivo = "EvtPgtos1210_assinado.xml";
                    break;
            }

            pathS1200 = @"C:\temp\" + nomeArquivo;
            docLote.Save(pathS1200);
        }

    }
}
