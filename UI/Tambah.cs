using MySql.Data.MySqlClient;
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

namespace ResponsiKontak.UI
{
    public partial class Tambah : Form
    {
        Cekkontak cek = new Cekkontak();
        

        public Tambah()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tambah_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idkontak.Text == "" || nama.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("ID Kontak, Nama, dan Nomor HP Tidak Boleh Kosong", "Eror");
            }
            try
            { 

            }
        }

        private void klr_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
