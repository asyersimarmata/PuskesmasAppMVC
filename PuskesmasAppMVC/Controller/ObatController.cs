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
    public class ObatController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private ObatRepository _repository;

        /// <summary>
        /// Method untuk menampilkan semua data Obat
        /// </summary>
        /// <returns></returns>
        public List<Obat> ReadAll()
        {
            // membuat objek collection
            List<Obat> list = new List<Obat>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ObatRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data obat berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Obat> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Obat> list = new List<Obat>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ObatRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data obat berdasarkan kode
        /// </summary>
        /// <param name="kd"></param>
        /// <returns></returns>
        public Obat ReadByKd(string kd)
        {
            // membuat objek Penyakit
            Obat obat = null;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ObatRepository(context);

                // panggil method ReadByNpm yang ada di dalam class repository
                obat = _repository.ReadByKd(kd);
            }

            return obat;
        }

        public int Create(Obat obat)
        {
            int result = 0;

            if (string.IsNullOrEmpty(obat.kd_obat))
            {
                MessageBox.Show("kode harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(obat.nama_obat))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new ObatRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(obat);
            }

            if (result > 0)
            {
                MessageBox.Show("Data obat berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data obat gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Obat obat)
        {
            int result = 0;

            if (string.IsNullOrEmpty(obat.kd_obat))
            {
                MessageBox.Show("kd harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(obat.nama_obat))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ObatRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(obat);
            }

            if (result > 0)
            {
                MessageBox.Show("Data obat berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data obat gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Obat obat)
        {
            int result = 0;

            if (string.IsNullOrEmpty(obat.kd_obat))
            {
                MessageBox.Show("Kode harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ObatRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(obat);
            }

            if (result > 0)
            {
                MessageBox.Show("Data obat berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data obat gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
