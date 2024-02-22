using ResponsiKontak.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiKontak
{
    public partial class LoginKontak : Form
    {
        Ceklogin cek = new Ceklogin();
        public LoginKontak()
        {
            InitializeComponent();
        }

        private void LoginKontak_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong", "Eror");
            }
            else
            {
                string Username = username.Text;
                string Password = password.Text;

                bool Status = cek.login(Username, Password);
                if (Status)
                {
                    MessageBox.Show("Login Berhasil!");
                    Menu form1 = new Menu();
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Login Gagal!");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
