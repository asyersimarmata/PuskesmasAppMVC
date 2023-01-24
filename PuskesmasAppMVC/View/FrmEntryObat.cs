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
    public partial class FrmEntryObat : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Obat obat);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private ObatController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek Obat
        private Obat obat;
        public FrmEntryObat()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FrmEntryObat(string title, ObatController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryObat(string title, Obat obj, ObatController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            obat = obj; // set objek obat yang akan diedit

            // untuk edit data, tampilkan data lama
            txtKdObat.Text = obat.kd_obat;
            txtNamaObat.Text = obat.nama_obat;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek obat
            if (isNewData) obat = new Obat();

            // set nilai property objek Obat yg diambil dari TextBox
            obat.kd_obat = txtKdObat.Text;
            obat.nama_obat = txtNamaObat.Text;
            
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(obat);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(obat); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKdObat.Clear();
                    txtNamaObat.Clear();
                    
                    txtKdObat.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(obat);

                if (result > 0)
                {
                    OnUpdate(obat); // panggil event OnUpdate
                    this.Close();
                }
            }
        }
    }
}
