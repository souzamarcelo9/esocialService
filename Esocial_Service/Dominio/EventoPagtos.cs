using Esocial_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Esocial_Service.Dominio
{
    public class EventoPagtos
    {
        public EvtPgtos1210 PreencheEventoS_1210()
        {
            EvtPgtos1210 evento1210 = new EvtPgtos1210();
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

            infoPagto.DetPgtoFl = new EvtPgtosIdeBenefInfoPgtoDetPgtoFl();
            infoPagto.DetPgtoFl.perRef = "2023-05";
            infoPagto.DetPgtoFl.ideRecPgto = "5";
            infoPagto.DetPgtoFl.vlrPgto = 1067.28M;
            evento1210.InfoPagto.IdeBenef.InfoPgto.Add(infoPagto);

            infoPagto = new EvtPgtosIdeBenefInfoPgto();

            infoPagto.DtPgto = "2023-06-07";
            infoPagto.TpPgto = 1;
            infoPagto.DetPgtoFl = new EvtPgtosIdeBenefInfoPgtoDetPgtoFl();
            infoPagto.DetPgtoFl.perRef = "2023-06";
            infoPagto.DetPgtoFl.ideRecPgto = "6";
            infoPagto.DetPgtoFl.vlrPgto = 9071.98M;

            //informação ir complementar
            evento1210.InfoPagto.IdeBenef.InfoIRComplem = new List<EvtoPagtoInfoIRComplem>();

            evento1210.InfoPagto.IdeBenef.InfoPgto.Add(infoPagto);

            return evento1210;
            
        }
                
        public string GeraXmlEvento1210(EvtPgtos1210 evento)
        {
            string caminhoArquivo = String.Empty;
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtPgtos/v_S_01_02_00";
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", ""),
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
                     GetinfoIRComplemEvt1210(evento, ns)
                    ))
                   ) //recibos

                //select recibos
                //eSocial
                ); //document                                                                                 


            caminhoArquivo = @"C:\temp\EvtPgto1210.xml";
            doc.Save(caminhoArquivo);
            return caminhoArquivo;
            // }
        }

        public  List<XElement> GetinfoIRComplemEvt1210(EvtPgtos1210 evt, XNamespace ns)
        {
            var result = new List<XElement>();

            foreach (EvtoPagtoInfoIRComplem infoIR in evt.InfoPagto.IdeBenef.InfoIRComplem)
            {
                result.Add(new XElement(ns + "infoIRComplem",
                               new XElement(ns + "planSaude",
                                  new XElement(ns + "cnpjOper", infoIR.PlanSaude.CnpjOper),
                                  new XElement(ns + "regANS", infoIR.PlanSaude.RegANS),
                                  new XElement(ns + "vlrSaudeTit", infoIR.PlanSaude.VlrSaudeTit))


                    ));

            }

            return result;

        }

    }
}
