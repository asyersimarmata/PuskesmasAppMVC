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
    public partial class FrmDokter : Form
    {
        private List<Dokter> listOfDokter = new List<Dokter>();

        private DokterController controller;
        public FrmDokter()
        {
            InitializeComponent();
            controller = new DokterController();
            InisialisasiListView();
            TampilkanDataDokter();
        }

        private void InisialisasiListView()
        {
            lvwDokter.View = System.Windows.Forms.View.Details;
            lvwDokter.FullRowSelect = true;
            lvwDokter.GridLines = true;

            lvwDokter.Columns.Add("No.", 40, HorizontalAlignment.Center);
            lvwDokter.Columns.Add("Kode Dokter", 90, HorizontalAlignment.Center);
            lvwDokter.Columns.Add("Nama", 240, HorizontalAlignment.Center);
            lvwDokter.Columns.Add("Alamat", 130, HorizontalAlignment.Center);
        }

        private void TampilkanDataDokter()
        {
            lvwDokter.Items.Clear();

            listOfDokter = controller.ReadAll();

            foreach (var dokter in listOfDokter)
            {
                var noUrut = lvwDokter.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dokter.kd_dokter);
                item.SubItems.Add(dokter.nama_dokter);
                item.SubItems.Add(dokter.alamat_dokter);

                // tampilkan data dokter ke listview
                lvwDokter.Items.Add(item);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lvwDokter.Items.Clear();

            listOfDokter = controller.ReadByNama(txtNamaDokter.Text);

            foreach (var dokter in listOfDokter)
            {
                var noUrut = lvwDokter.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dokter.kd_dokter);
                item.SubItems.Add(dokter.nama_dokter);
                item.SubItems.Add(dokter.alamat_dokter);

                // tampilkan data dokter ke listview
                lvwDokter.Items.Add(item);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwDokter.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Dokter ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek Dokter yang mau dihapus dari collection
                    Dokter dokter = listOfDokter[lvwDokter.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(dokter);
                    if (result > 0) TampilkanDataDokter();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Dokter belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OnCreateEventHandler(Dokter dokter)
        {
            // tambahkan objek dokter yang baru ke dalam collection
            listOfDokter.Add(dokter);

            int noUrut = lvwDokter.Items.Count + 1;

            // tampilkan data Dokter yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(dokter.kd_dokter);
            item.SubItems.Add(dokter.nama_dokter);
            item.SubItems.Add(dokter.alamat_dokter);

            lvwDokter.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Dokter dokter)
        {
            // ambil index data dokter yang edit
            int index = lvwDokter.SelectedIndices[0];

            // update informasi Dokter di listview
            ListViewItem itemRow = lvwDokter.Items[index];
            itemRow.SubItems[1].Text = dokter.kd_dokter;
            itemRow.SubItems[2].Text = dokter.nama_dokter;
            itemRow.SubItems[3].Text = dokter.alamat_dokter;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryDokter frmEntry = new FrmEntryDokter("Tambah Data Dokter", controller);

            frmEntry.OnCreate += OnCreateEventHandler;

            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwDokter.SelectedItems.Count > 0)
            {
                // ambil objek Dokter yang mau diedit dari collection
                Dokter dokter = listOfDokter[lvwDokter.SelectedIndices[0]];

                // buat objek form entry data Dokter
                FrmEntryDokter frmEntry = new FrmEntryDokter("Edit Data Dokter", dokter, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;

                // tampilkan form entry dokter
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