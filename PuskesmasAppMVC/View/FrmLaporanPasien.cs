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
    public partial class FrmLaporanPasien : Form
    {
        private List<Pasien> listOfPasien = new List<Pasien>();

        // deklarasi objek controller
        private PasienController controller;
        public FrmLaporanPasien()
        {
            controller = new PasienController();
            InitializeComponent();
            InisialisasiListView();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwPasien.View = System.Windows.Forms.View.Details;
            lvwPasien.FullRowSelect = true;
            lvwPasien.GridLines = true;

            lvwPasien.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwPasien.Columns.Add("Kode Pasien", 90, HorizontalAlignment.Center);
            lvwPasien.Columns.Add("Nama", 240, HorizontalAlignment.Center);
            lvwPasien.Columns.Add("Tanggal Lahir", 170, HorizontalAlignment.Center);
            lvwPasien.Columns.Add("Alamat", 130, HorizontalAlignment.Center);
        }
        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            if (rdoSemua.Checked)
            {
                TampilkanSemuaPasien();
            }
            else if (rdoBerdasarkanNama.Checked)
            {
                TampilkanPasienBerdasarkanNama();
            }
            else if(rdoBerdasarkanKode.Checked)
            {
                TampilkanPasienBerdasarkanKode();
            }
            else
            {
                TampilkanPasienBerdasarkanAlamat();
            }
        }

        private void TampilkanSemuaPasien()
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
        private void TampilkanPasienBerdasarkanNama()
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

        private void TampilkanPasienBerdasarkanKode()
        {
            lvwPasien.Items.Clear();

            Pasien pasien = controller.ReadByKode(txtKode.Text);

            if(pasien != null)
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
        private void TampilkanPasienBerdasarkanAlamat()
        {
            lvwPasien.Items.Clear();

            listOfPasien = controller.ReadByAlamat(txtAlamat.Text);

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

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
