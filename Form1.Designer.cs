namespace CRUDSederhana
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.Btn_Tambah = new System.Windows.Forms.Button();
            this.Btn_Hapus = new System.Windows.Forms.Button();
            this.Btn_Ubah = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(124, 42);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(178, 26);
            this.txtNIM.TabIndex = 5;
            this.txtNIM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(124, 81);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(178, 26);
            this.txtNama.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(124, 148);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(178, 26);
            this.txtTelepon.TabIndex = 8;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(124, 180);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(178, 26);
            this.txtAlamat.TabIndex = 9;
            // 
            // Btn_Tambah
            // 
            this.Btn_Tambah.Location = new System.Drawing.Point(444, 57);
            this.Btn_Tambah.Name = "Btn_Tambah";
            this.Btn_Tambah.Size = new System.Drawing.Size(75, 50);
            this.Btn_Tambah.TabIndex = 10;
            this.Btn_Tambah.Text = "Tambah";
            this.Btn_Tambah.UseVisualStyleBackColor = true;
            this.Btn_Tambah.Click += new System.EventHandler(this.BtnTambah);
            // 
            // Btn_Hapus
            // 
            this.Btn_Hapus.Location = new System.Drawing.Point(444, 129);
            this.Btn_Hapus.Name = "Btn_Hapus";
            this.Btn_Hapus.Size = new System.Drawing.Size(75, 45);
            this.Btn_Hapus.TabIndex = 11;
            this.Btn_Hapus.Text = "Hapus";
            this.Btn_Hapus.UseVisualStyleBackColor = true;
            this.Btn_Hapus.Click += new System.EventHandler(this.BtnHapus);
            // 
            // Btn_Ubah
            // 
            this.Btn_Ubah.Location = new System.Drawing.Point(594, 57);
            this.Btn_Ubah.Name = "Btn_Ubah";
            this.Btn_Ubah.Size = new System.Drawing.Size(75, 50);
            this.Btn_Ubah.TabIndex = 12;
            this.Btn_Ubah.Text = "Ubah";
            this.Btn_Ubah.UseVisualStyleBackColor = true;
            this.Btn_Ubah.Click += new System.EventHandler(this.BtnUbah);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(594, 129);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(75, 50);
            this.Btn_Refresh.TabIndex = 13;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.BtnRefresh);
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(106, 275);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.RowHeadersWidth = 62;
            this.dgvMahasiswa.RowTemplate.Height = 28;
            this.dgvMahasiswa.Size = new System.Drawing.Size(551, 150);
            this.dgvMahasiswa.TabIndex = 14;
            this.dgvMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Ubah);
            this.Controls.Add(this.Btn_Hapus);
            this.Controls.Add(this.Btn_Tambah);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button Btn_Tambah;
        private System.Windows.Forms.Button Btn_Hapus;
        private System.Windows.Forms.Button Btn_Ubah;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}

