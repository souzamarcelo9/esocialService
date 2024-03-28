using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;
using Esocial_Service.Database;

namespace Esocial_Service.Entidades
{
    public class EventoRemunEntity
    {
        int id;
        int id_transmissor;
        int id_projeto;
        int id_usuario { get; set; }
        string evtRemun;
        int ideEvento_indRetif;

        string ideEvento_nrRecibo;

        string ideEvento_indApuracao;

        string ideEvento_perApur;
        int ideEvento_tpAmb;
        int ideEvento_procEmi;
        string ideEvento_verProc;
        int ideEmpregador_tpInsc;
        string ideEmpregador_nrInsc;
        string ideTrabalhador_cpfTrab;
        string ideTrabalhador_nisTrab;
        string recibo_nrRecibo;
        string recibo_hash;
        DateTime recepcao_processamento_dhProcessamento;
        int situacao_retificar;
        string codigo_resposta;
        string descricao_resposta;
        string data_hora_retificacao;
        string nome_arquivo_retificacao;
        string dadosrecepcaolote_protocoloenvio;
        string codigo_recepcao;
        string descricao_recepcao_lote;
        string processamento_recibo_nrRecibo;
        string original_numero_lote;
        string versao_layout_evtRemun;
        string trabalho_intermitente_quantidade_dias;
        int id_cadastro_envios;
        string nome_arquivo_importado;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Id_transmissor
        {
            get
            {
                return id_transmissor;
            }

            set
            {
                id_transmissor = value;
            }
        }

        public int Id_projeto
        {
            get
            {
                return id_projeto;
            }

            set
            {
                id_projeto = value;
            }
        }

        public string EvtRemun
        {
            get
            {
                return evtRemun;
            }

            set
            {
                evtRemun = value;
            }
        }

        public int IdeEvento_indRetif
        {
            get
            {
                return ideEvento_indRetif;
            }

            set
            {
                ideEvento_indRetif = value;
            }
        }

        public string IdeEvento_nrRecibo
        {
            get
            {
                return ideEvento_nrRecibo;
            }

            set
            {
                ideEvento_nrRecibo = value;
            }
        }

        public string IdeEvento_indApuracao
        {
            get
            {
                return ideEvento_indApuracao;
            }

            set
            {
                ideEvento_indApuracao = value;
            }
        }

        public string IdeEvento_perApur
        {
            get
            {
                return ideEvento_perApur;
            }

            set
            {
                ideEvento_perApur = value;
            }
        }

        public int IdeEvento_tpAmb
        {
            get
            {
                return ideEvento_tpAmb;
            }

            set
            {
                ideEvento_tpAmb = value;
            }
        }

        public int IdeEvento_procEmi
        {
            get
            {
                return ideEvento_procEmi;
            }

            set
            {
                ideEvento_procEmi = value;
            }
        }

        public string IdeEvento_verProc
        {
            get
            {
                return ideEvento_verProc;
            }

            set
            {
                ideEvento_verProc = value;
            }
        }

        public int IdeEmpregador_tpInsc
        {
            get
            {
                return ideEmpregador_tpInsc;
            }

            set
            {
                ideEmpregador_tpInsc = value;
            }
        }

        public string IdeEmpregador_nrInsc
        {
            get
            {
                return ideEmpregador_nrInsc;
            }

            set
            {
                ideEmpregador_nrInsc = value;
            }
        }

        public string IdeTrabalhador_cpfTrab
        {
            get
            {
                return ideTrabalhador_cpfTrab;
            }

            set
            {
                ideTrabalhador_cpfTrab = value;
            }
        }

        public string IdeTrabalhador_nisTrab
        {
            get
            {
                return ideTrabalhador_nisTrab;
            }

            set
            {
                ideTrabalhador_nisTrab = value;
            }
        }

        public string Recibo_nrRecibo
        {
            get
            {
                return recibo_nrRecibo;
            }

            set
            {
                recibo_nrRecibo = value;
            }
        }

        public string Recibo_hash
        {
            get
            {
                return recibo_hash;
            }

            set
            {
                recibo_hash = value;
            }
        }

