using System;

using System.Data.SQLite;
using PuskesmasAppMVC.Model.Context;

namespace PuskesmasAppMVC.Model.Repository
{
    public class UserRepository
    {
        // deklarasi objek connection
        private SQLiteConnection _conn;

        // constructor
        public UserRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public bool IsValidUser(string username, string password)
        {
            bool result = false;

            string sql = @"select count(*) as row_count
                           from user
                           where username = @username and password = @password";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari result set
                    if (dtr.Read())
                    {
                        result = Convert.ToInt32(dtr["row_count"]) > 0;
                    }
                }
                
            }

            return result;
        }
    }
}
