using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using PuskesmasAppMVC.Model.Entity;
using PuskesmasAppMVC.Model.Repository;
using PuskesmasAppMVC.Model.Context;

namespace PuskesmasAppMVC.Controller
{
    public class ResepController
    {
        // deklarasi objek repository
        private ResepRepository _repository;

        // method untuk cek input data
        private bool Validate(Resep resep)
        {
            
            if (string.IsNullOrEmpty(resep.kd_resep))
            {
                MessageBox.Show("kode resep harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(resep.tanggal==null)
            {
                MessageBox.Show("tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(resep.Pasien==null)
            {
                MessageBox.Show("pasien harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (resep.Penyakit == null)
            {
                MessageBox.Show("penyakit harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (resep.Obat == null)
            {
                MessageBox.Show("obat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        // method untuk membuat data
        public int Create(Resep resep)
        {
            int result = 0;

            // panggil method untuk pengecekan
            if (!Validate(resep)) return 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new ResepRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(resep);
            }

            if (result > 0)
            {
                MessageBox.Show("Resep berhasil diiinput !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Resep gagal diinput !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        // method untuk menampilkan semua data Resep
        public List<Resep> ReadAll()
        {
            var items = new List<Resep>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ResepRepository(context);

                // panggil method
                items = _repository.ReadAll();
            }

            return items;
        }

        // method untuk menampilkan Resep berdasarkan kode
        public Resep ReadByKd(string kd)
        {
            Resep item = null;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ResepRepository(context);

                // panggil method berdasarkan id Resep
                item = _repository.ReadByKd(kd);
            }
            return item;
        }
    }
}
