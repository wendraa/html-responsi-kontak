
namespace ResponsiKontak
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.IdKontak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tambahh = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Cari = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKontak,
            this.Nama,
            this.NoHP,
            this.Alamat,
            this.email,
            this.Status,
            this.Perusahaan});
            this.DGV.Location = new System.Drawing.Point(12, 12);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(716, 265);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // IdKontak
            // 
            this.IdKontak.FillWeight = 80F;
            this.IdKontak.HeaderText = "ID Kontak";
            this.IdKontak.Name = "IdKontak";
            this.IdKontak.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // NoHP
            // 
            this.NoHP.FillWeight = 120F;
            this.NoHP.HeaderText = "Nomor HP";
            this.NoHP.Name = "NoHP";
            this.NoHP.ReadOnly = true;
            // 
            // Alamat
            // 
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.Name = "Alamat";
            this.Alamat.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Perusahaan
            // 
            this.Perusahaan.HeaderText = "Perusahaan";
            this.Perusahaan.Name = "Perusahaan";
            this.Perusahaan.ReadOnly = true;
            // 
            // Tambahh
            // 
            this.Tambahh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tambahh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tambahh.Location = new System.Drawing.Point(12, 292);
            this.Tambahh.Name = "Tambahh";
            this.Tambahh.Size = new System.Drawing.Size(161, 42);
            this.Tambahh.TabIndex = 1;
            this.Tambahh.Text = "&Tambah";
            this.Tambahh.UseVisualStyleBackColor = false;
            this.Tambahh.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Location = new System.Drawing.Point(199, 292);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(161, 42);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "&Edit";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Cari
            // 
            this.Cari.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cari.Location = new System.Drawing.Point(385, 292);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(161, 42);
            this.Cari.TabIndex = 3;
            this.Cari.Text = "&Pencariaan";
            this.Cari.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(567, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Keluar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cari);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Tambahh);
            this.Controls.Add(this.DGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Kontak";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button Tambahh;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Cari;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKontak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perusahaan;
        private System.Windows.Forms.Button button1;
    }
}

