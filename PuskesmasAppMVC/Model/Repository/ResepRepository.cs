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
    public class ResepRepository
    {
		// deklarsi objek connection
		private SQLiteConnection _conn;

		// constructor
		public ResepRepository(DbContext context)
		{
			// inisialisasi objek connection
			_conn = context.Conn;
		}

		public int Create(Resep resep)
		{
			int result = 0;

			// deklarasi perintah SQL
			string sql = @"insert into resep (kd_resep, tanggal, kd_pasien, kd_penyakit, kd_obat)
							values (@kd_resep, @tanggal, @kd_pasien, @kd_penyakit, @kd_obat)";

			// membuat objek command menggunakan blok using
			using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
			{
				// mendaftarkan parameter dan mengeset nilainya
				cmd.Parameters.AddWithValue("@kd_resep", resep.kd_resep);
				cmd.Parameters.AddWithValue("@tanggal", resep.tanggal.ToString("dd/MMMM/yyyy"));
				cmd.Parameters.AddWithValue("@kd_pasien", resep.Pasien.kd_pasien);
				cmd.Parameters.AddWithValue("@kd_penyakit", resep.Penyakit.kd_penyakit);
				cmd.Parameters.AddWithValue("@kd_obat", resep.Obat.kd_obat);
				
				try
				{
					// jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
					result = cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
				}
			}

			return result;
		}

		public List<Resep> ReadAll()
		{
			var items = new List<Resep>();

            try
            {
				// deklarasi perintah SQL
				string sql = @"select kd_resep, tanggal, resep.kd_pasien, resep.kd_penyakit, resep.kd_obat,
							pasien.nama, tgl_lahir, alamat,
							penyakit.nama_penyakit,
							obat.nama_obat
							from resep
							join pasien
							on pasien.kd_pasien = resep.kd_pasien
							join penyakit
							on penyakit.kd_penyakit = resep.kd_penyakit
							join obat
							on obat.kd_obat = resep.kd_obat
							order by kd_resep asc";

				// membuat objek command menggunakan blok using
				using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
				{
					using (SQLiteDataReader dtr = cmd.ExecuteReader())
					{
						while (dtr.Read())
						{
							var item = new Resep()
							{
								kd_resep = dtr["kd_resep"].ToString(),
								tanggal = DateTime.Parse(dtr["tanggal"].ToString()),
								Pasien = new Pasien()
								{
									kd_pasien = dtr["kd_pasien"].ToString(),
									nama = dtr["nama"].ToString(),
									tgl_lahir = DateTime.Parse(dtr["tgl_lahir"].ToString()),
									alamat = dtr["alamat"].ToString(),
								},
								Penyakit = new Penyakit()
								{
									kd_penyakit = dtr["kd_penyakit"].ToString(),
									nama_penyakit = dtr["nama_penyakit"].ToString(),
								},
								Obat = new Obat()
								{
									kd_obat = dtr["kd_obat"].ToString(),
									nama_obat = dtr["nama_obat"].ToString(),
								}
							};
							items.Add(item);
						}
					}
				}
			}
			catch (Exception ex)
            {
				System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);

			}

			return items;
		}

		public Resep ReadByKd(string kd)
		{

			Resep item = null;
            try
            {
				// deklarasi perintah SQL
				string sql = @"select resep.kd_resep, resep.tanggal, pasien.nama, penyakit.nama_penyakit, obat.nama_obat
                               from resep
                               join pasien
                               on resep.kd_pasien = pasien.kd_pasien
                               join penyakit
                               on resep.kd_penyakit = penyakit.kd_penyakit
                               join obat
                               on resep.kd_obat = obat.kd_obat
                               where kd_resep=@kd_resep";

				// membuat objek command menggunakan blok using
				using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
				{
					cmd.Parameters.AddWithValue("@kd_resep", kd);
					using (SQLiteDataReader dtr = cmd.ExecuteReader())
					{
						while (dtr.Read())
						{
							item.kd_resep = dtr["kd_resep"].ToString();
							item.tanggal = DateTime.Parse(dtr["tanggal"].ToString());
							item.Pasien = new Pasien()
							{
								kd_pasien = dtr["kd_pasien"].ToString(),
								nama = dtr["nama"].ToString(),
							};
							item.Penyakit = new Penyakit()
							{
								kd_penyakit = dtr["kd_penyakit"].ToString(),
								nama_penyakit = dtr["nama_penyakit"].ToString(),
							};
							item.Obat = new Obat()
							{
								kd_obat = dtr["kd_obat"].ToString(),
								nama_obat = dtr["nama_obat"].ToString(),
							};
						}
					}
				}
			}
            catch (Exception ex)
            {
				System.Diagnostics.Debug.Print("ReadByKd error: {0}", ex.Message);

			}
			return item;
		}
	}
}
