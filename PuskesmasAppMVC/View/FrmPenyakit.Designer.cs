namespace PuskesmasAppMVC.View
{
    partial class FrmPenyakit
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
            this.lvwPenyakit = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaPenyakit = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwPenyakit
            // 
            this.lvwPenyakit.HideSelection = false;
            this.lvwPenyakit.Location = new System.Drawing.Point(14, 75);
            this.lvwPenyakit.Name = "lvwPenyakit";
            this.lvwPenyakit.Size = new System.Drawing.Size(370, 445);
            this.lvwPenyakit.TabIndex = 0;
            this.lvwPenyakit.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Penyakit";
            // 
            // txtNamaPenyakit
            // 
            this.txtNamaPenyakit.Location = new System.Drawing.Point(14, 32);
            this.txtNamaPenyakit.Name = "txtNamaPenyakit";
            this.txtNamaPenyakit.Size = new System.Drawing.Size(250, 26);
            this.txtNamaPenyakit.TabIndex = 2;
            // 
            // btnCari
            // 
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCari.Location = new System.Drawing.Point(288, 27);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(96, 37);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnKeluar.Location = new System.Drawing.Point(249, 526);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(135, 38);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FrmPenyakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 577);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtNamaPenyakit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwPenyakit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPenyakit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Penyakit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPenyakit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaPenyakit;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnKeluar;
    }
}