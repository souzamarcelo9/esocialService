using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Esocial_Service.Database
{
    public class DBConnection
    {
        private string server;
        private string databaseName;
        private string userName;
        private string password;
        private DBConnection()
        {
        }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public MySql.Data.MySqlClient.MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();                   

            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                Connection = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                Connection.Open();
            }

            return true;
        }

        public void Close()
        {
            Connection.Close();
        }

        public static MySql.Data.MySqlClient.MySqlConnection GetConnection()
        {
            MySql.Data.MySqlClient.MySqlConnection dbCon;
            dbCon = new MySql.Data.MySqlClient.MySqlConnection(" Persist Security Info=False;server=localhost;database=esocial;uid=root; pwd = root");                           

            return dbCon;
        }

    }
}
    
