using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Esocial_Service.Classes;
using System.Xml.Linq;
using System.Collections;
using System.Net;
using System.ServiceModel;

namespace Esocial_Service.Service
{
    public class EsocialService
    {
        public static void EnviaLoteEventos(string path,bool producao)
        {
            
            // Carrega o certificado digital a partir de um arquivo PFX, informando a senha.
            //X509Certificate2 x509Cert = new X509Certificate2(caminhoArquivoPfx, senhaArquivoPfx);
            X509Certificate2 cert = new X509Certificate2();
            //
            //  seleciona certificado do repositório MY do windows
            //
            Certificado certificado = new Certificado();
            cert = certificado.BuscaNome("AUTO POSTO GLOBO LTDA");

            // Carrega o XML de lote a partir de um arquivo.
            // Mas os XMLs dos eventos devem ser assinados digitalmente antes de inseridos no XML de lote.
            // Para isso é possível usar a função SignXmlDoc()
            XDocument loteEventosXDoc = XDocument.Load(path);

            var urlServicoEnvio = @"https://webservices.producaorestrita.esocial.gov.br/servicos/empregador/enviarloteeventos/WsEnviarLoteEventos.svc";
            //  if (producao)
            //    urlServicoEnvio = String.Format(urlServicoEnvio, "eSocial");
            //else
            //  urlServicoEnvio = String.Format(urlServicoEnvio, "preprodefdeSocial");

            var address = new EndpointAddress(urlServicoEnvio);
            // BasicHttpsBinding está disponível somente a partir do .NET Framework 4.5.
            // Se estiver usando uma versão anterior, use a linha comentada abaixo.
            //var binding = new BasicHttpBinding(BasicHttpsSecurityMode.Transport);
            var binding = new BasicHttpsBinding();

            // Informa que será usado um certificado digital para acessar o serviço.
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls |
                                SecurityProtocolType.Tls11 |
                                SecurityProtocolType.Tls12;

            // Cria o objeto cliente (do tipo System.ServiceModel.ClientBase) para acesso ao WebService.
            var wsClient = new WsEnviarLoteEventos.ServicoEnviarLoteEventosClient(binding, address);
            // Passa o certificado digital para o objeto do tipo System.ServiceModel.ClientBase.
            wsClient.ClientCredentials.ClientCertificate.Certificate = cert;

            wsClient.Open();
            // Chama o WebService de fato, passando o XML do lote.
            // O método espera um objeto do tipo XElement, e retorna outro objeto XElement.
            var retornoEnvioXElement = wsClient.EnviarLoteEventos(loteEventosXDoc.Root);
            RecepcionaLoteRetorno(retornoEnvioXElement,path);
            wsClient.Close();

        }

        private static void RecepcionaLoteRetorno(XElement retorno,string nome)
        {
            //salva no disco
            
            retorno.Save(@"C:\temp\" + "Retorno_" + nome);
        }
    }
}
