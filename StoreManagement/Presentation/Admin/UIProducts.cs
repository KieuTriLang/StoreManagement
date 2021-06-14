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
    public partial class UIProducts : Form
    {
        public static UIProducts instance;
        public byte typeForm = 0;
        public UIProducts()
        {
            InitializeComponent();
            instance = this;
        }
        private void dgvProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            typeForm = 0;
            UIAEProduct frm = new UIAEProduct();
            frm.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            typeForm = 1;
            UIAEProduct frm = new UIAEProduct();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            typeForm = 2;
            UIAEProduct frm = new UIAEProduct();
            frm.Show();
        }

        
    }
}
