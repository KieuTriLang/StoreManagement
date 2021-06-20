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
            timer1.Start();
            //timer2.Start();
            //timer3.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgbToday.Value+=2;
            if(prgbToday.Value == 64)
            {
                timer1.Stop();
            }
            if(prgbToday.Value == 10)
            {
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            prgbYtd.Value+=2;
            if (prgbYtd.Value == 40)
            {
                timer2.Stop();
            }
            if(prgbYtd.Value == 6)
            {
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            cprgbCompleted.Value+=2;
            if(cprgbCompleted.Value == 78)
            {
                timer3.Stop();
            }
        }
    }
}
