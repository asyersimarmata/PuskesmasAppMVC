using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PuskesmasAppMVC.Model.Entity;
using PuskesmasAppMVC.Controller;

namespace PuskesmasAppMVC.View
{
    public partial class FrmResep : Form
    {
        private PasienController controllerPasien = new PasienController();

        private PenyakitController controllerPenyakit = new PenyakitController();

        private ObatController controllerObat = new ObatController();

        private ResepController controller = new ResepController();

        private Resep resep = new Resep();

        private List<Resep> listOfResep = new List<Resep>();

        //Method yang akan dipanggil saat form dibuka
        public FrmResep()
        {
            InitializeComponent();
            InisialisasiListView();
            TampilkanResep();
            Reset();
        }

        private void InisialisasiListView()
        {
            lvwResep.View = System.Windows.Forms.View.Details;
            lvwResep.FullRowSelect = true;
            lvwResep.GridLines = true;
            lvwResep.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwResep.Columns.Add("Kode Resep", 100, HorizontalAlignment.Center);
            lvwResep.Columns.Add("Tanggal", 150, HorizontalAlignment.Center);
            lvwResep.Columns.Add("Nama Pasien", 150, HorizontalAlignment.Center);
            lvwResep.Columns.Add("Penyakit", 130, HorizontalAlignment.Center);
            lvwResep.Columns.Add("Obat", 80, HorizontalAlignment.Center);

        }

        // Mthod mengambil data dari objek
        private void TampilkanResep()
        {
            lvwResep.Items.Clear();

            listOfResep = controller.ReadAll();

            //Melakukan perulangan
            foreach (var resep in listOfResep)
            {
                var noUrut = lvwResep.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(resep.kd_resep);
                item.SubItems.Add(resep.tanggal.ToString("dd/MMMM/yyyy"));
                item.SubItems.Add(resep.Pasien.nama);
                item.SubItems.Add(resep.Penyakit.nama_penyakit);
                item.SubItems.Add(resep.Obat.nama_obat);
                lvwResep.Items.Add(item);
            }
        }


        // Method Reset Form
        private void Reset()
        {
            txtKdResep.Clear();
            dtpResep.ResetText();
            txtKdPasien.Clear();
            txtNamaPasien.Clear();
            txtKdPenyakit.Clear();
            txtNamaPenyakit.Clear();
            txtKdObat.Clear();
            txtNamaObat.ResetText();
            
            //Menempatkan cursor pada kode resep
            txtKdResep.Focus();

        }

        private void btnCari_Click_1(object sender, EventArgs e)
        {
            try
            {
                string kode = txtKdPasien.Text;

                // Mencari kode pasien
                resep.Pasien = controllerPasien.ReadByKode(kode);
            }
            catch
            {
                
            }

            // Menampilkan nama pasien
            if (resep.Pasien != null)
            {
                txtNamaPasien.Text = resep.Pasien.nama;
            }

            // Pesan jika pasien tidak ditemukan
            else
            {
                MessageBox.Show("Data Pasien tidak ditemukan", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari2_Click(object sender, EventArgs e)
        {
            try
            {
                string kd = txtKdPenyakit.Text;

                // Mencari kode penyakit
                resep.Penyakit = controllerPenyakit.ReadByKd(kd);
            }
            catch
            {
                
            }

            // Menampilkan penyakit
            if (resep.Penyakit != null)
            {
                txtNamaPenyakit.Text = resep.Penyakit.nama_penyakit;
            }

            // Pesan jika penyakit tidak ditemukan
            else
            {
                MessageBox.Show("Data Penyakit tidak ditemukan", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari3_Click(object sender, EventArgs e)
        {
            try
            {
                string kd = txtKdObat.Text;

                // Mencari kode obat
                resep.Obat = controllerObat.ReadByKd(kd);
            }
            catch
            {
                
            }

            // Menampilkan obat
            if (resep.Obat != null)
            {
                txtNamaObat.Text = resep.Obat.nama_obat;
            }

            // Pesan jika obat tidak ditemukan
            else
            {
                MessageBox.Show("Data Obat tidak ditemukan", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            resep.kd_resep = txtKdResep.Text;
            resep.tanggal = dtpResep.Value;

            int result = controller.Create(resep);

            if (result > 0)
            {
                MessageBox.Show("input resep berhasil", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                TampilkanResep();

            }

            else
            {
                MessageBox.Show("input resep gagal", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            Reset();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwResep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwResep.SelectedIndices.Count > 0)
            {
                resep = listOfResep[lvwResep.SelectedIndices[0]];

                txtKdResep.Text = resep.kd_resep;
                dtpResep.Value = resep.tanggal;
                txtKdPasien.Text = resep.Pasien.kd_pasien;
                txtNamaPasien.Text = resep.Pasien.nama;
                txtKdPenyakit.Text = resep.Penyakit.kd_penyakit;
                txtNamaPenyakit.Text = resep.Penyakit.nama_penyakit;
                txtKdObat.Text = resep.Obat.kd_obat;
                txtNamaObat.Text = resep.Obat.nama_obat;

            }
        }
    }
}
