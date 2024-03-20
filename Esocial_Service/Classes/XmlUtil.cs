using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Esocial_Service.Classes
{
    public class XmlUtil : System.Xml.XmlElement
    {
        public XmlUtil(string prefix, string localName, string namespaceURI, XmlDocument doc) : base(prefix, localName, namespaceURI, doc)
        {
        }

        public static void AddXmlns(string path)
        {
            var xmldoc = new XmlDocument();

            xmldoc.LoadXml(path);

            xmldoc.DocumentElement.SetAttribute("xmlns", "http://www.esocial.gov.br/schema/evt/evtRemun/v_S_01_02_00");
            xmldoc.Save(@"C:\temp\temp.xml");
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

        public static XmlNodeList getXmlNodeList(string XmlNodeName, XmlDocument doc)
        {
            XmlNodeList elemList = doc.GetElementsByTagName(XmlNodeName);
            return elemList;
        }

        public static XElement[] GetElementsFromXml(string evento, XNamespace ns, string path)
        {
            var result = new List<XElement>();
            XDocument doc = XDocument.Load(path);
            List<XElement> xElementList = doc.Descendants(ns + evento).ToList();
            int count = 0;

            foreach (XElement element in xElementList)
            {

                if (element.HasElements)
                {
                    if (element.Name.LocalName.Equals(evento) && count > 2)
                    {
                        break;
                    }
                    else
                    {

                        result.Add(new XElement(element));
                    }
                }
                count++;

            }

          
            return result.ToArray();
        }

        public static string AssinaXML(string noAssinatura, string path)
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


    }
}
