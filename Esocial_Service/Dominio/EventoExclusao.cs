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
    public class EventoExclusao
    {
        public EvtExclusao3000 PreencheEventoS_3000()
        {
            EvtExclusao3000 evento3000 = new EvtExclusao3000();

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

            return evento3000;
           
        }

        public string GeraXmlEvento3000(EvtExclusao3000 evento)
        {
            string caminhoArquivo = String.Empty;
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtExclusao/v_S_01_02_00";
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", ""),
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
                                     new XElement(ns + "cpfTrab", evento.InfoExclusao.IdeTrabalhador.CpfTrabField)),
                          new XElement(ns + "ideFolhaPagto",
                                     new XElement(ns+"perApur", evento.InfoExclusao.IdeFolhaPagto.perApur)))
                    ))
                //recibos

                //select recibos
                //eSocial
                ); //document                                                                                 

            caminhoArquivo = @"C:\temp\EvtExclusao3000.xml";
            doc.Save(caminhoArquivo);
            return caminhoArquivo;

            // }
        }


    }
}
