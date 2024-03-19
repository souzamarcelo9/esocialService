using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Esocial_Service
{
    public class AssinaturaDigital
    {
        public string SignXmlDoc(XmlDocument xmlDoc, X509Certificate2 certificate,string evento)
        {            
            string nomeArquivo = String.Empty;
            //
            // https://docs.microsoft.com/en-us/dotnet/framework/whats-new/#Crypto462
            //
            // SignedXml support for SHA-2 hashing The .NET Framework 4.6.2 adds support
            // to the SignedXml class for RSA-SHA256, RSA-SHA384, and RSA-SHA512 PKCS#1
            // signature methods, and SHA256, SHA384, and SHA512 reference digest algorithms.
            //
            // Any programs that have registered a custom SignatureDescription handler into CryptoConfig
            // to add support for these algorithms will continue to function as they did in the past, but
            // since there are now platform defaults, the CryptoConfig registration is no longer necessary.
            //
            //// First of all, we need to register a SignatureDescription class that defines the DigestAlgorithm as SHA256.
            //// You have to reference the System.Deployment assembly in your project.
            //CryptoConfig.AddAlgorithm(
            //   typeof(System.Deployment.Internal.CodeSigning.RSAPKCS1SHA256SignatureDescription),
            //   "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256");
            // RSAPKCS1SHA256SignatureDescription -> Disponível desde .NET Framework 4.5

            SignedXml signedXml = new SignedXml(xmlDoc);

            // Add the key to the SignedXml document. 
            signedXml.SigningKey = certificate.GetRSAPrivateKey();   // Disponível desde .NET Framework 4.6
                                                                     //signedXml.SigningKey = GetRSAPrivateKey(certificate);

            //
            // https://docs.microsoft.com/en-us/dotnet/framework/whats-new/#Crypto462
            //
            // SignedXml support for SHA-2 hashing The .NET Framework 4.6.2 adds support
            // to the SignedXml class for RSA-SHA256, RSA-SHA384, and RSA-SHA512 PKCS#1
            // signature methods, and SHA256, SHA384, and SHA512 reference digest algorithms.
            signedXml.SignedInfo.SignatureMethod = SignedXml.XmlDsigRSASHA256Url; //"http://www.w3.org/2001/04/xmldsig-more#rsa-sha256"

            // Create a reference to be signed. Pass "" to specify that
            // all of the current XML document should be signed.
            Reference reference = new Reference(string.Empty);

            reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
            reference.AddTransform(new XmlDsigC14NTransform());
            reference.DigestMethod = SignedXml.XmlDsigSHA256Url; //""http://www.w3.org/2001/04/xmlenc#sha256"

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            signedXml.KeyInfo = new KeyInfo();
            // Load the certificate into a KeyInfoX509Data object
            // and add it to the KeyInfo object.
            signedXml.KeyInfo.AddClause(new KeyInfoX509Data(certificate));

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

            if (xmlDoc.FirstChild is XmlDeclaration)
                xmlDoc.RemoveChild(xmlDoc.FirstChild);

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

                case "evtExclusao":
                    nomeArquivo = "EvtExclusao1210_assinado.xml";
                    break;

                case "evtDeslig":
                    nomeArquivo = "EvtDeslig2299_assinado.xml";
                    break;

                default:
                    nomeArquivo = "";
                    break;
                    
            }

            nomeArquivo = @"C:/temp/" + nomeArquivo;
            xmlDoc.Save(nomeArquivo);

            return nomeArquivo;
        }


        public int Assinar(string XMLString, string RefUri, X509Certificate2 X509Cert)
        /*
         *     Entradas:
         *         XMLString: string XML a ser assinada
         *         RefUri   : Referência da URI a ser assinada (Ex. infNFe
         *         X509Cert : certificado digital a ser utilizado na assinatura digital
         * 
         *     Retornos:
         *         Assinar : 0 - Assinatura realizada com sucesso
         *                   1 - Erro: Problema ao acessar o certificado digital - %exceção%
         *                   2 - Problemas no certificado digital
         *                   3 - XML mal formado + exceção
         *                   4 - A tag de assinatura %RefUri% inexiste
         *                   5 - A tag de assinatura %RefUri% não é unica
         *                   6 - Erro Ao assinar o documento - ID deve ser string %RefUri(Atributo)%
         *                   7 - Erro: Ao assinar o documento - %exceção%
         * 
         *         XMLStringAssinado : string XML assinada
         * 
         *         XMLDocAssinado    : XMLDocument do XML assinado
         */
        {
            int resultado = 0;
            msgResultado = "Assinatura realizada com sucesso.";
            try
            {
                //   certificado para ser utilizado na assinatura
                //
                string _xnome = "";//NRIO0205FTS
                if (X509Cert != null)
                {
                    _xnome = X509Cert.Subject.ToString();
                }
                X509Certificate2 _X509Cert = new X509Certificate2();
                X509Store store = new X509Store("MY", StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
                X509Certificate2Collection collection1 = (X509Certificate2Collection)collection.Find(X509FindType.FindBySubjectDistinguishedName, _xnome, false);
                if (collection1.Count == 0)
                {
                    resultado = 2;
                    msgResultado = "Problemas no certificado digital.";
                }
                else
                {
                    // certificado ok
                    _X509Cert = collection1[0];
                    string x;
                    x = _X509Cert.GetKeyAlgorithm().ToString();
                    // Cria o documento xml.
                    XmlDocument doc = new XmlDocument();

                    // Formata o documento para ignorar os espaços em branco.
                    doc.PreserveWhitespace = false;

                    // Carrega o arquivo xml usando seu nome.
                    try
                    {
                        doc.LoadXml(XMLString);

                        // Verifica se a tag a ser assinada existe é única
                        int qtdeRefUri = doc.GetElementsByTagName(RefUri).Count;

                        if (qtdeRefUri == 0)
                        {
                            //  a URI indicada não existe
                            resultado = 4;
                            msgResultado = "A tag de assinatura " + RefUri.Trim() + " inexiste.";
                        }
                        // Exsiste mais de uma tag a ser assinada
                        else
                        {
                            if (qtdeRefUri > 1)
                            {
                                // existe mais de uma URI indicada
                                resultado = 5;
                                msgResultado = "A tag de assinatura " + RefUri.Trim() + " não é unica.";

                            }

                            else
                            {
                                try
                                {
                                    // Cria um xml assinado.
                                    SignedXml signedXml = new SignedXml(doc);

                                    // Adiciona a chave ao xml assinado
                                    signedXml.SigningKey = _X509Cert.PrivateKey;
                                    if (signedXml.SigningKey == null)
                                        throw new InvalidOperationException("O certificado possui chaves inválidas.");


                                    // Cria uma referência para a assinatura.
                                    Reference reference = new Reference();

                                    // pega o uri que deve ser assinada
                                    XmlAttributeCollection _Uri = doc.GetElementsByTagName(RefUri).Item(0).Attributes;
                                    foreach (XmlAttribute _atributo in _Uri)
                                    {
                                        if (_atributo.Name == "Id")
                                        {
                                            reference.Uri = "#" + _atributo.InnerText;
                                        }
                                    }

                                    //Adiciona uma transformação envelopada para a referência

                                    XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                                    reference.AddTransform(env);

                                    XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
                                    reference.AddTransform(c14);

                                    // Adiciona uma referência para o xml assinado.
                                    signedXml.AddReference(reference);

                                    // Cria um objeto keyinfo
                                    KeyInfo keyInfo = new KeyInfo();

                                    // Carrega o certificado para uma keyinfo do tipo x509
                                    // e adiciona para o objeto keyinfo
                                    keyInfo.AddClause(new KeyInfoX509Data(_X509Cert));

                                    // Adiciona o objeto keyinfo para a assinatura xml.
                                    signedXml.KeyInfo = keyInfo;

                                    signedXml.ComputeSignature();

                                    //Obtém a representação xml da assinatura e salva no 
                                    // elemento xmlElement
                                    XmlElement xmlDigitalSignature = signedXml.GetXml();

                                    //Appenda o elemento para o documento xml.
                                    if (RefUri == "evtRemun")
                                    {
                                        XmlNode evtRemun = doc.GetElementsByTagName("evtRemun")[0];                                       
                                        evtRemun.AppendChild(xmlDigitalSignature);
                                    }
                                    else
                                    {
                                        doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));
                                    }

                                    XMLDoc = new XmlDocument();
                                    XMLDoc.PreserveWhitespace = false;
                                    XMLDoc = doc;
                                }
                                catch (Exception caught)
                                {
                                    resultado = 7;
                                    msgResultado = "Erro: Ao assinar o documento - " + caught.Message;
                                }
                            }
                        }
                    }
                    catch (Exception caught)
                    {
                        resultado = 3;
                        msgResultado = "Erro: XML mal formado - " + caught.Message;
                    }
                }
            }
            catch (Exception caught)
            {
                resultado = 1;
                msgResultado = "Erro: Problema ao acessar o certificado digital" + caught.Message;
            }

            return resultado;
        }
        //
        // mensagem de Retorno
        //
        private string msgResultado;
        private XmlDocument XMLDoc;

        public XmlDocument XMLDocAssinado
        {
            get { return XMLDoc; }
        }

        public string XMLStringAssinado
        {
            get { return XMLDoc.OuterXml; }
        }

        public string mensagemResultado
        {
            get { return msgResultado; }
        }

    }

}
