using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using PuskesmasAppMVC.Model.Repository;
using PuskesmasAppMVC.Model.Context;

namespace PuskesmasAppMVC.Controller
{
    public class UserController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private UserRepository _repository;

        public bool IsValidUser(string username, string password)
        {
            
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new UserRepository(context);

                // panggil method Create class repository untuk menambahkan data
                isValidUser = _repository.IsValidUser(username, password);
            }

            if (!isValidUser)
            {
                MessageBox.Show("Username atau password salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
