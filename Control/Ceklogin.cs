using MySql.Data.MySqlClient;
using ResponsiKontak.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiKontak.Control
{
    class Ceklogin
    {
        Connection connection = new Connection();

        public bool login(string username, string password)
        {
            try
            {
                connection.OpenConnection();
                MySqlDataReader reader = connection.reader("Select * FROM login WHERE username='" + username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    connection.CloseConnection();
                    return true;
                }
                else
                {
                    connection.CloseConnection();
                    return false;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Eror");
            }
            return false;
        }
    }
}
