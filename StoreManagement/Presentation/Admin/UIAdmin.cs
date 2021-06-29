using Guna.UI2.WinForms;
using StoreManagement.Models.DAO;
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
            BillDAO billDAO = new BillDAO();
            lbTotal.Text = "Total orders: " + billDAO.GetAll().Count();
            //timer2.Start();
            //timer3.Start();
        }

        private void UIAdmin_Load(object sender, EventArgs e)
        {
            getDataPerDay("order");
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
            getDataPerDay("order");
        }

        private void btnProdSold_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            changeDgvPerDayColor(button.FillColor);
            getDataPerDay("prod");
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            changeDgvPerDayColor(button.FillColor);
            getDataPerDay("income");
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
        private void getDataPerDay(string type)
        {
            dgvPerDay.Rows.Clear();
            BillDAO billDAO = new BillDAO();
            int day = (int)DateTime.Now.DayOfWeek;
            DateTime firstOfWeek = DateTime.Now.AddDays(-day+1);
            Object[] obj;
            if (type == "order")
            {
                obj = new Object[]
                {
                    billDAO.GetOrdersPaid(firstOfWeek),
                    billDAO.GetOrdersPaid(firstOfWeek.AddDays(1)),
                    billDAO.GetOrdersPaid(firstOfWeek.AddDays(2)),
                    billDAO.GetOrdersPaid(firstOfWeek.AddDays(3)),
                    billDAO.GetOrdersPaid(firstOfWeek.AddDays(4)),
                    billDAO.GetOrdersPaid(firstOfWeek.AddDays(5)),
                    billDAO.GetOrdersPaid(firstOfWeek.AddDays(6))
                };
                dgvPerDay.Rows.Add(obj);
            }
            if(type == "prod")
            {
                obj = new Object[]
                {
                    billDAO.GetProdPaid(firstOfWeek),
                    billDAO.GetProdPaid(firstOfWeek.AddDays(1)),
                    billDAO.GetProdPaid(firstOfWeek.AddDays(2)),
                    billDAO.GetProdPaid(firstOfWeek.AddDays(3)),
                    billDAO.GetProdPaid(firstOfWeek.AddDays(4)),
                    billDAO.GetProdPaid(firstOfWeek.AddDays(5)),
                    billDAO.GetProdPaid(firstOfWeek.AddDays(6))
                };
                dgvPerDay.Rows.Add(obj);
            }
            if(type == "income")
            {
                obj = new Object[]
                {
                    billDAO.GetIncomePaid(firstOfWeek),
                    billDAO.GetIncomePaid(firstOfWeek.AddDays(1)),
                    billDAO.GetIncomePaid(firstOfWeek.AddDays(2)),
                    billDAO.GetIncomePaid(firstOfWeek.AddDays(3)),
                    billDAO.GetIncomePaid(firstOfWeek.AddDays(4)),
                    billDAO.GetIncomePaid(firstOfWeek.AddDays(5)),
                    billDAO.GetIncomePaid(firstOfWeek.AddDays(6))
                };
                dgvPerDay.Rows.Add(obj);
            }
        }
    }
}
