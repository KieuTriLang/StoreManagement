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
    public partial class UICategories : Form
    {
        public static UICategories instance;
        public byte typeForm = 0;
        public UICategories()
        {
            InitializeComponent();
            instance = this;
        }

        private void UICategories_Load(object sender, EventArgs e)
        {
            dgvCategory.Rows.Add(new Object[] { 1, "Tea", imageList1.Images[1] });
            dgvCategory.Rows.Add(new Object[] { 2, "Ice Cream", imageList1.Images[2] });
            dgvCategory.Rows.Add(new Object[] { 3, "Coffee", imageList1.Images[0] });
        }

        private void dgvCategory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            typeForm = 0;
            UIAECategory frm = new UIAECategory();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            typeForm = 1;
            UIAECategory frm = new UIAECategory();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            typeForm = 2;
            UIAECategory frm = new UIAECategory();
            frm.Show();
        }

        
    }
}
