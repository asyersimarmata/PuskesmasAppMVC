namespace PuskesmasAppMVC.View
{
    partial class FrmLaporanDokter
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
            this.txtAlamatDokter = new System.Windows.Forms.TextBox();
            this.rdoBerdasarkanAlamat = new System.Windows.Forms.RadioButton();
            this.txtKdDokter = new System.Windows.Forms.TextBox();
            this.txtNamaDokter = new System.Windows.Forms.TextBox();
            this.rdoBerdasarkanKode = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanNama = new System.Windows.Forms.RadioButton();
            this.rdoSemua = new System.Windows.Forms.RadioButton();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.lvwDokter = new System.Windows.Forms.ListView();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAlamatDokter
            // 
            this.txtAlamatDokter.Location = new System.Drawing.Point(273, 173);
            this.txtAlamatDokter.Name = "txtAlamatDokter";
            this.txtAlamatDokter.Size = new System.Drawing.Size(462, 26);
            this.txtAlamatDokter.TabIndex = 15;
            // 
            // rdoBerdasarkanAlamat
            // 
            this.rdoBerdasarkanAlamat.AutoSize = true;
            this.rdoBerdasarkanAlamat.Location = new System.Drawing.Point(88, 175);
            this.rdoBerdasarkanAlamat.Name = "rdoBerdasarkanAlamat";
            this.rdoBerdasarkanAlamat.Size = new System.Drawing.Size(179, 24);
            this.rdoBerdasarkanAlamat.TabIndex = 14;
            this.rdoBerdasarkanAlamat.TabStop = true;
            this.rdoBerdasarkanAlamat.Text = "Berdasarkan Alamat";
            this.rdoBerdasarkanAlamat.UseVisualStyleBackColor = true;
            // 
            // txtKdDokter
            // 
            this.txtKdDokter.Location = new System.Drawing.Point(273, 121);
            this.txtKdDokter.Name = "txtKdDokter";
            this.txtKdDokter.Size = new System.Drawing.Size(462, 26);
            this.txtKdDokter.TabIndex = 13;
            // 
            // txtNamaDokter
            // 
            this.txtNamaDokter.Location = new System.Drawing.Point(273, 68);
            this.txtNamaDokter.Name = "txtNamaDokter";
            this.txtNamaDokter.Size = new System.Drawing.Size(462, 26);
            this.txtNamaDokter.TabIndex = 12;
            // 
            // rdoBerdasarkanKode
            // 
            this.rdoBerdasarkanKode.AutoSize = true;
            this.rdoBerdasarkanKode.Location = new System.Drawing.Point(88, 121);
            this.rdoBerdasarkanKode.Name = "rdoBerdasarkanKode";
            this.rdoBerdasarkanKode.Size = new System.Drawing.Size(166, 24);
            this.rdoBerdasarkanKode.TabIndex = 11;
            this.rdoBerdasarkanKode.TabStop = true;
            this.rdoBerdasarkanKode.Text = "Berdasarkan Kode";
            this.rdoBerdasarkanKode.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanNama
            // 
            this.rdoBerdasarkanNama.AutoSize = true;
            this.rdoBerdasarkanNama.Location = new System.Drawing.Point(88, 68);
            this.rdoBerdasarkanNama.Name = "rdoBerdasarkanNama";
            this.rdoBerdasarkanNama.Size = new System.Drawing.Size(171, 24);
            this.rdoBerdasarkanNama.TabIndex = 10;
            this.rdoBerdasarkanNama.TabStop = true;
            this.rdoBerdasarkanNama.Text = "Berdasarkan Nama";
            this.rdoBerdasarkanNama.UseVisualStyleBackColor = true;
            // 
            // rdoSemua
            // 
            this.rdoSemua.AutoSize = true;
            this.rdoSemua.Location = new System.Drawing.Point(88, 18);
            this.rdoSemua.Name = "rdoSemua";
            this.rdoSemua.Size = new System.Drawing.Size(137, 24);
            this.rdoSemua.TabIndex = 9;
            this.rdoSemua.TabStop = true;
            this.rdoSemua.Text = "Semua Dokter";
            this.rdoSemua.UseVisualStyleBackColor = true;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(599, 222);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(136, 39);
            this.btnTampilkanData.TabIndex = 16;
            this.btnTampilkanData.Text = "Tampilkan";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // lvwDokter
            // 
            this.lvwDokter.HideSelection = false;
            this.lvwDokter.Location = new System.Drawing.Point(31, 287);
            this.lvwDokter.Name = "lvwDokter";
            this.lvwDokter.Size = new System.Drawing.Size(758, 295);
            this.lvwDokter.TabIndex = 17;
            this.lvwDokter.UseCompatibleStateImageBehavior = false;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(603, 610);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(132, 37);
            this.btnKeluar.TabIndex = 18;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FrmLaporanDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 691);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.lvwDokter);
            this.Controls.Add(this.btnTampilkanData);
            this.Controls.Add(this.txtAlamatDokter);
            this.Controls.Add(this.rdoBerdasarkanAlamat);
            this.Controls.Add(this.txtKdDokter);
            this.Controls.Add(this.txtNamaDokter);
            this.Controls.Add(this.rdoBerdasarkanKode);
            this.Controls.Add(this.rdoBerdasarkanNama);
            this.Controls.Add(this.rdoSemua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLaporanDokter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Laporan Data Dokter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlamatDokter;
        private System.Windows.Forms.RadioButton rdoBerdasarkanAlamat;
        private System.Windows.Forms.TextBox txtKdDokter;
        private System.Windows.Forms.TextBox txtNamaDokter;
        private System.Windows.Forms.RadioButton rdoBerdasarkanKode;
        private System.Windows.Forms.RadioButton rdoBerdasarkanNama;
        private System.Windows.Forms.RadioButton rdoSemua;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.ListView lvwDokter;
        private System.Windows.Forms.Button btnKeluar;
    }
}