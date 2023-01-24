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
    public class ObatRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public ObatRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Obat obat)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into obat (kd_obat, nama_obat)
                           values (@kd_obat, @nama_obat)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_obat", obat.kd_obat);
                cmd.Parameters.AddWithValue("@nama_obat", obat.nama_obat);
                
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create obat error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Obat obat)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update obat set
                           nama_obat = @nama_obat
                           where kd_obat = @kd_obat";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_obat", obat.kd_obat);
                cmd.Parameters.AddWithValue("@nama_obat", obat.nama_obat);

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

        public int Delete(Obat obat)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from obat
                           where kd_obat = @kd_obat";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_obat", obat.kd_obat);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete obat error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Obat> ReadAll()
        {
            // membuat objek collection untuk menampung objek Obat
            List<Obat> list = new List<Obat>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from obat order by kd_obat asc";

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
                            Obat obat = new Obat();
                            obat.kd_obat = dtr["kd_obat"].ToString();
                            obat.nama_obat = dtr["nama_obat"].ToString();

                            // tambahkan objek obat ke dalam collection
                            list.Add(obat);
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

        // Method untuk menampilkan obat berdasarkan nama
        public List<Obat> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Obat
            List<Obat> list = new List<Obat>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from obat where nama_obat like @nama_obat order by nama_obat";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama_obat", "%" + nama + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Obat obat = new Obat();
                            obat.kd_obat = dtr["kd_obat"].ToString();
                            obat.nama_obat = dtr["nama_obat"].ToString();

                            // tambahkan objek obat ke dalam collection
                            list.Add(obat);
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

        public Obat ReadByKd(string kd)
        {
            // membuat objek Penyakit
            Obat obat = null;

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from obat where kd_obat = @kd_obat";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@kd_obat", kd);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        if (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            obat = new Obat();
                            obat.kd_obat = dtr["kd_obat"].ToString();
                            obat.nama_obat = dtr["nama_obat"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByKd error: {0}", ex.Message);
            }

            return obat;
        }
    }
}