        public DateTime Recepcao_processamento_dhProcessamento
        {
            get
            {
                return recepcao_processamento_dhProcessamento;
            }

            set
            {
                recepcao_processamento_dhProcessamento = value;
            }
        }

        public int Situacao_retificar
        {
            get
            {
                return situacao_retificar;
            }

            set
            {
                situacao_retificar = value;
            }
        }

        public string Codigo_resposta
        {
            get
            {
                return codigo_resposta;
            }

            set
            {
                codigo_resposta = value;
            }
        }

        public string Descricao_resposta
        {
            get
            {
                return descricao_resposta;
            }

            set
            {
                descricao_resposta = value;
            }
        }

        public string Data_hora_retificacao
        {
            get
            {
                return data_hora_retificacao;
            }

            set
            {
                data_hora_retificacao = value;
            }
        }

        public string Nome_arquivo_retificacao
        {
            get
            {
                return nome_arquivo_retificacao;
            }

            set
            {
                nome_arquivo_retificacao = value;
            }
        }

        public string Dadosrecepcaolote_protocoloenvio
        {
            get
            {
                return dadosrecepcaolote_protocoloenvio;
            }

            set
            {
                dadosrecepcaolote_protocoloenvio = value;
            }
        }

        public string Codigo_recepcao
        {
            get
            {
                return codigo_recepcao;
            }

            set
            {
                codigo_recepcao = value;
            }
        }

        public string Descricao_recepcao_lote
        {
            get
            {
                return descricao_recepcao_lote;
            }

            set
            {
                descricao_recepcao_lote = value;
            }
        }

        public string Processamento_recibo_nrRecibo
        {
            get
            {
                return processamento_recibo_nrRecibo;
            }

            set
            {
                processamento_recibo_nrRecibo = value;
            }
        }

        public string Original_numero_lote
        {
            get
            {
                return original_numero_lote;
            }

            set
            {
                original_numero_lote = value;
            }
        }

        public string Versao_layout_evtRemun
        {
            get
            {
                return versao_layout_evtRemun;
            }

            set
            {
                versao_layout_evtRemun = value;
            }
        }

        public string Trabalho_intermitente_quantidade_dias
        {
            get
            {
                return trabalho_intermitente_quantidade_dias;
            }

            set
            {
                trabalho_intermitente_quantidade_dias = value;
            }
        }

        public int Id_cadastro_envios
        {
            get
            {
                return id_cadastro_envios;
            }

            set
            {
                id_cadastro_envios = value;
            }
        }

        public string Nome_arquivo_importado
        {
            get
            {
                return nome_arquivo_importado;
            }

            set
            {
                nome_arquivo_importado = value;
            }
        }

