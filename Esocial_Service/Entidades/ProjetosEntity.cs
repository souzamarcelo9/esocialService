using Esocial_Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esocial_Service.Entidades
{
    public class ProjetosEntity
    {
        int id;
        string cnpj_empresa;
        string descricao;
        string razao;

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

        public string Cnpj_empresa
        {
            get
            {
                return cnpj_empresa;
            }

            set
            {
                cnpj_empresa = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string Razao
        {
            get
            {
                return razao;
            }

            set
            {
                razao = value;
            }
        }

        public List<ProjetosEntity> Get()
        {
            List<ProjetosEntity> listaProjetos = new List<ProjetosEntity>();
            ProjetosEntity projetoEntity;
            
            MySql.Data.MySqlClient.MySqlConnection dbCon = DBConnection.GetConnection();
            dbCon.Open();

            {
                string query = "SELECT * FROM projetos";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    projetoEntity = new ProjetosEntity();
                    projetoEntity.Id = reader.GetInt32(0);
                    projetoEntity.Descricao = reader.GetString(1);
                    projetoEntity.Cnpj_empresa = reader.GetString(2);
                    projetoEntity.Razao = reader.GetString(3);

                    listaProjetos.Add(projetoEntity);
                }
                dbCon.Close();
            }

            return listaProjetos;
        }

    
    }
}
