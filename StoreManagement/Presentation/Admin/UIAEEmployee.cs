using StoreManagement.Models.DAO;
using StoreManagement.Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Presentation.Admin
{
    public partial class UIAEEmployee : Form
    {
        private bool result_;
        public bool Result
        {
            get
            {
                return result_;
            }
        }
        public UIAEEmployee()
        {
            InitializeComponent();
            if (UIEmployees.instance.typeForm == 0)
            {
                btnTitle.Text = "Details";
                btnSave.Hide();
                btnCancel.Hide();
                LoadData(UIEmployees.instance.employeeID);
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
                LoadData(UIEmployees.instance.employeeID);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //EVENT

        private void btnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        //FUNCTION
        private employee InitEmployee()
        {
            EmployeeDAO eDAO = new EmployeeDAO();
            employee employee = new employee();
            employee.ID = UIEmployees.instance.typeForm == 1 ? eDAO.SetID() : UIEmployees.instance.employeeID;
            employee.FULLNAME = tbName.Text.Trim();
            employee.DOB = dtpDob.Value;
            employee.ADR = tbAddress.Text.Trim();
            employee.PHONENUME = tbPhoneNum.Text.Trim();
            employee.POSITON = tbPosition.Text.Trim();
            employee.SALARY = Int32.Parse(tbSalary.Text.Trim());
            employee.FULLTIME = cbFulltime.Checked;
            return employee;
        }
        private account InitAccount(employee employee)
        {
            AccountDAO aDAO = new AccountDAO();
            account account = new account();
            account.ID = UIEmployees.instance.typeForm == 1 ? aDAO.SetID() : UIEmployees.instance.employeeID;
            account.EMPLOYEEID = employee.ID;
            account.ACC = tbAccount.Text.Trim();
            account.PASS = tbPassword.Text.Trim();
            account.ROLES = false;
            return account;
        }
        private void Save()
        {

            if (checkTB())
            {
                EmployeeDAO eDAO = new EmployeeDAO();
                if(UIEmployees.instance.typeForm == 1)
                {
                    employee infoEmployee = InitEmployee();
                    if (eDAO.Add(infoEmployee))
                    {
                        AccountDAO aDAO = new AccountDAO();
                        account infoAcc = InitAccount(infoEmployee);
                        if (aDAO.Add(infoAcc))
                        {
                            MessageBox.Show("Add successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            result_ = true;
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Add failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    employee infoEmployee = InitEmployee();
                    if (eDAO.Edit(infoEmployee))
                    {
                        AccountDAO aDAO = new AccountDAO();
                        account infoAcc = InitAccount(infoEmployee);
                        if (aDAO.Edit(infoAcc))
                        {
                            MessageBox.Show("Edit successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            result_ = true;
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Edit failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }
        
        private void LoadData(string id)
        {
            EmployeeDAO eDAO = new EmployeeDAO();
            employee info = eDAO.GetSingleByID(id);
            tbName.Text = info.FULLNAME;
            dtpDob.Value = (DateTime)info.DOB;
            tbAddress.Text = info.ADR;
            tbPhoneNum.Text = info.PHONENUME;
            tbPosition.Text = info.POSITON;
            tbSalary.Text = info.SALARY.ToString();
            cbFulltime.Checked = info.FULLTIME;

            AccountDAO aDAO = new AccountDAO();
            account acc = aDAO.GetSingleByID(id);
            tbAccount.Text = acc.ACC;
            tbPassword.Text = acc.PASS;
        }
        private bool checkTB()
        {
            if (tbName.Text.Trim() == "" || tbAddress.Text.Trim() == "" || tbPhoneNum.Text.Trim() == "" || tbPosition.Text.Trim() == "" || tbSalary.Text.Trim() == "" || Int32.TryParse(tbSalary.Text.Trim(),out int salary)==false)
            {
                return false;
            }
            return true;
        }
    }
}
