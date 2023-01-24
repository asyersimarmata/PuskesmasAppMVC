namespace PuskesmasAppMVC.View
{
    partial class FrmUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.referensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPasien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPenyakit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObat = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResep = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataPasien = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referensiToolStripMenuItem,
            this.riwayatToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referensiToolStripMenuItem
            // 
            this.referensiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDokter,
            this.mnuPasien,
            this.mnuPenyakit,
            this.mnuObat});
            this.referensiToolStripMenuItem.Name = "referensiToolStripMenuItem";
            this.referensiToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.referensiToolStripMenuItem.Text = "Referensi";
            // 
            // mnuDokter
            // 
            this.mnuDokter.Name = "mnuDokter";
            this.mnuDokter.Size = new System.Drawing.Size(179, 34);
            this.mnuDokter.Text = "Dokter";
            this.mnuDokter.Click += new System.EventHandler(this.mnuDokter_Click);
            // 
            // mnuPasien
            // 
            this.mnuPasien.Name = "mnuPasien";
            this.mnuPasien.Size = new System.Drawing.Size(179, 34);
            this.mnuPasien.Text = "Pasien";
            this.mnuPasien.Click += new System.EventHandler(this.mnuPasien_Click);
            // 
            // mnuPenyakit
            // 
            this.mnuPenyakit.Name = "mnuPenyakit";
            this.mnuPenyakit.Size = new System.Drawing.Size(179, 34);
            this.mnuPenyakit.Text = "Penyakit";
            this.mnuPenyakit.Click += new System.EventHandler(this.mnuPenyakit_Click);
            // 
            // mnuObat
            // 
            this.mnuObat.Name = "mnuObat";
            this.mnuObat.Size = new System.Drawing.Size(179, 34);
            this.mnuObat.Text = "Obat";
            this.mnuObat.Click += new System.EventHandler(this.mnuObat_Click);
            // 
            // riwayatToolStripMenuItem
            // 
            this.riwayatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResep});
            this.riwayatToolStripMenuItem.Name = "riwayatToolStripMenuItem";
            this.riwayatToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.riwayatToolStripMenuItem.Text = "Transaksi";
            // 
            // mnuResep
            // 
            this.mnuResep.Name = "mnuResep";
            this.mnuResep.Size = new System.Drawing.Size(270, 34);
            this.mnuResep.Text = "Resep";
            this.mnuResep.Click += new System.EventHandler(this.mnuResep_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataPasien,
            this.dataDokterToolStripMenuItem,
            this.jadwalDokterToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // mnuDataPasien
            // 
            this.mnuDataPasien.Name = "mnuDataPasien";
            this.mnuDataPasien.Size = new System.Drawing.Size(270, 34);
            this.mnuDataPasien.Text = "Data Pasien";
            this.mnuDataPasien.Click += new System.EventHandler(this.mnuDataPasien_Click);
            // 
            // dataDokterToolStripMenuItem
            // 
            this.dataDokterToolStripMenuItem.Name = "dataDokterToolStripMenuItem";
            this.dataDokterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataDokterToolStripMenuItem.Text = "Data Dokter";
            this.dataDokterToolStripMenuItem.Click += new System.EventHandler(this.dataDokterToolStripMenuItem_Click);
            // 
            // jadwalDokterToolStripMenuItem
            // 
            this.jadwalDokterToolStripMenuItem.Name = "jadwalDokterToolStripMenuItem";
            this.jadwalDokterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.jadwalDokterToolStripMenuItem.Text = "Jadwal Dokter";
            this.jadwalDokterToolStripMenuItem.Click += new System.EventHandler(this.jadwalDokterToolStripMenuItem_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Informasi Puskesmas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDokter;
        private System.Windows.Forms.ToolStripMenuItem mnuPasien;
        private System.Windows.Forms.ToolStripMenuItem mnuPenyakit;
        private System.Windows.Forms.ToolStripMenuItem mnuObat;
        private System.Windows.Forms.ToolStripMenuItem riwayatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuResep;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDataPasien;
        private System.Windows.Forms.ToolStripMenuItem dataDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jadwalDokterToolStripMenuItem;
    }
}