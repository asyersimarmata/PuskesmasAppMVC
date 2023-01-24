namespace PuskesmasAppMVC.View
{
    partial class FrmLaporanPasien
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
            this.rdoSemua = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanNama = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanKode = new System.Windows.Forms.RadioButton();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.lvwPasien = new System.Windows.Forms.ListView();
            this.rdoBerdasarkanAlamat = new System.Windows.Forms.RadioButton();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoSemua
            // 
            this.rdoSemua.AutoSize = true;
            this.rdoSemua.Location = new System.Drawing.Point(90, 25);
            this.rdoSemua.Name = "rdoSemua";
            this.rdoSemua.Size = new System.Drawing.Size(137, 24);
            this.rdoSemua.TabIndex = 0;
            this.rdoSemua.TabStop = true;
            this.rdoSemua.Text = "Semua Pasien";
            this.rdoSemua.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanNama
            // 
            this.rdoBerdasarkanNama.AutoSize = true;
            this.rdoBerdasarkanNama.Location = new System.Drawing.Point(90, 75);
            this.rdoBerdasarkanNama.Name = "rdoBerdasarkanNama";
            this.rdoBerdasarkanNama.Size = new System.Drawing.Size(171, 24);
            this.rdoBerdasarkanNama.TabIndex = 1;
            this.rdoBerdasarkanNama.TabStop = true;
            this.rdoBerdasarkanNama.Text = "Berdasarkan Nama";
            this.rdoBerdasarkanNama.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanKode
            // 
            this.rdoBerdasarkanKode.AutoSize = true;
            this.rdoBerdasarkanKode.Location = new System.Drawing.Point(90, 128);
            this.rdoBerdasarkanKode.Name = "rdoBerdasarkanKode";
            this.rdoBerdasarkanKode.Size = new System.Drawing.Size(166, 24);
            this.rdoBerdasarkanKode.TabIndex = 2;
            this.rdoBerdasarkanKode.TabStop = true;
            this.rdoBerdasarkanKode.Text = "Berdasarkan Kode";
            this.rdoBerdasarkanKode.UseVisualStyleBackColor = true;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(275, 75);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(462, 26);
            this.txtNama.TabIndex = 3;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(275, 128);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(462, 26);
            this.txtKode.TabIndex = 4;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(782, 72);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(213, 135);
            this.btnTampilkanData.TabIndex = 5;
            this.btnTampilkanData.Text = "Tampilkan";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // lvwPasien
            // 
            this.lvwPasien.HideSelection = false;
            this.lvwPasien.Location = new System.Drawing.Point(30, 231);
            this.lvwPasien.Name = "lvwPasien";
            this.lvwPasien.Size = new System.Drawing.Size(1031, 371);
            this.lvwPasien.TabIndex = 6;
            this.lvwPasien.UseCompatibleStateImageBehavior = false;
            // 
            // rdoBerdasarkanAlamat
            // 
            this.rdoBerdasarkanAlamat.AutoSize = true;
            this.rdoBerdasarkanAlamat.Location = new System.Drawing.Point(90, 182);
            this.rdoBerdasarkanAlamat.Name = "rdoBerdasarkanAlamat";
            this.rdoBerdasarkanAlamat.Size = new System.Drawing.Size(179, 24);
            this.rdoBerdasarkanAlamat.TabIndex = 7;
            this.rdoBerdasarkanAlamat.TabStop = true;
            this.rdoBerdasarkanAlamat.Text = "Berdasarkan Alamat";
            this.rdoBerdasarkanAlamat.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(275, 180);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(462, 26);
            this.txtAlamat.TabIndex = 8;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(863, 615);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(132, 37);
            this.btnKeluar.TabIndex = 9;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FrmLaporanPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 676);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.rdoBerdasarkanAlamat);
            this.Controls.Add(this.lvwPasien);
            this.Controls.Add(this.btnTampilkanData);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.rdoBerdasarkanKode);
            this.Controls.Add(this.rdoBerdasarkanNama);
            this.Controls.Add(this.rdoSemua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLaporanPasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Laporan Data Pasien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSemua;
        private System.Windows.Forms.RadioButton rdoBerdasarkanNama;
        private System.Windows.Forms.RadioButton rdoBerdasarkanKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.ListView lvwPasien;
        private System.Windows.Forms.RadioButton rdoBerdasarkanAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnKeluar;
    }
}