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
    public partial class FrmJadwalDokter : Form
    {
        private List<JadwalDokter> listOfJadwalDokter = new List<JadwalDokter>();
        private JadwalDokterController controller;
        public FrmJadwalDokter()
        {
            InitializeComponent();
            controller = new JadwalDokterController();
            InisialisasiListView();
            TampilkanJadwalDokter();
        }

        private void InisialisasiListView()
        {
            lvwJadwal.View = System.Windows.Forms.View.Details;
            lvwJadwal.FullRowSelect = true;
            lvwJadwal.GridLines = true;

            lvwJadwal.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwJadwal.Columns.Add("Hari", 100, HorizontalAlignment.Center);
            lvwJadwal.Columns.Add("Shift", 100, HorizontalAlignment.Center);
            lvwJadwal.Columns.Add("Nama Dokter", 250, HorizontalAlignment.Center);
        }

        private void TampilkanJadwalDokter()
        {
            lvwJadwal.Items.Clear();

            listOfJadwalDokter = controller.ReadAll();

            foreach (var jadwal in listOfJadwalDokter)
            {
                var noUrut = lvwJadwal.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(jadwal.hari);
                item.SubItems.Add(jadwal.shift);
                item.SubItems.Add(jadwal.Dokter.nama_dokter);

                // tampilkan data jadwal ke listview
                lvwJadwal.Items.Add(item);
            }
        }

        private void TampilkanBerdasarkanNama()
        {
            lvwJadwal.Items.Clear();

            listOfJadwalDokter = controller.ReadByNama(txtNama.Text);

            foreach (var jadwal in listOfJadwalDokter)
            {
                var noUrut = lvwJadwal.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(jadwal.hari);
                item.SubItems.Add(jadwal.shift);
                item.SubItems.Add(jadwal.Dokter.nama_dokter);

                // tampilkan data jadwal ke listview
                lvwJadwal.Items.Add(item);
            }
        }

        private void TampilkanBerdasarkanHari()
        {
            lvwJadwal.Items.Clear();

            listOfJadwalDokter = controller.ReadByHari(txtHari.Text);

            foreach (var jadwal in listOfJadwalDokter)
            {
                var noUrut = lvwJadwal.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(jadwal.hari);
                item.SubItems.Add(jadwal.shift);
                item.SubItems.Add(jadwal.Dokter.nama_dokter);

                // tampilkan data jadwal ke listview
                lvwJadwal.Items.Add(item);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            if (rdoHari.Checked)
            {
                TampilkanBerdasarkanHari();
            }
            else if(rdoNama.Checked)
            {
                TampilkanBerdasarkanNama();
            }
            else
            {
                TampilkanJadwalDokter();
            }
        }
    }
}
