using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using PuskesmasAppMVC.Model.Entity;
using PuskesmasAppMVC.Model.Context;

namespace PuskesmasAppMVC.Model.Repository
{
    public class PenyakitRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public PenyakitRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }
        public List<Penyakit> ReadAll()
        {
            // membuat objek collection untuk menampung objek Penyakit
            List<Penyakit> list = new List<Penyakit>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from penyakit order by kd_penyakit asc";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Penyakit penyakit = new Penyakit();
                            penyakit.kd_penyakit = dtr["kd_penyakit"].ToString();
                            penyakit.nama_penyakit = dtr["nama_penyakit"].ToString();
                            
                            // tambahkan objek Penyakit ke dalam collection
                            list.Add(penyakit);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan penyakit berdasarkan nama
        public List<Penyakit> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Penyakit
            List<Penyakit> list = new List<Penyakit>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from penyakit where nama_penyakit like @nama_penyakit order by nama_penyakit";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama_penyakit", "%" + nama + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Penyakit penyakit = new Penyakit();
                            penyakit.kd_penyakit = dtr["kd_penyakit"].ToString();
                            penyakit.nama_penyakit = dtr["nama_penyakit"].ToString();

                            // tambahkan objek Penyakit ke dalam collection
                            list.Add(penyakit);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan penyakit berdasarkan kode
        public Penyakit ReadByKd(string kd)
        {
            // membuat objek Penyakit
            Penyakit penyakit = null;

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from penyakit where kd_penyakit = @kd_penyakit";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@kd_penyakit", kd);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        if (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            penyakit = new Penyakit();
                            penyakit.kd_penyakit = dtr["kd_penyakit"].ToString();
                            penyakit.nama_penyakit = dtr["nama_penyakit"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByKd error: {0}", ex.Message);
            }

            return penyakit;
        }
    }
}
