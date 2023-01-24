using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuskesmasAppMVC.View
{
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void mnuPasien_Click(object sender, EventArgs e)
        {
            FrmPasien frm = new FrmPasien();
            frm.ShowDialog();
        }

        private void mnuDataPasien_Click(object sender, EventArgs e)
        {
            FrmLaporanPasien frm = new FrmLaporanPasien();
            frm.ShowDialog();
        }

        private void mnuPenyakit_Click(object sender, EventArgs e)
        {
            FrmPenyakit frm = new FrmPenyakit();
            frm.ShowDialog();
        }

        private void mnuObat_Click(object sender, EventArgs e)
        {
            FrmObat frm = new FrmObat();
            frm.ShowDialog();
        }

        private void mnuDokter_Click(object sender, EventArgs e)
        {
            FrmDokter frm = new FrmDokter();
            frm.ShowDialog();
        }

        private void dataDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLaporanDokter frm = new FrmLaporanDokter();
            frm.ShowDialog();
        }

        private void jadwalDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJadwalDokter frm = new FrmJadwalDokter();
            frm.ShowDialog();
        }

        private void mnuResep_Click(object sender, EventArgs e)
        {
            FrmResep frm = new FrmResep();
            frm.ShowDialog();
        }
    }
}
