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
    public partial class FrmEntryDokter : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Dokter dokter);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private DokterController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek Dokter
        private Dokter dokter;
        public FrmEntryDokter()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FrmEntryDokter(string title, DokterController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryDokter(string title, Dokter obj, DokterController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            dokter = obj; // set objek dokter yang akan diedit

            // untuk edit data, tampilkan data lama
            txtKdDokter.Text = dokter.kd_dokter;
            txtNamaDokter.Text = dokter.nama_dokter;
            txtAlamatDokter.Text = dokter.alamat_dokter;
        }
        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek Dokter
            if (isNewData) dokter = new Dokter();

            // set nilai property objek Dokter yg diambil dari TextBox
            dokter.kd_dokter = txtKdDokter.Text;
            dokter.nama_dokter = txtNamaDokter.Text;
            dokter.alamat_dokter = txtAlamatDokter.Text;

            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(dokter);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(dokter); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKdDokter.Clear();
                    txtNamaDokter.Clear();
                    txtAlamatDokter.Clear();

                    txtKdDokter.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(dokter);

                if (result > 0)
                {
                    OnUpdate(dokter); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
