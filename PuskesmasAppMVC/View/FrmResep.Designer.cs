namespace PuskesmasAppMVC.View
{
    partial class FrmResep
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
            this.lvwResep = new System.Windows.Forms.ListView();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.txtNamaObat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCari3 = new System.Windows.Forms.Button();
            this.btnCari2 = new System.Windows.Forms.Button();
            this.txtNamaPenyakit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtKdObat = new System.Windows.Forms.TextBox();
            this.txtKdPenyakit = new System.Windows.Forms.TextBox();
            this.txtKdResep = new System.Windows.Forms.TextBox();
            this.dtpResep = new System.Windows.Forms.DateTimePicker();
            this.txtKdPasien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwResep
            // 
            this.lvwResep.HideSelection = false;
            this.lvwResep.Location = new System.Drawing.Point(35, 350);
            this.lvwResep.Name = "lvwResep";
            this.lvwResep.Size = new System.Drawing.Size(969, 295);
            this.lvwResep.TabIndex = 10;
            this.lvwResep.UseCompatibleStateImageBehavior = false;
            this.lvwResep.SelectedIndexChanged += new System.EventHandler(this.lvwResep_SelectedIndexChanged);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(857, 651);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(147, 43);
            this.btnSelesai.TabIndex = 12;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // txtNamaObat
            // 
            this.txtNamaObat.Enabled = false;
            this.txtNamaObat.Location = new System.Drawing.Point(426, 289);
            this.txtNamaObat.Name = "txtNamaObat";
            this.txtNamaObat.Size = new System.Drawing.Size(250, 26);
            this.txtNamaObat.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Obat";
            // 
            // btnCari3
            // 
            this.btnCari3.Location = new System.Drawing.Point(274, 284);
            this.btnCari3.Name = "btnCari3";
            this.btnCari3.Size = new System.Drawing.Size(75, 36);
            this.btnCari3.TabIndex = 49;
            this.btnCari3.Text = "Cari";
            this.btnCari3.UseVisualStyleBackColor = true;
            this.btnCari3.Click += new System.EventHandler(this.btnCari3_Click);
            // 
            // btnCari2
            // 
            this.btnCari2.Location = new System.Drawing.Point(274, 196);
            this.btnCari2.Name = "btnCari2";
            this.btnCari2.Size = new System.Drawing.Size(75, 36);
            this.btnCari2.TabIndex = 48;
            this.btnCari2.Text = "Cari";
            this.btnCari2.UseVisualStyleBackColor = true;
            this.btnCari2.Click += new System.EventHandler(this.btnCari2_Click);
            // 
            // txtNamaPenyakit
            // 
            this.txtNamaPenyakit.Enabled = false;
            this.txtNamaPenyakit.Location = new System.Drawing.Point(426, 204);
            this.txtNamaPenyakit.Name = "txtNamaPenyakit";
            this.txtNamaPenyakit.Size = new System.Drawing.Size(250, 26);
            this.txtNamaPenyakit.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Penyakit";
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Enabled = false;
            this.txtNamaPasien.Location = new System.Drawing.Point(426, 122);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(452, 26);
            this.txtNamaPasien.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nama Pasien";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(274, 117);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 36);
            this.btnCari.TabIndex = 43;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click_1);
            // 
            // txtKdObat
            // 
            this.txtKdObat.Location = new System.Drawing.Point(145, 289);
            this.txtKdObat.Name = "txtKdObat";
            this.txtKdObat.Size = new System.Drawing.Size(123, 26);
            this.txtKdObat.TabIndex = 42;
            // 
            // txtKdPenyakit
            // 
            this.txtKdPenyakit.Location = new System.Drawing.Point(145, 201);
            this.txtKdPenyakit.Name = "txtKdPenyakit";
            this.txtKdPenyakit.Size = new System.Drawing.Size(123, 26);
            this.txtKdPenyakit.TabIndex = 41;
            // 
            // txtKdResep
            // 
            this.txtKdResep.Location = new System.Drawing.Point(145, 46);
            this.txtKdResep.Name = "txtKdResep";
            this.txtKdResep.Size = new System.Drawing.Size(123, 26);
            this.txtKdResep.TabIndex = 40;
            // 
            // dtpResep
            // 
            this.dtpResep.Location = new System.Drawing.Point(426, 46);
            this.dtpResep.Name = "dtpResep";
            this.dtpResep.Size = new System.Drawing.Size(288, 26);
            this.dtpResep.TabIndex = 39;
            // 
            // txtKdPasien
            // 
            this.txtKdPasien.Location = new System.Drawing.Point(145, 122);
            this.txtKdPasien.Name = "txtKdPasien";
            this.txtKdPasien.Size = new System.Drawing.Size(123, 26);
            this.txtKdPasien.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Kode Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kode Penyakit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kode Pasien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kode Resep";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(731, 281);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(147, 43);
            this.btnInput.TabIndex = 52;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // FrmResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 719);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtNamaObat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCari3);
            this.Controls.Add(this.btnCari2);
            this.Controls.Add(this.txtNamaPenyakit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNamaPasien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtKdObat);
            this.Controls.Add(this.txtKdPenyakit);
            this.Controls.Add(this.txtKdResep);
            this.Controls.Add(this.dtpResep);
            this.Controls.Add(this.txtKdPasien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.lvwResep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmResep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Resep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwResep;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.TextBox txtNamaObat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCari3;
        private System.Windows.Forms.Button btnCari2;
        private System.Windows.Forms.TextBox txtNamaPenyakit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtKdObat;
        private System.Windows.Forms.TextBox txtKdPenyakit;
        private System.Windows.Forms.TextBox txtKdResep;
        private System.Windows.Forms.DateTimePicker dtpResep;
        private System.Windows.Forms.TextBox txtKdPasien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInput;
    }
}