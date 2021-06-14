using Guna.UI2.WinForms.Helpers;
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
    public partial class UIEmployees : Form
    {
        public static UIEmployees instance;
        public byte typeForm = 0;
        public UIEmployees()
        {
            InitializeComponent();
            instance = this;
        }

        //private DataGridViewScrollHelper vScrollHelper;
        private void UIEmployees_Load(object sender, EventArgs e)
        {
            //vScrollHelper = new DataGridViewScrollHelper(dgvEmployee, VSBar, true);
            for (int i = 0; i < 100; i++)
            {
                dgvEmployee.Rows.Add(
                    new Object[]
                    {
                        i+1,
                        "LLAK",
                        "23/02/1998",
                        "Hà Nội",
                        "0123456786",
                        imageListEmployee.Images[1],
                        "Manager",
                        10000
                    });
            }
            //vScrollHelper.UpdateScrollBar();
        }
        private void dgvEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            typeForm = 0;
            UIAEEmployee frm = new UIAEEmployee();
            frm.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            typeForm = 1;
            UIAEEmployee frm = new UIAEEmployee();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            typeForm = 2;
            UIAEEmployee frm = new UIAEEmployee();
            frm.Show();
        }

        
    }
}
