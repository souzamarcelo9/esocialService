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
using Esocial_Service.Dominio;

namespace Esocial_Service
{
    class Program
    {
        public static string pathS1200;
        public static string pathS1210;
        public static string xmlns1200 = "http://www.esocial.gov.br/schema/evt/evtRemun/v_S_01_02_00";
        public static string xmlns1210 = "http://www.esocial.gov.br/schema/evt/evtPgtos/v_S_01_02_00";
        public static string xmlns2299 = "http://www.esocial.gov.br/schema/evt/evtDeslig/v_S_01_02_00";
        public static string xmlns3000 = "http://www.esocial.gov.br/schema/evt/evtExclusao/v_S_01_01_00";

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

      

        public static void S_1200()
        {            
            string arquivoAssinado = String.Empty;
            string xmlEvento = String.Empty;
            EventoRemun eventoRemunDomain = new EventoRemun();
            EvtRemun1200 eventoRemun = eventoRemunDomain.PreencheEventoS_1200();
            xmlEvento = eventoRemunDomain.GeraXmlEvento1200(eventoRemun);
            arquivoAssinado = XmlUtil.AssinaXML("evtRemun", xmlEvento);

            pathS1200 = EnvioLoteEventos.AdicionaXmlSLote(arquivoAssinado, xmlns1200,"evtRemun");
            //
            EsocialService.EnviaLoteEventos(pathS1200,false);
        }

        public static void S_2299()
        {
            string arquivoAssinado = String.Empty;
            string xmlEvento = String.Empty;
            EventoDeslig eventoDesligDomain = new EventoDeslig();
            EvtDeslig2299 evento2299 = eventoDesligDomain.PreencheEventoS_2299();
            xmlEvento = eventoDesligDomain.GeraXmlEvento2299(evento2299);
            arquivoAssinado = XmlUtil.AssinaXML("evtDeslig", xmlEvento);
            pathS1200 = EnvioLoteEventos.AdicionaXmlSLote(arquivoAssinado, xmlns2299, "evtDeslig");
            //
            EsocialService.EnviaLoteEventos(pathS1200,false);
        }

        public static void S_1210()
        {   //inclusão
            string arquivoAssinado = String.Empty;
            string xmlEvento = String.Empty;
            EventoPagtos evtPagtoDomain = new EventoPagtos();
            EvtPgtos1210 evento1210 = evtPagtoDomain.PreencheEventoS_1210();
            xmlEvento = evtPagtoDomain.GeraXmlEvento1210(evento1210);
            arquivoAssinado = XmlUtil.AssinaXML("evtPgtos", xmlEvento);
            pathS1200 =  EnvioLoteEventos.AdicionaXmlSLote(arquivoAssinado, xmlns1210, "evtPgtos");
            //
            EsocialService.EnviaLoteEventos(pathS1200,false);

        }

        public static void S_3000()
        {
            //Exclusão
            string arquivoAssinado = String.Empty;  
            string xmlEvento = String.Empty;
            EventoExclusao evtExclusaoDomain = new EventoExclusao();
            EvtExclusao3000 eventoExclusao = evtExclusaoDomain.PreencheEventoS_3000();
            xmlEvento = evtExclusaoDomain.GeraXmlEvento3000(eventoExclusao);            
            arquivoAssinado = XmlUtil.AssinaXML("evtExclusao", xmlEvento);
            pathS1200 = EnvioLoteEventos.AdicionaXmlSLote(arquivoAssinado,xmlns3000, "evtExclusao");
            //
            EsocialService.EnviaLoteEventos(pathS1200,false);
        }                                                        
        
        
        
    }
}
