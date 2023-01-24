namespace PuskesmasAppMVC.View
{
    partial class FrmJadwalDokter
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
            this.lvwJadwal = new System.Windows.Forms.ListView();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.rdoHari = new System.Windows.Forms.RadioButton();
            this.rdoNama = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHari = new System.Windows.Forms.TextBox();
            this.rdoSemua = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lvwJadwal
            // 
            this.lvwJadwal.HideSelection = false;
            this.lvwJadwal.Location = new System.Drawing.Point(28, 176);
            this.lvwJadwal.Name = "lvwJadwal";
            this.lvwJadwal.Size = new System.Drawing.Size(729, 366);
            this.lvwJadwal.TabIndex = 0;
            this.lvwJadwal.UseCompatibleStateImageBehavior = false;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(644, 565);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(113, 35);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // rdoHari
            // 
            this.rdoHari.AutoSize = true;
            this.rdoHari.Location = new System.Drawing.Point(62, 79);
            this.rdoHari.Name = "rdoHari";
            this.rdoHari.Size = new System.Drawing.Size(158, 24);
            this.rdoHari.TabIndex = 2;
            this.rdoHari.TabStop = true;
            this.rdoHari.Text = "Berdasarkan Hari";
            this.rdoHari.UseVisualStyleBackColor = true;
            // 
            // rdoNama
            // 
            this.rdoNama.AutoSize = true;
            this.rdoNama.Location = new System.Drawing.Point(62, 127);
            this.rdoNama.Name = "rdoNama";
            this.rdoNama.Size = new System.Drawing.Size(171, 24);
            this.rdoNama.TabIndex = 3;
            this.rdoNama.TabStop = true;
            this.rdoNama.Text = "Berdasarkan Nama";
            this.rdoNama.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(627, 122);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(113, 35);
            this.btnTampilkan.TabIndex = 4;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(239, 127);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(361, 26);
            this.txtNama.TabIndex = 5;
            // 
            // txtHari
            // 
            this.txtHari.Location = new System.Drawing.Point(239, 78);
            this.txtHari.Name = "txtHari";
            this.txtHari.Size = new System.Drawing.Size(161, 26);
            this.txtHari.TabIndex = 6;
            // 
            // rdoSemua
            // 
            this.rdoSemua.AutoSize = true;
            this.rdoSemua.Location = new System.Drawing.Point(62, 28);
            this.rdoSemua.Name = "rdoSemua";
            this.rdoSemua.Size = new System.Drawing.Size(85, 24);
            this.rdoSemua.TabIndex = 7;
            this.rdoSemua.TabStop = true;
            this.rdoSemua.Text = "Semua";
            this.rdoSemua.UseVisualStyleBackColor = true;
            // 
            // FrmJadwalDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 647);
            this.Controls.Add(this.rdoSemua);
            this.Controls.Add(this.txtHari);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.rdoNama);
            this.Controls.Add(this.rdoHari);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.lvwJadwal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmJadwalDokter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jadwal Dokter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwJadwal;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.RadioButton rdoHari;
        private System.Windows.Forms.RadioButton rdoNama;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHari;
        private System.Windows.Forms.RadioButton rdoSemua;
    }
}