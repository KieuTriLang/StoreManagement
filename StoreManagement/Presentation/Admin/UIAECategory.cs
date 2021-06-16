using StoreManagement.Models.DAO;
using StoreManagement.Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if(UICategories.instance.typeForm == 1 || UICategories.instance.typeForm == 2)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files | *.png*";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    btnUpload.Image = new Bitmap(path);
                }
            }
        }

        private void btnUpload_MouseEnter(object sender, EventArgs e)
        {
            if(UICategories.instance.typeForm == 1 || UICategories.instance.typeForm == 2)
            {
                btnUpload.BackColor = Color.FromArgb(143, 217, 168);
            }
            
        }

        private void btnUpload_MouseLeave(object sender, EventArgs e)
        {
            if (UICategories.instance.typeForm == 1 || UICategories.instance.typeForm == 2)
            {
                btnUpload.BackColor = Color.FromArgb(71, 100, 150);
            }
        }
        private bool checkTB()
        {
            if(tbNameCate.Text.Trim() =="")
            {
                return false;
            }
            return true;
        }
        private category InitCategory(string key)
        {
            CategoryDAO productDAO = new CategoryDAO();
            category category = new category();
            category.ID = UICategories.instance.typeForm == 1 ? productDAO.SetID() : UICategories.instance.categoryID;
            category.CATENAME = tbNameCate.Text.Trim();
            category.ILLUSTRATION = key;
            return category;
        }
        private void Save()
        {
            if (checkTB())
            {
                string key = tbNameCate.Text.Trim();
                CategoryDAO categoryDAO = new CategoryDAO();
                string newfilename = Path.Combine(Environment.CurrentDirectory, @"Images\", Path.GetFileName(path));
                string rename = Path.Combine(Environment.CurrentDirectory, @"Images\", key + ".png");
                if (File.Exists(rename))
                {
                    lbNotify.Text = "*name already exists";
                    tbNameCate.Text = "";
                }
                else
                {
                    File.Copy(path, newfilename);
                    File.Move(newfilename, rename);
                    if(UICategories.instance.typeForm == 1)
                    {
                        category category = InitCategory(key);
                        category.IMAGE_PATH = rename;
                        if (categoryDAO.Add(category))
                        {
                            MessageBox.Show("Add successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            result_ = true;
                            key_ = key;
                            imagePath_ = rename;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Add failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        category category = InitCategory(key);
                        category.IMAGE_PATH = rename;
                        if (categoryDAO.Edit(category))
                        {
                            MessageBox.Show("Edit successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            result_ = true;
                            key_ = key;
                            imagePath_ = rename;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Edit failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
        }
        private void LoadData(string id)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            category category = categoryDAO.GetSingleByID(id);
            tbNameCate.Text = category.CATENAME;
            btnUpload.Image = Image.FromFile(category.IMAGE_PATH);
        }
    }
}
