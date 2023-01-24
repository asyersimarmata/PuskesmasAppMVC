using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PuskesmasAppMVC.Controller;

namespace PuskesmasAppMVC.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();

            bool isValidUser = controller.IsValidUser(txtUsername.Text, txtPassword.Text);
            if (isValidUser)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
