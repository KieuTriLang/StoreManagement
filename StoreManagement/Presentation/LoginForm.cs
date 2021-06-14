using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.Presentation;

namespace StoreManagement.Presentation
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        public bool role;
        public LoginForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkAccount(tbAccount.Text, tbPassword.Text, cbRole.Checked))
            {
                Loading loadingForm = new Loading();
                loadingForm.Show();
                role = cbRole.Checked;
                this.Hide();
            }
            else
            {
                tbAccount.Text = "";
                tbPassword.Text = "";
                lbError.Text = "*Account or password is incorrect";
            }
        }
        private bool checkAccount(string account, string pass, bool role)
        {
            if(account == "admin" && pass == "123456" && role == true)
            {
                return true;
            }
            return false;
        }
    }
}
