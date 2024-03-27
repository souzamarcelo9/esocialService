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
    public class EvtoPagtoEntity
    {
        public List<EvtPgtos1210> Get()
        {
            var dbCon = DBConnection.Instance();
            if (dbCon.IsConnect())
            {
                string query = "SELECT col0,col1 FROM YourTable";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                dbCon.Close();
            }
            return new List<EvtPgtos1210>();
        }
    }
}
