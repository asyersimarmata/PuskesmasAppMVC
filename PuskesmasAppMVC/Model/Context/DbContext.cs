﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.SQLite;

namespace PuskesmasAppMVC.Model.Context
{
    public class DbContext : IDisposable
    {
        // deklarasi private variabel / field
        private SQLiteConnection _conn;

        // deklarasi property Conn (connection), untuk menyimpan objek koneksi
        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        // Method untuk melakukan koneksi ke database
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null; // deklarasi objek connection

            try // penggunaan blok try-catch untuk penanganan error
            {
                // cara mengeset lokasi database

                // 1. set lokasi database secara absolute
                //string dbName = @"D:\Kuliah\#semester 3\Pemrograman Lanjut\#fp\#try2\PuskesmasAppMVC\Database\DbPuskesmas.db";

                // 2. set lokasi database secara relative // ada di folder bin\debug
                string dbName = Directory.GetCurrentDirectory() + @"\\Database\\DbPuskesmas.db";

                // deklarasi variabel connectionString, ref: https://www.connectionstrings.com/
                string connectionString = string.Format("Data Source={0};FailIfMissing=True", dbName);

                conn = new SQLiteConnection(connectionString); // buat objek connection
                conn.Open(); // buka koneksi ke database
            }
            // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
