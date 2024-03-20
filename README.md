# esocialService
Serviço para envio de arquivos esocial - C# .net
Sistema realiza a seleção dos dados de profissionais, monta o xml correspondente,assina com o certificado digital, e faz o envio pelo web service.

Acessando os serviços do eSocial na web (Web Services)

URL dos serviços do eSocial (Web Services)
Os endereços para acessar os dois serviços do eSocial (Envio de Lote e Consulta de Lote) estão disponíveis na última página no Manual de Orientação do Desenvolvedor (item 7.8), a partir da versão 1.3 (link para documentação técnica) e na página sobre a Produção Restrita, no Portal do eSocial, mas também podem ser acessados logo abaixo.

URL do Web Service de Envio de Lotes:
https://webservices.producaorestrita.esocial.gov.br/servicos/empregador/enviarloteeventos/WsEnviarLoteEventos.svc

URL do Web Service de Consulta de Resultado de Processamento de Lotes:
https://webservices.producaorestrita.esocial.gov.br/servicos/empregador/consultarloteeventos/WsConsultarLoteEventos.svc

O Manual de Orientação do Desenvolvedor informa que o domínio (URL base) que será usado para os Web Services de produção é webservices.esocial.gov.br.



Certificados digitais necessários para acessar os serviços do eSocial (Web Services)
Ao acessar esses endereços via browser mesmo, será solicitado um certificado digital. Ao acessar pela primeira vez, provavelmente o browser avisará que o endereço é inseguro e mostrará um cadeado vermelho. Se via browser estiver assim você também terá problemas para acessar o serviço via código.

Para resolver esse problema de segurança, é necessário instalar na máquina 3 certificados disponibilizados pelo Serpro. Essa instrução também está descrita na última página do Manual de Orientação do Desenvolvedor (item 7.10). Os 3 certificados que devem ser instalados estão no item Cadeia de Certificados emitida em 06/02/2017, no link:
https://certificados.serpro.gov.br/serproacf/certificate-chain
No Windows, esses 3 certificados do Serpro devem ser instalados no repositório (store) Autoridades de Certificação Raiz Confiáveis (Trusted Root Certification Authorities), da Máquina Local (Local Computer). Com isso, ao acessar o endereço do serviço pelo browser, o cadeado do https passa a ficar verde, e o browser passa a indicar que o endereço é seguro. Depois disso o acesso ao serviço via código também fica livre de erros de segurança/certificado.

Atualização: O governo publicou o item 21 na página de Perguntas Frequentes - Produção Restrita, que diz que a Autoridade Certificadora Raiz Brasileira v5 deve ser instalada no repositório AC Raiz e a Autoridade Certificadora SERPRO v4 e a Autoridade Certificadora do SERPRO Final v5 devem ser instaladas no repositório de AC Intermediária.

Lembrando que, para acessar o serviço e assinar os XMLs de eventos, também é necessário ter instalado na máquina um certificado digital do empregador. Ao instalar o seu certificado digital no Windows, é necessário selecionar a opção Marcar esta chave como exportável (Mark this key as exportable) e instala-lo no repositório (store) Pessoal (Personal), do Usuário Atual (Current User).



Contrato dos serviços do eSocial (Web Services)
Para facilitar a comunicação com os serviços é necessário usar um arquivo WSDL (Web Services Description Language), que define o contrato com o serviço, ou a estrutura do serviço (define que informações o serviço espera receber, e em que formato ele espera, e que informações o serviço irá devolver, e em qual formato).

Para adicionar uma referência ao serviço web no ambiente de desenvolvimento (Add Service Reference), é possível usar aquelas mesmas duas URLs de acesso aos serviços, adicionando o parâmetro ?singleWsdl ao final dos dois endereços:
https://webservices.producaorestrita.esocial.gov.br/servicos/empregador/enviarloteeventos/WsEnviarLoteEventos.svc?singleWsdl https://webservices.producaorestrita.esocial.gov.br/servicos/empregador/consultarloteeventos/WsConsultarLoteEventos.svc?singleWsdl
Também é possível usar os dois arquivos WSDL (WsEnviarLoteEventos-v1_1_0.wsdl e WsConsultarLoteEventos-v1_1_0.wsdl) disponibilizados no Pacote de Comunicação do eSocial (última versão 1.3.3) que se encontra na página da documentação técnica do Portal do eSocial.

Em ambos os casos, o endereço da URL do serviço está errado e precisa ser corrigido. Atualização: A partir de 20/07/2017 o endereço do serviço foi corrigido no WSDL online, mas no Pacote de Comunicação continua errado.

Se você está usando o Visual Studio, você pode usar o comando Add Service Reference e informar a URL citada acima, ou pode informar o caminho completo do arquivo WSDL, que pode ter sido baixado da URL ou pode ter vindo do Pacote de Comunicação. Essa ferramenta criará uma classe cliente para consumir o serviço na web, que herda a classe System.ServiceModel.ClientBase.

Também é possível usar a ferramenta de linha de comando svcutil.exe, que também criará uma classe cliente herdando a classe System.ServiceModel.ClientBase. Alternativamente também é possível usar a ferramenta de linha de comando wsdl.exe, mais antiga, para serviços da época do .NET Framework 2, baseados em ASMX, que também criará uma classe cliente, mas dessa vez herdando a classe System.Web.Services.Protocols.SoapHttpClientProtocol.

O link abaixo contém um exemplo de como consumir um serviço com um objeto cliente herdando System.ServiceModel.ClientBase (o resultado dos comandos Add Service Reference ou svcutil.exe), e usando certificado digital. Só é necessário alterar o uso da classe System.ServiceModel.WSHttpBinding para System.ServiceModel.BasicHttpBinding, ou BasicHttpsBinding, porque WSHttpBinding é para SOAP 1.2, e o eSocial usa o padrão SOAP 1.1. Como o WSDL online agora traz o endereço correto do serviço, também não seria necessário configurar o objeto EndpointAddress:
Transport Security with Certificate Authentication - Configure the Client
