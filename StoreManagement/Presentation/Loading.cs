using StoreManagement.Presentation;
using StoreManagement.Presentation.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value++;
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Stop();
                if (LoginForm.instance.role)
                {
                    UIManagement manageForm = new UIManagement();
                    manageForm.Show();
                }
                else
                {
                    this.Close();
                }
                this.Close();
            }
        }
    }
}
