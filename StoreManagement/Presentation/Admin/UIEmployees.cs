using Guna.UI2.WinForms.Helpers;
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
    public partial class UIEmployees : Form
    {
        public static UIEmployees instance;
        public byte typeForm = 0;
        public string employeeID;
        public UIEmployees()
        {
            InitializeComponent();
            instance = this;
        }

        //private DataGridViewScrollHelper vScrollHelper;
        private void UIEmployees_Load(object sender, EventArgs e)
        {
            
            this.employeesTableAdapter.Fill(this.lLAKCoffeeDataSet1.employees);
            EmployeeDAO employees = new EmployeeDAO();
            dgvEmployee.DataSource = employees.GetAll();
        }
        private void dgvEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            typeForm = 0;
            employeeID = dgvEmployee.CurrentRow.Cells["ID"].Value.ToString();
            UIAEEmployee frm = new UIAEEmployee();
            frm.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            typeForm = 1;
            UIAEEmployee frm = new UIAEEmployee();
            frm.ShowDialog();
            if (frm.Result)
            {
                EmployeeDAO employees = new EmployeeDAO();
                dgvEmployee.DataSource = employees.GetAll();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                typeForm = 2;
                employeeID = dgvEmployee.CurrentRow.Cells["ID"].Value.ToString();
                UIAEEmployee frm = new UIAEEmployee();
                frm.ShowDialog();
                if (frm.Result)
                {
                    EmployeeDAO employees = new EmployeeDAO();
                    dgvEmployee.DataSource = employees.GetAll();
                }
            }            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            EmployeeDAO employee = new EmployeeDAO();
            if (tbFind.Text.Trim() == "/all")
            {
                dgvEmployee.DataSource = employee.GetAll();
            }
            else
            {                
                dgvEmployee.DataSource = employee.GetByKey(tbFind.Text.Trim());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dgvEmployee.CurrentRow != null)
            {
                employeeID = dgvEmployee.CurrentRow.Cells["ID"].Value.ToString();
                EmployeeDAO eDAO = new EmployeeDAO();
                AccountDAO aDAO = new AccountDAO();
                if (aDAO.Delete(employeeID) && eDAO.Delete(employeeID))
                {
                    MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvEmployee.DataSource = eDAO.GetAll();
                }
                else
                {
                    MessageBox.Show("Delete failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                };
            }            
        }
    }
}
