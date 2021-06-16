using Guna.UI2.WinForms;
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
    public partial class UIAdmin : Form
    {
        public UIAdmin()
        {
            InitializeComponent();
        }

        private void UIAdmin_Load(object sender, EventArgs e)
        {
            dgvPerDay.Rows.Add(new Object[] { 100, 200, 435, 652, 523, 871, 1243 });
        }
        private void changeDgvPerDayColor(Color color)
        {
            dgvPerDay.ColumnHeadersDefaultCellStyle.BackColor = color;
            dgvPerDay.ColumnHeadersDefaultCellStyle.SelectionBackColor = color;
            dgvPerDay.DefaultCellStyle.BackColor = color;
            dgvPerDay.DefaultCellStyle.SelectionBackColor = color;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            changeDgvPerDayColor(button.FillColor);
        }

        private void btnProdSold_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            changeDgvPerDayColor(button.FillColor);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            changeDgvPerDayColor(button.FillColor);
        }
    }
}
