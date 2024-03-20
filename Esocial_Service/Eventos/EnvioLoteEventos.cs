using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Esocial_Service.Eventos
{
    public class EnvioLoteEventos
    {
        public static string AdicionaXmlSLote(string arquivoAssinado, XNamespace nsEvento, string evento)
        {
            XDocument doc = XDocument.Load(arquivoAssinado);
            string nomeArquivo = String.Empty;
            string arquivoLote = String.Empty;

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

                               XmlUtil.GetElementsFromXml("eSocial", nsEvento, arquivoAssinado)

            )))));

            switch (evento)
            {
                case "evtRemun":
                    nomeArquivo = "EvtRemun1200_Lote.xml";
                    break;

                case "evtInfoEmpregador":
                    nomeArquivo = "EvtInfoEmpregador_Lote.xml";
                    break;

                case "evtPgtos":
                    nomeArquivo = "EvtPgtos1210_Lote.xml";
                    break;

                case "evtExclusao":
                    nomeArquivo = "EvtExclusao3000_Lote.xml";
                    break;

                case "evtDeslig":
                    nomeArquivo = "EvtDeslig2299_Lote.xml";
                    break;
            }

            arquivoLote = @"C:\temp\" + nomeArquivo;
            docLote.Save(arquivoLote);
            return arquivoLote;
        }
    }
}
