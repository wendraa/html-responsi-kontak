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
    class Cekkontak
    {
        Connection connection = new Connection();

        public bool daftarkontak(string idkontak, string nama, string nohp, string alamat, string statuss, string email, string perusahaan)
        {
            try
            {
                connection.OpenConnection();
                MySqlDataReader reader = connection.reader("Select * FROM daftarkontak WHERE idkontak='" + idkontak + "' AND nama='" 
                    + nama + "' AND nohp='" + nohp + "' AND alamat='" + alamat + "' AND statuss='"
                    + statuss + "' AND email='" + email + "' AND perusahaan='" + perusahaan + "'");
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
