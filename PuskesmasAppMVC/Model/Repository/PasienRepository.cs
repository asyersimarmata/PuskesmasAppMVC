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
    public class PasienRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public PasienRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Pasien pasien)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into pasien (kd_pasien, nama, tgl_lahir, alamat)
                           values (@kd_pasien, @nama, @tgl_lahir, @alamat)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_pasien", pasien.kd_pasien);
                cmd.Parameters.AddWithValue("@nama", pasien.nama);
                cmd.Parameters.AddWithValue("@tgl_lahir", pasien.tgl_lahir.ToString());
                cmd.Parameters.AddWithValue("@alamat", pasien.alamat);
                
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create Pasien error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Pasien pasien)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update pasien set
                           nama = @nama,
                           alamat = @alamat,
                           tgl_lahir = @tgl_lahir
                           where kd_pasien = @kd_pasien";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_pasien", pasien.kd_pasien);
                cmd.Parameters.AddWithValue("@nama", pasien.nama);
                cmd.Parameters.AddWithValue("@tgl_lahir", pasien.tgl_lahir.ToString());
                cmd.Parameters.AddWithValue("@alamat", pasien.alamat);

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

        public int Delete(Pasien pasien)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from pasien
                           where kd_pasien = @kd_pasien";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_pasien", pasien.kd_pasien);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete Pasien error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Pasien> ReadAll()
        {
            // membuat objek collection untuk menampung objek Pasien
            List<Pasien> list = new List<Pasien>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from pasien order by kd_pasien asc";

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
                            Pasien pasien = new Pasien();
                            pasien.kd_pasien = dtr["kd_pasien"].ToString();
                            pasien.nama = dtr["nama"].ToString();
                            pasien.tgl_lahir = DateTime.Parse(dtr["tgl_lahir"].ToString());
                            pasien.alamat = dtr["alamat"].ToString();

                            // tambahkan objek Pasien ke dalam collection
                            list.Add(pasien);
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

        // Method untuk menampilkan data pasien berdasarkan nama
        public List<Pasien> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Pasien
            List<Pasien> list = new List<Pasien>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from pasien where nama like @nama order by nama";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pasien pasien = new Pasien();
                            pasien.kd_pasien = dtr["kd_pasien"].ToString();
                            pasien.nama = dtr["nama"].ToString();
                            pasien.tgl_lahir = DateTime.Parse(dtr["tgl_lahir"].ToString());
                            pasien.alamat = dtr["alamat"].ToString();
                            
                            // tambahkan objek Pasien ke dalam collection
                            list.Add(pasien);
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

        // Method untuk menampilkan pasien berdasarkan kode
        public Pasien ReadByKode(string kode)
        {
            // membuat objek Pasien
            Pasien pasien = null;

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from pasien where kd_pasien = @kd_pasien";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@kd_pasien", kode);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        if (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            pasien = new Pasien();
                            pasien.kd_pasien = dtr["kd_pasien"].ToString();
                            pasien.nama = dtr["nama"].ToString();
                            pasien.tgl_lahir = DateTime.Parse(dtr["tgl_lahir"].ToString());
                            pasien.alamat = dtr["alamat"].ToString();
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByKd error: {0}", ex.Message);
            }

            return pasien;
        }

        public List<Pasien> ReadByAlamat(string alamat)
        {
            // membuat objek collection untuk menampung objek Pasien
            List<Pasien> list = new List<Pasien>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from pasien where alamat = @alamat order by kd_pasien";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@alamat", alamat);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pasien pasien = new Pasien();
                            pasien.kd_pasien = dtr["kd_pasien"].ToString();
                            pasien.nama = dtr["nama"].ToString();
                            pasien.tgl_lahir = DateTime.Parse(dtr["tgl_lahir"].ToString());
                            pasien.alamat = dtr["alamat"].ToString();
                            
                            // tambahkan objek Pasien ke dalam collection
                            list.Add(pasien);
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
