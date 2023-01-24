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
    public class DokterController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private DokterRepository _repository;

        /// <summary>
        /// Method untuk menampilkan semua data Dokter
        /// </summary>
        /// <returns></returns>
        public List<Dokter> ReadAll()
        {
            // membuat objek collection Dokter
            List<Dokter> list = new List<Dokter>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method ReadAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data dokter berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Dokter> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Dokter> list = new List<Dokter>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method ReadByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data dokter berdasarkan kode
        /// </summary>
        /// <param name="kode"></param>
        /// <returns></returns>
        public Dokter ReadByKode(string kode)
        {
            // membuat objek Dokter
            Dokter dokter = null;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method ReadByKode yang ada di dalam class repository
                dokter = _repository.ReadByKode(kode);
            }

            return dokter;
        }

        /// <summary>
        /// Method untuk menampilkan data dokter berdasarkan alamat
        /// </summary>
        /// <param name="alamat"></param>
        /// <returns></returns>
        public List<Dokter> ReadByAlamat(string alamat)
        {
            // membuat objek collection
            List<Dokter> list = new List<Dokter>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method ReadByAlamat yang ada di dalam class repository
                list = _repository.ReadByAlamat(alamat);
            }

            return list;
        }

        //method untuk Create data
        public int Create(Dokter dokter)
        {
            int result = 0;

            if (string.IsNullOrEmpty(dokter.kd_dokter))
            {
                MessageBox.Show("kode harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(dokter.nama_dokter))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(dokter.alamat_dokter))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new DokterRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(dokter);
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Dokter dokter)
        {
            int result = 0;

            /*if (string.IsNullOrEmpty(dokter.kd_dokter))
            {
                MessageBox.Show("kd harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }*/

            if (string.IsNullOrEmpty(dokter.nama_dokter))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(dokter.alamat_dokter))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(dokter);
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Dokter dokter)
        {
            int result = 0;

            if (string.IsNullOrEmpty(dokter.kd_dokter))
            {
                MessageBox.Show("Kode harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(dokter);
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
