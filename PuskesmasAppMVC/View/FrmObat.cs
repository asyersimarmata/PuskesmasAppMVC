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
    public partial class FrmObat : Form
    {
        private List<Obat> listOfObat = new List<Obat>();

        private ObatController controller;
        public FrmObat()
        {
            InitializeComponent();
            controller = new ObatController();
            InisialisasiListView();
            TampilkanDataObat();
        }

        private void InisialisasiListView()
        {
            lvwObat.View = System.Windows.Forms.View.Details;
            lvwObat.FullRowSelect = true;
            lvwObat.GridLines = true;

            lvwObat.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwObat.Columns.Add("Kode Obat", 100, HorizontalAlignment.Center);
            lvwObat.Columns.Add("Nama Obat", 110, HorizontalAlignment.Center);
        }

        private void TampilkanDataObat()
        {
            lvwObat.Items.Clear();

            listOfObat = controller.ReadAll();

            foreach (var obat in listOfObat)
            {
                var noUrut = lvwObat.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obat.kd_obat);
                item.SubItems.Add(obat.nama_obat);

                // tampilkan data obat ke listview
                lvwObat.Items.Add(item);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lvwObat.Items.Clear();

            listOfObat = controller.ReadByNama(txtNamaObat.Text);

            foreach (var obat in listOfObat)
            {
                var noUrut = lvwObat.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obat.kd_obat);
                item.SubItems.Add(obat.nama_obat);

                // tampilkan data obat ke listview
                lvwObat.Items.Add(item);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwObat.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Obat ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek Obat yang mau dihapus dari collection
                    Obat obat = listOfObat[lvwObat.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(obat);
                    if (result > 0) TampilkanDataObat();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Obat belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OnCreateEventHandler(Obat obat)
        {
            // tambahkan objek Obat yang baru ke dalam collection
            listOfObat.Add(obat);

            int noUrut = lvwObat.Items.Count + 1;

            // tampilkan data Obat yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(obat.kd_obat);
            item.SubItems.Add(obat.nama_obat);
            
            lvwObat.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Obat obat)
        {
            // ambil index data Obat yang edit
            int index = lvwObat.SelectedIndices[0];

            // update informasi Obat di listview
            ListViewItem itemRow = lvwObat.Items[index];
            itemRow.SubItems[1].Text = obat.kd_obat;
            itemRow.SubItems[2].Text = obat.nama_obat;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryObat frmEntry = new FrmEntryObat("Tambah Data Obat", controller);

            frmEntry.OnCreate += OnCreateEventHandler;

            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwObat.SelectedItems.Count > 0)
            {
                // ambil objek Obat yang mau diedit dari collection
                Obat obat = listOfObat[lvwObat.SelectedIndices[0]];

                // buat objek form entry data Obat
                FrmEntryObat frmEntry = new FrmEntryObat("Edit Data Obat", obat, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;

                // tampilkan form entry Obat
                frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }
    }
}
