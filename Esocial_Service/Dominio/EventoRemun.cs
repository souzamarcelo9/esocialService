using Esocial_Service.Classes;
using Esocial_Service.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Esocial_Service.Dominio
{
    public class EventoRemun
    {
        public EvtRemun1200 PreencheEventoS_1200()
        {
            EvtRemun1200 evento1200 = new EvtRemun1200();
            DmDev recibo;
            TItemRemuneracao itemRemun;

            EventoRemunEntity evento1200Entity = new EventoRemunEntity();
            //evento1200Entity
            List<EventoRemunEntity> listaEventosDB = new List<EventoRemunEntity>();
            listaEventosDB = evento1200Entity.Get().Where(it => it.Id_projeto  == 105).ToList();

            List<EvtRemun_InfoMVEntity> listaEvtRemunInfoMV = new List<EvtRemun_InfoMVEntity>();
            List<EvtRemun_InfoMV_RemunOutrEmpEntity> listaEvtInfoMvOutEmp = new List<EvtRemun_InfoMV_RemunOutrEmpEntity>();
            List<EvtRemun_InfoComplSucesEntity> listaEvtComplemSuces = new List<EvtRemun_InfoComplSucesEntity>();
            List<EvtRemun_InfoComplEntity> listaEvtComplem = new List<EvtRemun_InfoComplEntity>();
            List<EvtRemun_ProcJudEntity> listaProcJud = new List<EvtRemun_ProcJudEntity>();
            List<EvtRemun_InfoIntermEntity> listaInfoInterm = new List<EvtRemun_InfoIntermEntity>();
            List<EvtRemun_DmDevEntity> listaDmDev = new List<EvtRemun_DmDevEntity>();
            List<EvtRemun_DmDev_IdeEstablotEntity> listaEstbLot = new List<EvtRemun_DmDev_IdeEstablotEntity>();
            List<EvtRemun_DmDev_IdeEstablotMatEntity> listaEstbLotMat = new List<EvtRemun_DmDev_IdeEstablotMatEntity>();
            List<EvtRemun_ItemRemuneracaoEntity> listaItemsRemun = new List<EvtRemun_ItemRemuneracaoEntity>();
            List<EvtRemun_DmDevAnteriorEntity> listaPeriodoAnterior = new List<EvtRemun_DmDevAnteriorEntity>();
            List<EvtRemun_DmDevAntPerRefEntity> listaPerAntPerRef = new List<EvtRemun_DmDevAntPerRefEntity>();
            List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotEntity> listaPerAntIdeEstabLot = new List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotEntity>();
            List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotMatrEntity> listaPerAntIdeEstabLotMat = new List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotMatrEntity>();
            List<EvtRemun_AnteriorEntity> listaRemunAnterior = new List<EvtRemun_AnteriorEntity>();
            List<EvtRemun_InfoComplContEntity> listaInfoComplCont = new List<EvtRemun_InfoComplContEntity>();

            foreach (var evento in listaEventosDB)
            {

                evento1200 =  new EvtRemun1200();
                //Idevento
                evento1200.Id = evento.EvtRemun;
                evento1200.IdeEvento.indRetif = 2;
                evento1200.IdeEvento.nrRecibo = evento.Recibo_nrRecibo;
                evento1200.IdeEvento.indApuracao = sbyte.Parse(evento.IdeEvento_indApuracao);
                evento1200.IdeEvento.perApur = evento.IdeEvento_perApur;
                evento1200.IdeEvento.tpAmb = 2; //setado para homologação  //tipo de ambiente 1 - Produção; 2 - Produção restrita - dados reais;3 - Produção restrita - dados fictícios.
                evento1200.IdeEvento.procEmi = 1;
                evento1200.IdeEvento.verProc = "S_1.2.0";

                //IdeEmpregador
                evento1200.IdeEmpregador = new TEmpregador();
                evento1200.IdeEmpregador.tpInsc = 1;
                evento1200.IdeEmpregador.nrInsc = "03572731000108";

                //idetrabalhador
                evento1200.IdeTrabalhador = new IdeTrabalhador();
                evento1200.IdeTrabalhador.CpfTrabField = evento.IdeTrabalhador_cpfTrab;

                //infoMV
                listaEvtRemunInfoMV = evento1200Entity.GetInfoMV()
                                                      .Where(it => it.Id_projeto == 105
                                                       && it.Id_cad_evtremun == evento.Id)
                                                       .ToList();

                foreach (var info in listaEvtRemunInfoMV)
                {
                    //se for a primeira passada nos geramos se nao nao
                    evento1200.IdeTrabalhador.InfoMV = new TInfoMV();
                    evento1200.IdeTrabalhador.InfoMV.IndMV = sbyte.Parse(info.InfoMV_indMV);
                    
                    //Obrigatório
                    //nformações relativas ao trabalhador que possui vínculo
                    //empregatício com outra(s) empresa(s)

                    listaEvtInfoMvOutEmp = evento1200Entity.GetInfoMVRemunOutrEmpresa()
                                                      .Where(it => it.Id_projeto == 105
                                                       && it.Id_cad_evtremun == evento.Id
                                                       && it.Id_infoMV == info.Id)
                                                      .ToList();

                    evento1200.IdeTrabalhador.InfoMV.RemunOutrEmpr = new List<TRemunOutrEmpr>();

                    foreach (var evtOutraEmpresa in listaEvtInfoMvOutEmp)
                    {
                        var remunOutrEmpr = new TRemunOutrEmpr();
                        remunOutrEmpr.TpInsc = sbyte.Parse(evtOutraEmpresa.RemunOutrEmpr_tpInsc);
                        remunOutrEmpr.NrInsc = evtOutraEmpresa.RemunOutrEmpr_nrInsc;
                        remunOutrEmpr.CodCateg = sbyte.Parse(evtOutraEmpresa.RemunOutrEmpr_codCateg);
                        remunOutrEmpr.VlrRemunOE = evtOutraEmpresa.RemunOutrEmpr_vlrRemunOE;

                        evento1200.IdeTrabalhador.InfoMV.RemunOutrEmpr.Add(remunOutrEmpr);
                    }

                }  //FECHA O INFOMV          

                // OPCIONAIS 
                ///Grupo preenchido quando o evento de remuneração se
                //referir a trabalhador cuja categoria não está sujeita ao
                //evento de admissão ou ao evento TSVE - Início
                evento1200.IdeTrabalhador.InfoComplem = new TInfoComplem();
                evento1200.IdeTrabalhador.InfoComplem.SucessaoVinc = new List<TSucessaoVinc>();

                listaEvtComplem = evento1200Entity.GetInfoCompl()
                                                      .Where(it => it.Id_projeto == 105
                                                       && it.Id_cad_evtremun == evento.Id)                                                       
                                                      .ToList();


                foreach (var infoComp in listaEvtComplem)
                {
                    evento1200.IdeTrabalhador.InfoComplem.NmTrab = infoComp.InfoComplem_nmTrab;///Obrigatório
                    evento1200.IdeTrabalhador.InfoComplem.DtNascto = infoComp.InfoComplem_dtNascto;///Obrigatório                                                                        

                    listaEvtComplemSuces = evento1200Entity.GetInfoComplSuces()
                                                      .Where(it => it.Id_projeto == 105
                                                       && it.Id_cad_evtremun == evento.Id
                                                       && it.Id_infoComplem == infoComp.Id)
                                                      .ToList();

                    evento1200.IdeTrabalhador.InfoComplem.SucessaoVinc = new List<TSucessaoVinc>();

                    foreach (var sucessao in listaEvtComplemSuces)
                    {
                        //Informações da sucessão de vínculo trabalhista.
                        var compSucess = new TSucessaoVinc();
                        compSucess.TpInsc = sbyte.Parse(sucessao.SucessaoVinc_tpInsc);
                        compSucess.NrInsc = sucessao.SucessaoVinc_nrInsc;
                        compSucess.MatricAnt = sucessao.SucessaoVinc_matricAnt; //Obrigatório
                        compSucess.DtAdm = sucessao.SucessaoVinc_dtAdm;
                        compSucess.Observacao = sucessao.SucessaoVinc_observacao;

                        evento1200.IdeTrabalhador.InfoComplem.SucessaoVinc.Add(compSucess);

                    }
                } // fim Info compl sucessao

                //Informações sobre a existência de processos judiciais do
                //trabalhador com decisão favorável quanto à não incidência
                //de contribuições sociais e/ou Imposto de Renda.
                listaProcJud = evento1200Entity.GetProcJudTrab()
                                                     .Where(it => it.Id_projeto == 105
                                                      && it.Id_cad_evtremun == evento.Id)
                                                     .ToList();

                evento1200.IdeTrabalhador.ProcJudTrab = new List<TProcJudTrab>();

                 foreach (var procJud in listaProcJud)
                 {
                    //Informações da sucessão de vínculo trabalhista.
                    var processoJud = new TProcJudTrab();
                    processoJud.TpTrib = sbyte.Parse(procJud.ProcJudTrab_nrProcJud);
                    processoJud.NrProcJud = procJud.ProcJudTrab_nrProcJud;
                    processoJud.CodSusp = procJud.ProcJudTrab_codSusp;

                    evento1200.IdeTrabalhador.ProcJudTrab.Add(processoJud);
                }//final s_1200_procjudtrab
                 //final s_1200_procjudtrab

                listaInfoInterm = evento1200Entity.GetInfoInterm()
                                                     .Where(it => it.Id_projeto == 105
                                                      && it.Id_cad_evtremun == evento.Id)
                                                     .ToList();

                evento1200.IdeTrabalhador.InfoInterm = new List<TInfoInterm>();

                foreach (var infoTerm in listaInfoInterm)
                {
                   
                    var info = new TInfoInterm();
                    info.Dia = int.Parse(infoTerm.InfoInterm_dia);

                    evento1200.IdeTrabalhador.InfoInterm.Add(info);
                }//final infoTerm
            
            //Inicia array de Recibos
            evento1200.DmDev = new List<DmDev>();

              listaDmDev = evento1200Entity.GetDmDev()
                                                   .Where(it => it.Id_projeto == 105
                                                    && it.Id_cad_evtremun == evento.Id)
                                                    .ToList();
            
           
              foreach (var dmDev in listaDmDev)
              {
                    //Identificação de cada um dos demonstrativos de valores devidos ao trabalhador.
                    recibo = new DmDev();
                    recibo.InfoPerApur = new TInfoPerApuracao();
                    recibo.IdeDmDev = dmDev.DmDev_ideDmDev;//Obrigatório
                    recibo.CodCategField = dmDev.DmDev_icodCateg; //Obrigatório

                    //Identificação do estabelecimento e da lotação nos quais o
                    //trabalhador possui remuneração no período de apuração
                    //$conta_lot_periodo_atual = 0;

                    listaEstbLot = evento1200Entity.GetDmDevIdeEstablot()
                                                   .Where(it => it.Id_projeto == 105
                                                    && it.Id_cad_evtremun == dmDev.Id)
                                                   .ToList();

                    foreach (var lotacao in listaEstbLot)
                    {

                        recibo.InfoPerApur.IdeEstabLot.TpInsc = lotacao.IdeEstabLot_tpInsc;//Obrigatório
                        recibo.InfoPerApur.IdeEstabLot.NrInsc = lotacao.IdeEstabLot_nrInsc;//Obrigatório
                        recibo.InfoPerApur.IdeEstabLot.CodLotacao = lotacao.IdeEstabLot_codLotacao;//Obrigatório

                        if (lotacao.IdeEstabLot_qtdDiasAv != "")
                        {
                            recibo.InfoPerApur.IdeEstabLot.QtdDiasAv = lotacao.IdeEstabLot_qtdDiasAv;

                        } //Opcional		

                        // $conta_matricula_atual = 0;

                        listaEstbLotMat = evento1200Entity.GetDmDevIdeEstablotMatricula()
                                                      .Where(it => it.Id_projeto == 105
                                                       && it.Id_dmdev_periodo_ideestablot == lotacao.Id)
                                                      .ToList();



                        foreach (var matAtual in listaEstbLotMat)
                        {
                            //Informações relativas à remuneração do trabalhador no período de apuração.
                            if (matAtual.RemunPerApur_matricula != "")
                            {
                                recibo.InfoPerApur.IdeEstabLot.RemunPerApuracao.Matricula = matAtual.RemunPerApur_matricula;//Opcional
                            }

                            if (matAtual.RemunPerApur_indSimples != "")
                            {

                                recibo.InfoPerApur.IdeEstabLot.RemunPerApuracao.IndSimples = matAtual.RemunPerApur_indSimples;//Opcional

                            }

                            listaItemsRemun = evento1200Entity.GetDmDevItemRemuneracao()
                                                     .Where(it => it.Id_projeto == 105
                                                      && it.Id_periodo_ideestablot_matricula == matAtual.Id
                                                      && it.Id_cad_evtremun == evento.Id
                                                      && it.Id_dmdev == dmDev.Id
                                                      && it.Id_dmdev_periodo_ideestablot == lotacao.Id
                                                      && it.Situacao != 1)
                                                     .ToList();

                            //recibo.InfoPerApur = new TInfoPerApuracao();
                            recibo.InfoPerApur.IdeEstabLot = new IdeEstabLot();
                            recibo.InfoPerApur.IdeEstabLot.RemunPerApuracao.RemunPerField = new List<TItemRemuneracao>();

                            foreach (var item in listaItemsRemun)
                            {
                                //Rubricas que compõem a remuneração do trabalhador.
                                var itmRemun = new TItemRemuneracao();
                                itmRemun.CodRubr = item.ItensRemun_codRubr;//obrigatorio
                                itmRemun.IdeTabRubr = item.ItensRemun_ideTabRubr;//obrigatorio                                                 

                                if (item.ItensRemun_qtdRubr != "")
                                {
                                    if (int.Parse(item.ItensRemun_qtdRubr) < 0)
                                    {
                                        itmRemun.QtdRubr = item.ItensRemun_qtdRubr.Replace("-", ""); //Opcional

                                    }
                                    else
                                    {
                                        itmRemun.QtdRubr = item.ItensRemun_qtdRubr; //Opcional
                                    }

                                }

                                if (item.ItensfatorRubr != "")
                                {
                                    itmRemun.FatorRubr = item.ItensfatorRubr;
                                }

                                //esse campo estava aqui porem no layout 1.0 noa tem esse compa vrunit somente no 2.5
                                //$std->dmdev[$conta_DmDev]->ideestablot[$conta_lot_periodo_atual]->remunperapur[$conta_matricula_atual]->itensremun[$conta_itens_rem_atual]->vrunit = $row_itens_rem_atual['itensRemun_vrRubr']; //Obrigatório
                                itmRemun.VrRubr = item.ItensRemun_vrRubr;

                                //Validação: Informação obrigatória e exclusiva se perApur >= [2021-07] (se indApuracao = [1]) ou se perApur >= [2021] (se indApuracao = [2]).
                                //NO MANUAL ESTA 2021-07 COM BASE NA COMPETENCIA A INFORMAR E NAO NO PERIODO
                                Int32 comparacao_13_salario = (int)DateTime.UtcNow.Subtract(new DateTime(2021, 1, 1)).TotalSeconds;

                                Int32 competencia_exigida = (int)DateTime.UtcNow.Subtract(new DateTime(2021, 7, 1)).TotalSeconds;
                                Int32 competencia_informar = (int)DateTime.UtcNow.Subtract(
                                    new DateTime(int.Parse(evento.IdeEvento_perApur.Substring(0, 3)),//ano
                                                 int.Parse(evento.IdeEvento_perApur.Substring(5, 6)), //mes
                                                 1)).TotalSeconds;


                                if (evento.IdeEvento_perApur.Length >= 5)
                                {
                                    if (competencia_informar >= competencia_exigida)
                                    {
                                        if (item.ItensindApurIR == "" || item.ItensindApurIR == "0")
                                        {
                                            itmRemun.IndApuracaoField = 0;//Opcional
                                        }
                                        else
                                        {
                                            itmRemun.IndApuracaoField = sbyte.Parse(item.ItensindApurIR);
                                        }
                                    }
                                    else
                                    {


                                    }

                                }
                                else
                                {
                                    if (competencia_informar >= comparacao_13_salario)
                                    {
                                        if (item.ItensindApurIR == "" || item.ItensindApurIR == "0")
                                        {
                                            itmRemun.IndApuracaoField = 0;//opcional
                                        }
                                        else
                                        {
                                            itmRemun.IndApuracaoField = sbyte.Parse(item.ItensindApurIR);
                                        }
                                    }
                                    else
                                    {


                                    }
                                }

                                //codigo de agentes nocivos so podem ser informados em uma demonstracao entao se for 0 gera senao nao
                                //rever essa condicao pois deu erro para outras transmissoes
                                if (dmDev.DmDev_icodCateg == "722" || dmDev.DmDev_icodCateg == "723" || dmDev.DmDev_icodCateg == "701")
                                {

                                }
                                else
                                {
                                    if (item.InfoAgNocivo_grauExp != "")
                                    {
                                        //Grupo referente ao detalhamento do grau de exposição do trabalhador aos agentes nocivos que ensejam a cobrança
                                        //da contribuição adicional para financiamento dos benefícios de aposentadoria especial.
                                        recibo.InfoPerApur.IdeEstabLot.RemunPerApuracao.InfoAgNocivo = new InfoAgNocivo();
                                        recibo.InfoPerApur.IdeEstabLot.RemunPerApuracao.InfoAgNocivo.grauExp = sbyte.Parse(item.InfoAgNocivo_grauExp);
                                    }

                                }
                                recibo.InfoPerApur.IdeEstabLot.RemunPerApuracao.RemunPerField.Add(itmRemun);
                                //adiciona o recibo otratado
                                evento1200.DmDev.Add(recibo);
                            }// FIM ITENS REMUNERAÇÃO
                        }// FIM listaEstbLotMat

                    } //FIM  s_1200_dmdev_periodo_ideestablot

                    listaPeriodoAnterior = evento1200Entity.GetDmDevAnteriorIdeAdc()
                                                     .Where(it => it.Id_projeto == 105                                                      
                                                      && it.Id_cad_evtremun == evento.Id
                                                      && it.Id_s_1200_dmdev == dmDev.Id)
                                                     .ToList();

                    recibo.InfoPerAnt = new TInfoPerAnt();
                    recibo.InfoPerAnt.IdeADC = new IdeADC();

                 foreach (var resultado_ideac_anterior in listaPeriodoAnterior)
                 {

                    //Identificação do instrumento ou situação ensejadora da
                    //remuneração relativa a períodos de apuração anteriores
                     if (resultado_ideac_anterior.DtAcConv == "0000-00-00")
                     {

                     }else
                     {
                       recibo.InfoPerAnt.IdeADC.DtAcConv = resultado_ideac_anterior.DtAcConv;
                     }

                        recibo.InfoPerAnt.IdeADC.TpAcConv = resultado_ideac_anterior.TpAcConv;//Obrigatório
                        recibo.InfoPerAnt.IdeADC.Dsc = resultado_ideac_anterior.Dsc; //Obrigatório
                        recibo.InfoPerAnt.IdeADC.RemunSuc = resultado_ideac_anterior.RemunSuc; //Obrigatório


                        listaPerAntPerRef = evento1200Entity.GetDmDevAnteriorIdeAdcPerRef()
                                                        .Where(it => it.Id_projeto == 105
                                                         && it.Id_dmdev_anterior_ideadc == resultado_ideac_anterior.Id)                                                         
                                                        .ToList();

                        recibo.InfoPerAnt.IdeADC.IdePeriodo = new IdePeriodo();

                      foreach ( var resultado_perref_anterior in listaPerAntPerRef)
                      {

                            //Identificação do período ao qual se referem as diferenças
                            //de remuneração.                        
                            //var perRefAnterior = new IdePeriodo();
                            recibo.InfoPerAnt.IdeADC.IdePeriodo.PerRef = resultado_perref_anterior.IdePeriodo_perRef; //Obrigatório
                            //recibo.InfoPerAnt.IdeADC.IdePeriodo.Add(perRefAnterior);

                            listaPerAntIdeEstabLot = evento1200Entity.GetDmDevAnteriorIdeAdcIdeEstabLot()
                                                        .Where(it => it.Id_projeto == 105
                                                         && it.Id_anterior_ideadc_perref == resultado_perref_anterior.Id)
                                                        .ToList();
                        
                                                                              
                              foreach (var resultado_ideestablot_anterior in listaPerAntIdeEstabLot)
                              {

                                //dentificação do estabelecimento e da lotação ao qual se
                                //referem as diferenças de remuneração do mês identificado
                                //no grupo superior.
                                recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot = new IdeEstabLot();
                                recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.TpInsc = sbyte.Parse(resultado_ideestablot_anterior.Anterior_ideEstabLot_tpInsc);
                                recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.NrInsc = resultado_ideestablot_anterior.Anterior_ideEstabLot_nrInsc;
                                recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.CodLotacao = resultado_ideestablot_anterior.Anterior_ideEstabLot_codLotacao;

                                listaPerAntIdeEstabLotMat = evento1200Entity.GetDmDevAnteriorIdeAdcIdeEstabLotMatricula()
                                                        .Where(it => it.Id_projeto == 105
                                                         && it.Id_anterior_ideadc_idePeriodo_ideEstabLot == resultado_ideestablot_anterior.Id)
                                                        .ToList();

                                recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.RemunPerAnt = new RemunPeriodoAnterior();

                                foreach (var resultado_remunperant_establot_Mat in listaPerAntIdeEstabLotMat)
                                {
                                    if(resultado_remunperant_establot_Mat.RemunPerAnt_matricula != "")
                                    {
                                        recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.RemunPerAnt.Matricula = resultado_remunperant_establot_Mat.RemunPerAnt_matricula;
                                    }
                                    
                                //Informações relativas à remuneração do trabalhador em períodos anteriores.                                
                                     
                                    if (resultado_remunperant_establot_Mat.RemunPerAnt_indSimples != "")
                                    {
                                        recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.RemunPerAnt.IndSimples = resultado_remunperant_establot_Mat.RemunPerAnt_indSimples;
                                    }

                                    listaRemunAnterior = evento1200Entity.GetDmDevRemuneracaoAnterior()
                                                        .Where(it => it.Id_anterior_ideadc_idePeriodo_ideEstabLot == resultado_remunperant_establot_Mat.Id)                                                         
                                                        .ToList();

                                    recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.RemunPerAnt.RemunPerField = new List<TItemRemuneracao>();

                                     foreach (var resultado_itensremun_anterior in listaRemunAnterior)
                                     {
                                        //Rubricas que compõem a remuneração do trabalhador.
                                        var itemRemuneracao = new TItemRemuneracao();
                                        itemRemuneracao.CodRubr = resultado_itensremun_anterior.Remuneracao_anterior_codRubr;//Obrigatório
                                        itemRemuneracao.IdeTabRubr = resultado_itensremun_anterior.Remuneracao_anterior_ideTabRubr;                                                                        

                                        if (resultado_itensremun_anterior.Remuneracao_anterior_qtdRubr != "")
                                        {
                                            itemRemuneracao.QtdRubr = resultado_itensremun_anterior.Remuneracao_anterior_qtdRubr;                                        
                                        }

                                        if (resultado_itensremun_anterior.Remuneracao_anterior_fatorRubr != "")
                                        {
                                            itemRemuneracao.FatorRubr = resultado_itensremun_anterior.Remuneracao_anterior_fatorRubr;
                                            
                                        }

                                        if (resultado_itensremun_anterior.Remuneracao_anterior_vrUnit != "")
                                        {
                                            itemRemuneracao.VrUnit = Convert.ToDecimal(resultado_itensremun_anterior.Remuneracao_anterior_vrUnit);
                                        }

                                        itemRemuneracao.VrRubr = Convert.ToDecimal(resultado_itensremun_anterior.Remuneracao_anterior_vrRubr);


                                  //Validação: Informação obrigatória e exclusiva se perApur >= [2021-07] (se indApuracao = [1]) ou se perApur >= [2021] (se indApuracao = [2]).
                                  //NO MANUAL ESTA 2021-07 COMP BASE NA COMPETENCIA ATUAL INFORMADO E NAO NO PERIODO
                                  Int32 comparacao_13_salario = (int)DateTime.UtcNow.Subtract(new DateTime(2021, 1, 1)).TotalSeconds;

                                  Int32 competencia_exigida = (int)DateTime.UtcNow.Subtract(new DateTime(2021, 7, 1)).TotalSeconds;
                                  Int32 competencia_informar = (int)DateTime.UtcNow.Subtract(
                                            new DateTime(int.Parse(evento.IdeEvento_perApur.Substring(0, 3)),//ano
                                                         int.Parse(evento.IdeEvento_perApur.Substring(5, 6)), //mes
                                                         1)).TotalSeconds;
                                      
                                        if (evento.IdeEvento_perApur.Length >= 5)
                                        {
                                            if ( competencia_informar >= competencia_exigida)
                                            {
                                                if (resultado_itensremun_anterior.Remuneracao_anterior_indApurIR == "" 
                                                    || resultado_itensremun_anterior.Remuneracao_anterior_indApurIR == "0")
                                                {
                                                    itemRemuneracao.IndApuracaoField = 0;
                                                 
                                                }else
                                                {
                                                    itemRemuneracao.IndApuracaoField = sbyte.Parse(resultado_itensremun_anterior.Remuneracao_anterior_indApurIR); //Obrigatório  APARTIR DE 07/2021 POR ISSO CRIAR ESSA TABELA NO BANCO
                                                }

                                            }
                                        }
                                        else
                                        {

                                         if (competencia_informar >= 2021)
                                         {
                                            if (resultado_itensremun_anterior.Remuneracao_anterior_indApurIR == "" 
                                              || resultado_itensremun_anterior.Remuneracao_anterior_indApurIR == "0")
                                            {
                                                    itemRemuneracao.IndApuracaoField = 0;
                                             }
                                             else
                                             {
                                                    itemRemuneracao.IndApuracaoField = sbyte.Parse(resultado_itensremun_anterior.Remuneracao_anterior_indApurIR); //Obrigatório  APARTIR DE 07/2021 POR ISSO CRIAR ESSA TABELA NO BANCO
                                             }

                                         }

                                        }

                                        //Grupo referente ao detalhamento do grau de exposição do trabalhador aos agentes nocivos que ensejam a cobrança
                                        //da contribuição adicional para financiamento dos benefícios de aposentadoria especial.
                                        recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.RemunPerAnt.InfoAgNocivo = new InfoAgNocivo();
                                        recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.RemunPerAnt.InfoAgNocivo.grauExp = sbyte.Parse(resultado_itensremun_anterior.InfoAgNocivo_grauExp);

                                        recibo.InfoPerAnt.IdeADC.IdePeriodo.IdeEstabLot.RemunPerAnt.RemunPerField.Add(itemRemuneracao);
                                    }//final s_1200_remuneracao_anterior
                                    recibo.InfoPerAnt.IdeADC.IdePeriodo = recibo.InfoPerAnt.IdeADC.IdePeriodo;
                                }//final remunperant_establot_Mat

                            }//final s_1200_dmdev_anterior_ideadc_ideperiodo_ideestablot_matricula
                        }//final s_1200_dmdev_anterior_ideadc_ideperiodo_ideestablot_matricula

                    }

                    listaInfoComplCont = evento1200Entity.GetInfoComplCont()
                                                      .Where(it => it.Id_projeto == 105 &&
                                                       it.Id_dmdev == evento.Id)
                                                      .ToList();


                    foreach (var infocomplcont in listaInfoComplCont)
                    {
                        //Grupo preenchido exclusivamente quando o evento de
                        //remuneração se referir a trabalhador cuja categoria não
                        //estiver obrigada ao evento de início de TSVE e se não
                        //houver evento S-2300 correspondente.
                        recibo.InfoComplCont = new TInfoComplCont();
                        recibo.InfoComplCont.CodCBO = infocomplcont.InfoComplCont_codCBO;//Obrigatório
                        recibo.InfoComplCont.NatAtividade = infocomplcont.InfoComplCont_natAtividade;//Obrigatório
                        recibo.InfoComplCont.QtdDiasTrab = infocomplcont.InfoComplCont_qtdDiasTrab;//Obrigatório                                
                    }                


             }//RECIBOS - DMDEV{}
             

            }// foreach eventos1200 - PRINCIPAL

            return evento1200;
           
        }

        public string GeraXmlEvento1200(EvtRemun1200 evento)
        {
            string pathS1200;
            XNamespace ns = "http://www.esocial.gov.br/schema/evt/evtRemun/v_S_01_02_00";
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", ""),
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
                                  new XElement(ns + "tpInsc", dmDev.InfoPerApur.IdeEstabLot.TpInsc),
                                  new XElement(ns + "nrInsc", dmDev.InfoPerApur.IdeEstabLot.NrInsc),
                                  new XElement(ns + "codLotacao", dmDev.InfoPerApur.IdeEstabLot.CodLotacao),
                                  new XElement(ns + "remunPerApur",
                             new XElement(ns + "matricula", dmDev.InfoPerApur.IdeEstabLot.RemunPerApuracao.Matricula),
                 dmDev.InfoPerApur.IdeEstabLot.RemunPerApuracao.RemunPerField.Select(itemRemun =>
                                        new XElement(ns + "itensRemun",
                                         new XElement(ns + "codRubr", itemRemun.CodRubr),
                                         new XElement(ns + "ideTabRubr", itemRemun.IdeTabRubr),
                                         new XElement(ns + "qtdRubr", itemRemun.QtdRubr),
                                         new XElement(ns + "vrRubr", itemRemun.VrRubr),
                                         new XElement(ns + "indApurIR", itemRemun.IndApuracaoField))),
                                   new XElement(ns + "infoAgNocivo",
                                        new XElement(ns + "grauExp", dmDev.InfoPerApur.IdeEstabLot.RemunPerApuracao.InfoAgNocivo.grauExp))
                                   )
                              ))
                             ) //recibos

                         )//select recibos
                       )) //eSocial
                    ); //document                                                                                 


            //Console.WriteLine(doc);

            pathS1200 = @"C:\temp\EvtRemun1200.xml";
            doc.Save(pathS1200);

            return pathS1200;
            // }
        }

    }
}
