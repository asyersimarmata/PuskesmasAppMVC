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
    public class PenyakitController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private PenyakitRepository _repository;

        /// <summary>
        /// Method untuk menampilkan semua data Penyakit
        /// </summary>
        /// <returns></returns>
        public List<Penyakit> ReadAll()
        {
            // membuat objek collection
            List<Penyakit> list = new List<Penyakit>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PenyakitRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data penyakit berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Penyakit> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Penyakit> list = new List<Penyakit>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PenyakitRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data penyakit berdasarkan kode
        /// </summary>
        /// <param name="kd"></param>
        /// <returns></returns>
        public Penyakit ReadByKd(string kd)
        {
            // membuat objek Penyakit
            Penyakit penyakit = null;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PenyakitRepository(context);

                // panggil method ReadByNpm yang ada di dalam class repository
                penyakit = _repository.ReadByKd(kd);
            }

            return penyakit;
        }
    }
}
