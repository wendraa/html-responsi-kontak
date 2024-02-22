
namespace ResponsiKontak.UI
{
    partial class Tambah
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tambah));
            this.idkontak = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.statuss = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.perusahaan = new System.Windows.Forms.TextBox();
            this.tmbh = new System.Windows.Forms.Button();
            this.klr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idkontak
            // 
            this.idkontak.Location = new System.Drawing.Point(117, 34);
            this.idkontak.Name = "idkontak";
            this.idkontak.Size = new System.Drawing.Size(157, 20);
            this.idkontak.TabIndex = 0;
            this.idkontak.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(117, 60);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(157, 20);
            this.nama.TabIndex = 1;
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(117, 86);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(157, 20);
            this.nohp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Kontak:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nomor HP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perusahaan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Alamat:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(117, 164);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(157, 20);
            this.email.TabIndex = 10;
            // 
            // statuss
            // 
            this.statuss.Location = new System.Drawing.Point(117, 138);
            this.statuss.Name = "statuss";
            this.statuss.Size = new System.Drawing.Size(157, 20);
            this.statuss.TabIndex = 11;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(117, 112);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(157, 20);
            this.alamat.TabIndex = 12;
            // 
            // perusahaan
            // 
            this.perusahaan.Location = new System.Drawing.Point(117, 190);
            this.perusahaan.Name = "perusahaan";
            this.perusahaan.Size = new System.Drawing.Size(157, 20);
            this.perusahaan.TabIndex = 13;
            // 
            // tmbh
            // 
            this.tmbh.Location = new System.Drawing.Point(26, 225);
            this.tmbh.Name = "tmbh";
            this.tmbh.Size = new System.Drawing.Size(248, 37);
            this.tmbh.TabIndex = 14;
            this.tmbh.Text = "Tambah";
            this.tmbh.UseVisualStyleBackColor = true;
            this.tmbh.Click += new System.EventHandler(this.button1_Click);
            // 
            // klr
            // 
            this.klr.Location = new System.Drawing.Point(26, 282);
            this.klr.Name = "klr";
            this.klr.Size = new System.Drawing.Size(248, 37);
            this.klr.TabIndex = 15;
            this.klr.Text = "Keluar";
            this.klr.UseVisualStyleBackColor = true;
            this.klr.Click += new System.EventHandler(this.klr_Click);
            // 
            // Tambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 331);
            this.Controls.Add(this.klr);
            this.Controls.Add(this.tmbh);
            this.Controls.Add(this.perusahaan);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.statuss);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nohp);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.idkontak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tambah";
            this.Text = "Kontak";
            this.Load += new System.EventHandler(this.Tambah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idkontak;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox statuss;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox perusahaan;
        private System.Windows.Forms.Button tmbh;
        private System.Windows.Forms.Button klr;
    }
}