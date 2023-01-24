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
    public partial class FrmEntryPasien : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Pasien pasien);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PasienController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek Pasien
        private Pasien pasien;
        public FrmEntryPasien()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FrmEntryPasien(string title, PasienController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryPasien(string title, Pasien obj, PasienController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            pasien = obj; // set objek pasien yang akan diedit

            // untuk edit data, tampilkan data lama
            txtKdPasien.Text = pasien.kd_pasien;
            txtNama.Text = pasien.nama;
            dtpTglLahir.Value = pasien.tgl_lahir;
            txtAlamat.Text = pasien.alamat;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek Pasien
            if (isNewData) pasien = new Pasien();

            // set nilai property objek Pasien yg diambil dari TextBox
            pasien.kd_pasien = txtKdPasien.Text;
            pasien.nama = txtNama.Text;
            pasien.tgl_lahir = dtpTglLahir.Value;
            pasien.alamat = txtAlamat.Text;

            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(pasien);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(pasien); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKdPasien.Clear();
                    txtNama.Clear();
                    dtpTglLahir.ResetText();
                    txtAlamat.Clear();

                    txtKdPasien.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(pasien);

                if (result > 0)
                {
                    OnUpdate(pasien); // panggil event OnUpdate
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