        public List<EventoRemunEntity> Get()
        {
            EventoRemunEntity evtRemunEntity;
            List<EventoRemunEntity> listaEventos = new List<EventoRemunEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_evtremun";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EventoRemunEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_transmissor = reader.GetInt32(1);
                    evtRemunEntity.Id_projeto = reader.GetInt32(2);
                    // evtRemunEntity.Id_usuario = reader.GetInt32(3);
                    evtRemunEntity.EvtRemun = reader.GetString(4);
                    evtRemunEntity.IdeEvento_indRetif = reader.GetInt16(5);
                    evtRemunEntity.IdeEvento_nrRecibo = reader.GetString(6);
                    evtRemunEntity.IdeEvento_indApuracao = reader.GetString(7);
                    evtRemunEntity.IdeEvento_perApur = reader.GetString(8);
                    evtRemunEntity.IdeEvento_tpAmb = 1;//9
                    evtRemunEntity.IdeEvento_procEmi = reader.GetInt16(10);
                    evtRemunEntity.IdeEvento_verProc = reader.GetString(11);
                    evtRemunEntity.IdeEmpregador_tpInsc = reader.GetInt16(12);
                    evtRemunEntity.IdeEmpregador_nrInsc = reader.GetString(13);
                    evtRemunEntity.IdeTrabalhador_cpfTrab = reader.GetString(14);
                    evtRemunEntity.IdeTrabalhador_nisTrab = reader.GetString(15);
                    evtRemunEntity.Recibo_nrRecibo = reader.GetString(16);
                    evtRemunEntity.Recibo_hash = reader.GetString(17);
                    evtRemunEntity.Recepcao_processamento_dhProcessamento = reader.GetDateTime(18);
                    evtRemunEntity.Situacao_retificar = reader.GetInt32(19);
                    evtRemunEntity.Codigo_resposta = reader.GetString(20);
                    evtRemunEntity.Descricao_resposta = reader.GetString(21);
                    evtRemunEntity.Data_hora_retificacao = reader.GetString(22);
                    evtRemunEntity.Nome_arquivo_retificacao = reader.GetString(23);
                    evtRemunEntity.Dadosrecepcaolote_protocoloenvio = reader.GetString(24);
                    evtRemunEntity.Codigo_recepcao = reader.GetString(25);
                    evtRemunEntity.Descricao_recepcao_lote = reader.GetString(26);
                    evtRemunEntity.Processamento_recibo_nrRecibo = reader.GetString(27);
                    evtRemunEntity.Original_numero_lote = reader.GetString(28);
                    evtRemunEntity.Versao_layout_evtRemun = reader.GetString(29);
                    evtRemunEntity.Trabalho_intermitente_quantidade_dias = reader.GetString(30);
                    evtRemunEntity.Id_cadastro_envios = reader.GetInt32(31);

                    if (!reader.IsDBNull(32))
                    {
                        evtRemunEntity.Nome_arquivo_importado = reader.GetString(32);
                    }
                    

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }
            return listaEventos;
        }

