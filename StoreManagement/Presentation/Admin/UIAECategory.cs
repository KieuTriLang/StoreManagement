using StoreManagement.Models.DAO;
using StoreManagement.Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Presentation.Admin
{
    public partial class UIAECategory : Form
    {
        private string path;
        private bool result_;
        public bool Result
        {
            get
            {
                return result_;
            }
        }
        private string key_;
        public string Key
        {
            get
            {
                return key_;
            }
        }
        private string imagePath_;
        public string ImagePath
        {
            get
            {
                return imagePath_;
            }
        }
        public UIAECategory()
        {
            InitializeComponent();
            if (UICategories.instance.typeForm == 0)
            {
                btnTitle.Text = "Details";
                btnSave.Hide();
                btnCancel.Hide();
                LoadData(UICategories.instance.categoryID);
            }
            if (UICategories.instance.typeForm == 1)
            {
                btnTitle.Text = "Add";
                btnClose.Hide();
            }
            if (UICategories.instance.typeForm == 2)
            {
                btnTitle.Text = "Edit";
                btnClose.Hide();
                LoadData(UICategories.instance.categoryID);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpload_MouseEnter(object sender, EventArgs e)
        {
            
            
        }

        private void btnUpload_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private bool checkTB()
        {
            if(tbNameCate.Text.Trim() =="")
            {
                return false;
            }
            return true;
        }
        private category InitCategory()
        {
            CategoryDAO productDAO = new CategoryDAO();
            category category = new category();
            category.ID = UICategories.instance.typeForm == 1 ? productDAO.SetID() : UICategories.instance.categoryID;
            category.CATENAME = tbNameCate.Text.Trim();
            return category;
        }
        private void Save()
        {
            if (checkTB())
            {
                string key = tbNameCate.Text.Trim();
                CategoryDAO categoryDAO = new CategoryDAO();
                
                    if(UICategories.instance.typeForm == 1)
                    {
                        category category = InitCategory();
                        if (categoryDAO.Add(category))
                        {
                            MessageBox.Show("Add successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            result_ = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Add failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        category category = InitCategory();
                        if (categoryDAO.Edit(category))
                        {
                            MessageBox.Show("Edit successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            result_ = true;
                            this.Close();
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
            CategoryDAO categoryDAO = new CategoryDAO();
            category category = categoryDAO.GetSingleByID(id);
            tbNameCate.Text = category.CATENAME;
        }
    }
}
