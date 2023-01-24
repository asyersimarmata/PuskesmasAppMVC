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
    public partial class FrmLaporanDokter : Form
    {
        private List<Dokter> listOfDokter = new List<Dokter>();

        // deklarasi objek controller
        private DokterController controller;
        public FrmLaporanDokter()
        {
            controller = new DokterController();
            InitializeComponent();
            InisialisasiListView();
        }

        // atur kolom listview
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
        private void TampilkanSemuaDokter()
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
        private void TampilkanDokterBerdasarkanNama()
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

        private void TampilkanDokterBerdasarkanKode()
        {
            lvwDokter.Items.Clear();

            Dokter dokter = controller.ReadByKode(txtKdDokter.Text);

            if (dokter != null)
            {
                var noUrut = lvwDokter.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dokter.kd_dokter);
                item.SubItems.Add(dokter.nama_dokter);
                item.SubItems.Add(dokter.alamat_dokter);

                // tampilkan data Dokter ke listview
                lvwDokter.Items.Add(item);
            }
        }
        private void TampilkanDokterBerdasarkanAlamat()
        {
            lvwDokter.Items.Clear();

            listOfDokter = controller.ReadByAlamat(txtAlamatDokter.Text);

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

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            if (rdoSemua.Checked)
            {
                TampilkanSemuaDokter();
            }
            else if (rdoBerdasarkanNama.Checked)
            {
                TampilkanDokterBerdasarkanNama();
            }
            else if (rdoBerdasarkanKode.Checked)
            {
                TampilkanDokterBerdasarkanKode();
            }
            else
            {
                TampilkanDokterBerdasarkanAlamat();
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
