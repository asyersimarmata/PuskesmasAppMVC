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
    public partial class FrmPasien : Form
    {
        private List<Pasien> listOfPasien = new List<Pasien>();

        private PasienController controller;
        public FrmPasien()
        {
            InitializeComponent();
            controller = new PasienController();
            InisialisasiListView();
            TampilkanDataPasien();
        }

        private void InisialisasiListView()
        {
            lvwPasien.View = System.Windows.Forms.View.Details;
            lvwPasien.FullRowSelect = true;
            lvwPasien.GridLines = true;

            lvwPasien.Columns.Add("No.", 40, HorizontalAlignment.Center);
            lvwPasien.Columns.Add("Kode Pasien", 90, HorizontalAlignment.Center);
            lvwPasien.Columns.Add("Nama", 240, HorizontalAlignment.Center);
            lvwPasien.Columns.Add("Tanggal Lahir", 170, HorizontalAlignment.Center);
            lvwPasien.Columns.Add("Alamat", 130, HorizontalAlignment.Center);
        }

        private void TampilkanDataPasien()
        {
            lvwPasien.Items.Clear();

            listOfPasien = controller.ReadAll();

            foreach (var pasien in listOfPasien)
            {
                var noUrut = lvwPasien.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pasien.kd_pasien);
                item.SubItems.Add(pasien.nama);
                item.SubItems.Add(pasien.tgl_lahir.ToString("dd/MMMM/yyyy"));
                item.SubItems.Add(pasien.alamat);
                
                // tampilkan data pasien ke listview
                lvwPasien.Items.Add(item);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lvwPasien.Items.Clear();

            listOfPasien = controller.ReadByNama(txtNama.Text);

            foreach (var pasien in listOfPasien)
            {
                var noUrut = lvwPasien.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pasien.kd_pasien);
                item.SubItems.Add(pasien.nama);
                item.SubItems.Add(pasien.tgl_lahir.ToString("dd/MMMM/yyyy"));
                item.SubItems.Add(pasien.alamat);
                
                // tampilkan data pasien ke listview
                lvwPasien.Items.Add(item);
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwPasien.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Pasien ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek Pasien yang mau dihapus dari collection
                    Pasien pasien = listOfPasien[lvwPasien.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(pasien);
                    if (result > 0) TampilkanDataPasien();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Pasien belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OnCreateEventHandler(Pasien pasien)
        {
            // tambahkan objek pasien yang baru ke dalam collection
            listOfPasien.Add(pasien);

            int noUrut = lvwPasien.Items.Count + 1;

            // tampilkan data pasien yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pasien.kd_pasien);
            item.SubItems.Add(pasien.nama);
            item.SubItems.Add(pasien.tgl_lahir.ToString("dd/MMMM/yyyy"));
            item.SubItems.Add(pasien.alamat);

            lvwPasien.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Pasien pasien)
        {
            // ambil index data pasien yang edit
            int index = lvwPasien.SelectedIndices[0];

            // update informasi pasien di listview
            ListViewItem itemRow = lvwPasien.Items[index];
            itemRow.SubItems[1].Text = pasien.kd_pasien;
            itemRow.SubItems[2].Text = pasien.nama;
            itemRow.SubItems[3].Text = pasien.tgl_lahir.ToString("dd/MMMM/yyyy");
            itemRow.SubItems[4].Text = pasien.alamat;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryPasien frmEntry = new FrmEntryPasien("Tambah Data Pasien", controller);

            frmEntry.OnCreate += OnCreateEventHandler;

            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwPasien.SelectedItems.Count > 0)
            {
                // ambil objek pasien yang mau diedit dari collection
                Pasien pasien = listOfPasien[lvwPasien.SelectedIndices[0]];

                // buat objek form entry data Pasien
                FrmEntryPasien frmEntry = new FrmEntryPasien("Edit Data Pasien", pasien, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;

                // tampilkan form entry Pasien
                frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
