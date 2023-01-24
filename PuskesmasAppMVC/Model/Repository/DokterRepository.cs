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
    public class DokterRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public DokterRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Dokter dokter)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into dokter (kd_dokter, nama_dokter, alamat_dokter)
                           values (@kd_dokter, @nama_dokter, @alamat_dokter)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_dokter", dokter.kd_dokter);
                cmd.Parameters.AddWithValue("@nama_dokter", dokter.nama_dokter);
                cmd.Parameters.AddWithValue("@alamat_dokter", dokter.alamat_dokter);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create Dokter error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Dokter dokter)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update dokter set
                           nama_dokter = @nama_dokter,
                           alamat_dokter = @alamat_dokter
                           where kd_dokter = @kd_dokter";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_dokter", dokter.kd_dokter);
                cmd.Parameters.AddWithValue("@nama_dokter", dokter.nama_dokter);
                cmd.Parameters.AddWithValue("@alamat_dokter", dokter.alamat_dokter);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Dokter dokter)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from dokter
                           where kd_dokter = @kd_dokter";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_dokter", dokter.kd_dokter);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete Dokter error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Dokter> ReadAll()
        {
            // membuat objek collection untuk menampung objek Dokter
            List<Dokter> list = new List<Dokter>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from dokter order by kd_dokter asc";

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
                            Dokter dokter = new Dokter();
                            dokter.kd_dokter = dtr["kd_dokter"].ToString();
                            dokter.nama_dokter = dtr["nama_dokter"].ToString();
                            dokter.alamat_dokter = dtr["alamat_dokter"].ToString();

                            // tambahkan objek dokter ke dalam collection
                            list.Add(dokter);
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

        // Method untuk menampilkan data dokter berdasarkan pencarian nama
        public List<Dokter> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Dokter
            List<Dokter> list = new List<Dokter>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from dokter where nama_dokter like @nama_dokter order by nama_dokter";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama_dokter", "%" + nama + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Dokter dokter = new Dokter();
                            dokter.kd_dokter = dtr["kd_dokter"].ToString();
                            dokter.nama_dokter = dtr["nama_dokter"].ToString();
                            dokter.alamat_dokter = dtr["alamat_dokter"].ToString();

                            // tambahkan objek dokter ke dalam collection
                            list.Add(dokter);
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

        // Method untuk menampilkan data dokter berdasarkan kode
        public Dokter ReadByKode(string kode)
        {
            // membuat objek Dokter
            Dokter dokter = null;

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from dokter where kd_dokter = @kd_dokter";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@kd_dokter", kode);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        if (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            dokter = new Dokter();
                            dokter.kd_dokter = dtr["kd_dokter"].ToString();
                            dokter.nama_dokter = dtr["nama_dokter"].ToString();
                            dokter.alamat_dokter = dtr["alamat_dokter"].ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByKd error: {0}", ex.Message);
            }

            return dokter;
        }

        // Method untuk menampilkan data dokter berdasarkan alamat
        public List<Dokter> ReadByAlamat(string alamat)
        {
            // membuat objek collection untuk menampung objek Dokter
            List<Dokter> list = new List<Dokter>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from dokter where alamat_dokter = @alamat_dokter order by kd_dokter";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@alamat_dokter", alamat);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Dokter dokter = new Dokter();
                            dokter.kd_dokter = dtr["kd_dokter"].ToString();
                            dokter.nama_dokter = dtr["nama_dokter"].ToString();
                            dokter.alamat_dokter = dtr["alamat_dokter"].ToString();

                            // tambahkan objek dokter ke dalam collection
                            list.Add(dokter);
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
    }
}
