using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Presentation.Admin
{
    public partial class UIAEEmployee : Form
    {
        public UIAEEmployee()
        {
            InitializeComponent();
            if (UIEmployees.instance.typeForm == 0)
            {
                btnTitle.Text = "Details";
                btnSave.Hide();
                btnCancel.Hide();
            }
            if (UIEmployees.instance.typeForm == 1)
            {
                btnTitle.Text = "Add";
                btnClose.Hide();
            }
            if (UIEmployees.instance.typeForm == 2) 
            { 
                btnTitle.Text = "Edit";
                btnClose.Hide();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
