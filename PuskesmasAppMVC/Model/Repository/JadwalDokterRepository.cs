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
    public class JadwalDokterRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public JadwalDokterRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public List<JadwalDokter> ReadAll()
        {
            // membuat objek collection untuk menampung objek JadwalDokter
            List<JadwalDokter> list = new List<JadwalDokter>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select jadwal_dokter.hari, jadwal_dokter.shift, dokter.nama_dokter
                               from jadwal_dokter
                               join dokter
                               on jadwal_dokter.kd_dokter = dokter.kd_dokter
                               order by kd_jadwal asc";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            JadwalDokter jadwal = new JadwalDokter();
                            jadwal.hari = dtr["hari"].ToString();
                            jadwal.shift = dtr["shift"].ToString();
                            jadwal.Dokter = new Dokter()
                            {
                                nama_dokter = dtr["nama_dokter"].ToString()
                            };
                            list.Add(jadwal);
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

        // Method untuk menampilkan data jadwaldokter berdasarkan pencarian nama
        public List<JadwalDokter> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek JadwalDokter
            List<JadwalDokter> list = new List<JadwalDokter>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select jadwal_dokter.hari, jadwal_dokter.shift, dokter.nama_dokter
                               from jadwal_dokter
                               JOIN dokter
                               on jadwal_dokter.kd_dokter = dokter.kd_dokter
                               where nama_dokter = @nama_dokter
                               order by kd_jadwal ASC";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama_dokter", nama);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            JadwalDokter jadwal = new JadwalDokter();
                            jadwal.hari = dtr["hari"].ToString();
                            jadwal.shift = dtr["shift"].ToString();
                            jadwal.Dokter = new Dokter()
                            {
                                nama_dokter = dtr["nama_dokter"].ToString()
                            };
                            list.Add(jadwal);
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

        // Method untuk menampilkan data jadwaldokter berdasarkan hari
        public List<JadwalDokter> ReadByHari(string hari)
        {
            // membuat objek collection untuk menampung objek JadwalDokter
            List<JadwalDokter> list = new List<JadwalDokter>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select jadwal_dokter.hari, jadwal_dokter.shift, dokter.nama_dokter
                               from jadwal_dokter
                               JOIN dokter
                               on jadwal_dokter.kd_dokter = dokter.kd_dokter
                               where hari = @hari
                               order by kd_jadwal ASC";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@hari", hari);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            JadwalDokter jadwal = new JadwalDokter();
                            jadwal.hari = dtr["hari"].ToString();
                            jadwal.shift = dtr["shift"].ToString();
                            jadwal.Dokter = new Dokter()
                            {
                                nama_dokter = dtr["nama_dokter"].ToString()
                            };
                            list.Add(jadwal);
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
