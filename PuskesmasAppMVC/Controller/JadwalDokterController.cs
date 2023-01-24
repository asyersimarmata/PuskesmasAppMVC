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
    public class JadwalDokterController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private JadwalDokterRepository _repository;

        /// <summary>
        /// Method untuk menampilkan semua data JadwalDokter
        /// </summary>
        /// <returns></returns>
        public List<JadwalDokter> ReadAll()
        {
            // membuat objek collection
            List<JadwalDokter> list = new List<JadwalDokter>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new JadwalDokterRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data JadwalDokter berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<JadwalDokter> ReadByNama(string nama)
        {
            // membuat objek collection
            List<JadwalDokter> list = new List<JadwalDokter>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new JadwalDokterRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data JadwalDokter berdasarkan hari
        /// </summary>
        /// <param name="hari"></param>
        /// <returns></returns>
        public List<JadwalDokter> ReadByHari(string hari)
        {
            // membuat objek collection
            List<JadwalDokter> list = new List<JadwalDokter>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new JadwalDokterRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByHari(hari);
            }

            return list;
        }
    }
}
