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
    public class PasienController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private PasienRepository _repository;

        /// <summary>
        /// Method untuk menampilkan semua data Pasien
        /// </summary>
        /// <returns></returns>
        public List<Pasien> ReadAll()
        {
            // membuat objek collection
            List<Pasien> list = new List<Pasien>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PasienRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data Pasien berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Pasien> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Pasien> list = new List<Pasien>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PasienRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data Pasien berdasarkan kode
        /// </summary>
        /// <param name="kode"></param>
        /// <returns></returns>
        public Pasien ReadByKode(string kode)
        {
            // membuat objek Pasien
            Pasien pasien = null;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PasienRepository(context);

                // panggil method ReadByNpm yang ada di dalam class repository
                pasien = _repository.ReadByKode(kode);
            }

            return pasien;
        }

        /// <summary>
        /// Method untuk menampilkan data Pasien berdasarkan alamat
        /// </summary>
        /// <param name="alamat"></param>
        /// <returns></returns>
        public List<Pasien> ReadByAlamat(string alamat)
        {
            // membuat objek collection
            List<Pasien> list = new List<Pasien>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PasienRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByAlamat(alamat);
            }

            return list;
        }

        public int Create(Pasien pasien)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pasien.kd_pasien))
            {
                MessageBox.Show("kode harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pasien.nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            
            if (string.IsNullOrEmpty(pasien.alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PasienRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(pasien);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pasien berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pasien gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Pasien pasien)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pasien.kd_pasien))
            {
                MessageBox.Show("kd harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pasien.nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pasien.alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PasienRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(pasien);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pasien berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pasien gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Pasien pasien)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pasien.kd_pasien))
            {
                MessageBox.Show("Kode harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PasienRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(pasien);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pasien berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pasien gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
