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
    public partial class FrmPenyakit : Form
    {
        private List<Penyakit> listOfPenyakit = new List<Penyakit>();

        private PenyakitController controller;
        public FrmPenyakit()
        {
            InitializeComponent();
            controller = new PenyakitController();
            InisialisasiListView();
            TampilkanDataPenyakit();
        }

        private void InisialisasiListView()
        {
            lvwPenyakit.View = System.Windows.Forms.View.Details;
            lvwPenyakit.FullRowSelect = true;
            lvwPenyakit.GridLines = true;

            lvwPenyakit.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPenyakit.Columns.Add("Kode Penyakit", 100, HorizontalAlignment.Center);
            lvwPenyakit.Columns.Add("Nama Penyakit", 110, HorizontalAlignment.Center);
        }

        private void TampilkanDataPenyakit()
        {
            lvwPenyakit.Items.Clear();

            listOfPenyakit = controller.ReadAll();

            foreach (var penyakit in listOfPenyakit)
            {
                var noUrut = lvwPenyakit.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(penyakit.kd_penyakit);
                item.SubItems.Add(penyakit.nama_penyakit);

                // tampilkan data Penyakit ke listview
                lvwPenyakit.Items.Add(item);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lvwPenyakit.Items.Clear();

            listOfPenyakit = controller.ReadByNama(txtNamaPenyakit.Text);

            foreach (var penyakit in listOfPenyakit)
            {
                var noUrut = lvwPenyakit.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(penyakit.kd_penyakit);
                item.SubItems.Add(penyakit.nama_penyakit);

                // tampilkan data Penyakit ke listview
                lvwPenyakit.Items.Add(item);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}