        public List<EvtRemun_InfoMVEntity> GetInfoMV()
        {
            EvtRemun_InfoMVEntity evtRemunEntity;
            List<EvtRemun_InfoMVEntity> listaEventos = new List<EvtRemun_InfoMVEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_infomv";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_InfoMVEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_usuario = reader.GetInt32(2);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(3);
                    evtRemunEntity.InfoMV_indMV = reader.GetString(4);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        public List<EvtRemun_InfoMV_RemunOutrEmpEntity> GetInfoMVRemunOutrEmpresa()
        {
            EvtRemun_InfoMV_RemunOutrEmpEntity evtRemunEntity;
            List<EvtRemun_InfoMV_RemunOutrEmpEntity> listaEventos = new List<EvtRemun_InfoMV_RemunOutrEmpEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_infomv_remunoutrempr";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_InfoMV_RemunOutrEmpEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_usuario = reader.GetInt32(2);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(3);
                    evtRemunEntity.Id_infoMV = reader.GetInt32(4);
                    evtRemunEntity.RemunOutrEmpr_tpInsc = reader.GetString(5);
                    evtRemunEntity.RemunOutrEmpr_nrInsc = reader.GetString(6);
                    evtRemunEntity.RemunOutrEmpr_codCateg = reader.GetString(7);
                    evtRemunEntity.RemunOutrEmpr_vlrRemunOE = reader.GetDecimal(8);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        public List<EvtRemun_InfoComplSucesEntity> GetInfoComplSuces()
        {
            EvtRemun_InfoComplSucesEntity evtRemunEntity;
            List<EvtRemun_InfoComplSucesEntity> listaEventos = new List<EvtRemun_InfoComplSucesEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_infocomplem_sucessaovinc";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_InfoComplSucesEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);                    
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.Id_infoComplem = reader.GetInt32(3);
                    evtRemunEntity.SucessaoVinc_tpInsc = reader.GetString(4);
                    evtRemunEntity.SucessaoVinc_nrInsc = reader.GetString(5);
                    evtRemunEntity.SucessaoVinc_matricAnt = reader.GetString(6);
                    evtRemunEntity.SucessaoVinc_dtAdm = reader.GetString(7);
                    evtRemunEntity.SucessaoVinc_observacao = reader.GetString(8);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        public List<EvtRemun_InfoComplEntity> GetInfoCompl()
        {
            EvtRemun_InfoComplEntity evtRemunEntity;
            List<EvtRemun_InfoComplEntity> listaEventos = new List<EvtRemun_InfoComplEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_infocomplem";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_InfoComplEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.InfoComplem_nmTrab = reader.GetString(3);
                    evtRemunEntity.InfoComplem_dtNascto = reader.GetString(4);                    

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        public List<EvtRemun_ProcJudEntity> GetProcJudTrab()
        {
            EvtRemun_ProcJudEntity evtRemunEntity;
            List<EvtRemun_ProcJudEntity> listaEventos = new List<EvtRemun_ProcJudEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_procjudtrab";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_ProcJudEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.ProcJudTrab_tpTrib = reader.GetString(3);
                    evtRemunEntity.ProcJudTrab_nrProcJud = reader.GetString(4);
                    evtRemunEntity.ProcJudTrab_codSusp = reader.GetString(4);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        public List<EvtRemun_InfoIntermEntity> GetInfoInterm()
        {
            EvtRemun_InfoIntermEntity evtRemunEntity;
            List<EvtRemun_InfoIntermEntity> listaEventos = new List<EvtRemun_InfoIntermEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_infointerm";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_InfoIntermEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.InfoInterm_dia = reader.GetString(3);                    

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        public List<EvtRemun_DmDevEntity> GetDmDev()
        {
            EvtRemun_DmDevEntity evtRemunEntity;
            List<EvtRemun_DmDevEntity> listaEventos = new List<EvtRemun_DmDevEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_dmdev";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_DmDevEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_usuario = reader.GetInt16(2);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(3);
                    evtRemunEntity.DmDev_ideDmDev = reader.GetString(4);
                    evtRemunEntity.DmDev_icodCateg = reader.GetString(5);
                    evtRemunEntity.Id_cadastro_envios = reader.GetInt32(6);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        public List<EvtRemun_DmDev_IdeEstablotEntity> GetDmDevIdeEstablot()
        {
            EvtRemun_DmDev_IdeEstablotEntity evtRemunEntity;
            List<EvtRemun_DmDev_IdeEstablotEntity> listaEventos = new List<EvtRemun_DmDev_IdeEstablotEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_dmdev_periodo_ideestablot";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_DmDev_IdeEstablotEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_usuario = reader.GetInt16(2);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(3);
                    evtRemunEntity.Id_s_1200_dmdev = reader.GetInt32(4);
                    evtRemunEntity.IdeEstabLot_tpInsc = reader.GetInt16(5);
                    evtRemunEntity.IdeEstabLot_nrInsc = reader.GetString(6);
                    evtRemunEntity.IdeEstabLot_codLotacao = reader.GetString(7);
                    evtRemunEntity.IdeEstabLot_qtdDiasAv = reader.GetString(8);
                    evtRemunEntity.Id_cadastro_envios = reader.GetInt32(9);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }
        
        public List<EvtRemun_DmDev_IdeEstablotMatEntity> GetDmDevIdeEstablotMatricula()
        {
            EvtRemun_DmDev_IdeEstablotMatEntity evtRemunEntity;
            List<EvtRemun_DmDev_IdeEstablotMatEntity> listaEventos = new List<EvtRemun_DmDev_IdeEstablotMatEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_dmdev_periodo_ideestablot_matricula";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_DmDev_IdeEstablotMatEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.Id_s_1200_dmdev = reader.GetInt32(3);
                    evtRemunEntity.Id_dmdev_periodo_ideestablot = reader.GetInt32(4);
                    evtRemunEntity.RemunPerApur_matricula = reader.GetString(5);
                    evtRemunEntity.RemunPerApur_indSimples = reader.GetString(6);
                    evtRemunEntity.Id_cadastro_envio = reader.GetInt32(7);                    

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        public List<EvtRemun_ItemRemuneracaoEntity> GetDmDevItemRemuneracao()
        {
            EvtRemun_ItemRemuneracaoEntity evtRemunEntity;
            List<EvtRemun_ItemRemuneracaoEntity> listaEventos = new List<EvtRemun_ItemRemuneracaoEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_remuneracao";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_ItemRemuneracaoEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_usuario = reader.GetInt32(2);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(3);
                    evtRemunEntity.Id_dmdev = reader.GetInt32(4);
                    evtRemunEntity.Id_dmdev_periodo_ideestablot = reader.GetInt32(5);
                    evtRemunEntity.Id_periodo_ideestablot_matricula = reader.GetInt32(6);
                    evtRemunEntity.EvtRemun = reader.GetString(7);
                    evtRemunEntity.DmDev_ideDmDev = reader.GetString(8);
                    evtRemunEntity.DmDev_icodCateg = reader.GetString(9);
                    evtRemunEntity.IdeEstabLot_tpInsc = reader.GetInt32(10);
                    evtRemunEntity.IdeEstabLot_nrInsc = reader.GetString(11);
                    evtRemunEntity.IdeEstabLot_codLotacao = reader.GetString(12);
                    evtRemunEntity.RemunPerApur_matricula = reader.GetString(13);
                    evtRemunEntity.ItensRemun_codRubr = reader.GetString(14);
                    evtRemunEntity.ItensRemun_ideTabRubr = reader.GetString(15);
                    evtRemunEntity.ItensRemun_vrRubr = reader.GetDecimal(16).ToString();
                    evtRemunEntity.InfoAgNocivo_grauExp = reader.GetString(17);
                    evtRemunEntity.Nome_arquivo = reader.GetString(18);
                    evtRemunEntity.ItensfatorRubr = reader.GetString(19);
                    evtRemunEntity.ItensindApurIR = reader.GetString(20);
                    evtRemunEntity.ItensRemun_qtdRubr = reader.GetString(21);
                    evtRemunEntity.Situacao = reader.GetInt16(22);
                    evtRemunEntity.Id_cadastro_envios = reader.GetInt32(23);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }       

         public List<EvtRemun_DmDevAnteriorEntity> GetDmDevAnteriorIdeAdc()
        {
            EvtRemun_DmDevAnteriorEntity evtRemunEntity;
            List<EvtRemun_DmDevAnteriorEntity> listaEventos = new List<EvtRemun_DmDevAnteriorEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_dmdev_anterior_ideadc";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_DmDevAnteriorEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.Id_s_1200_dmdev = reader.GetInt32(3);
                    evtRemunEntity.DtAcConv = reader.GetDateTime(4);
                    evtRemunEntity.TpAcConv = reader.GetString(5);
                    evtRemunEntity.CompAcConv = reader.GetString(6);
                    evtRemunEntity.DtEfAcConv = reader.GetString(7);
                    evtRemunEntity.Dsc = reader.GetString(8);
                    evtRemunEntity.RemunSuc = reader.GetString(9);
                    

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }
        
        public List<EvtRemun_DmDevAntPerRefEntity> GetDmDevAnteriorIdeAdcPerRef()
        {
            EvtRemun_DmDevAntPerRefEntity evtRemunEntity;
            List<EvtRemun_DmDevAntPerRefEntity> listaEventos = new List<EvtRemun_DmDevAntPerRefEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_dmdev_anterior_ideadc_perref";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_DmDevAntPerRefEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.Id_s_1200_dmdev = reader.GetInt32(3);
                    evtRemunEntity.Id_dmdev_anterior_ideadc = reader.GetInt32(4);
                    evtRemunEntity.IdePeriodo_perRef = reader.GetString(5);
                    
                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }

        
        public List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotEntity> GetDmDevAnteriorIdeAdcIdeEstabLot()
        {
            EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotEntity evtRemunEntity;
            List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotEntity> listaEventos = new List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_dmdev_anterior_ideadc_ideperiodo_ideestablot";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.Id_s_1200_dmdev = reader.GetInt32(3);
                    evtRemunEntity.Id_dmdev_anterior_ideadc = reader.GetInt32(4);
                    evtRemunEntity.Id_anterior_ideadc_perref = reader.GetInt32(5);
                    evtRemunEntity.Anterior_ideEstabLot_tpInsc = reader.GetString(6);
                    evtRemunEntity.Anterior_ideEstabLot_nrInsc = reader.GetString(7);
                    evtRemunEntity.Anterior_ideEstabLot_codLotacao = reader.GetString(8);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }
        
        public List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotMatrEntity> GetDmDevAnteriorIdeAdcIdeEstabLotMatricula()
        {
            EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotMatrEntity evtRemunEntity;
            List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotMatrEntity> listaEventos = new List<EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotMatrEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_dmdev_anterior_ideadc_ideperiodo_ideestablot_matricula";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_DmDevAnterior_IdeAdc_IdeEstabLotMatrEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.Id_s_1200_dmdev = reader.GetInt32(3);
                    evtRemunEntity.Id_dmdev_anterior_ideadc = reader.GetInt32(4);
                    evtRemunEntity.Id_anterior_ideadc_perref = reader.GetInt32(5);
                    evtRemunEntity.Id_anterior_ideadc_idePeriodo_ideEstabLot = reader.GetInt32(6);
                    evtRemunEntity.RemunPerAnt_matricula = reader.GetString(7);
                    evtRemunEntity.RemunPerAnt_indSimples = reader.GetString(8);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }        
        public List<EvtRemun_AnteriorEntity> GetDmDevRemuneracaoAnterior()
        {
            EvtRemun_AnteriorEntity evtRemunEntity;
            List<EvtRemun_AnteriorEntity> listaEventos = new List<EvtRemun_AnteriorEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_remuneracao_anterior";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_AnteriorEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.Id_s_1200_dmdev = reader.GetInt32(3);
                    evtRemunEntity.Id_dmdev_anterior_ideadc = reader.GetInt32(4);
                    evtRemunEntity.Id_anterior_ideadc_perref = reader.GetInt32(5);
                    evtRemunEntity.Id_anterior_ideadc_idePeriodo_ideEstabLot = reader.GetInt32(6);
                    evtRemunEntity.Id_anterior_ideadc_ideperiodo_ideestablot_matricula = reader.GetInt32(7);
                    evtRemunEntity.Remuneracao_anterior_codRubr = reader.GetString(8);
                    evtRemunEntity.Remuneracao_anterior_ideTabRubr = reader.GetString(9);
                    evtRemunEntity.Remuneracao_anterior_qtdRubr = reader.GetString(10);
                    evtRemunEntity.Remuneracao_anterior_fatorRubr = reader.GetString(11);
                    evtRemunEntity.Remuneracao_anterior_vrUnit = reader.GetString(12);
                    evtRemunEntity.Remuneracao_anterior_vrRubr = reader.GetString(13);
                    evtRemunEntity.Remuneracao_anterior_indApurIR = reader.GetString(14);
                    evtRemunEntity.InfoAgNocivo_grauExp = reader.GetString(15);

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }
        
        public List<EvtRemun_InfoComplContEntity> GetInfoComplCont()
        {
            EvtRemun_InfoComplContEntity evtRemunEntity;
            List<EvtRemun_InfoComplContEntity> listaEventos = new List<EvtRemun_InfoComplContEntity>();
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM s_1200_infocomplcont";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evtRemunEntity = new EvtRemun_InfoComplContEntity();
                    evtRemunEntity.Id = reader.GetInt32(0);
                    evtRemunEntity.Id_projeto = reader.GetInt32(1);
                    evtRemunEntity.Id_cad_evtremun = reader.GetInt32(2);
                    evtRemunEntity.Id_dmdev = reader.GetInt32(3);
                    evtRemunEntity.InfoComplCont_codCBO = reader.GetString(4);
                    evtRemunEntity.InfoComplCont_natAtividade = reader.GetString(5);
                    evtRemunEntity.InfoComplCont_qtdDiasTrab = reader.GetString(6);                    

                    listaEventos.Add(evtRemunEntity);
                }
                dbCon.Close();
            }

            return listaEventos;
        }
    }
}
