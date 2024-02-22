using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiKontak.Config
{
    class Connection
    {
        string ConnectionString = "Server=localhost;Database=kontak;Uid=root;Pwd=;";
            MySqlConnection cn;

        public void OpenConnection()
        {
        cn = new MySqlConnection(ConnectionString);
        cn.Open();
        }

        public void CloseConnection()
        {
        cn.Close();
        }

        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
