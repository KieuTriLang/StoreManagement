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
    public partial class UIAEProduct : Form
    {
        private bool result_;
        public bool Result
        {
            get
            {
                return result_;
            }
        }
        public UIAEProduct()
        {
            InitializeComponent();
            if (UIProducts.instance.typeForm == 0)
            {
                btnTitle.Text = "Details";
                btnSave.Hide();
                btnCancel.Hide();
                LoadData(UIProducts.instance.productID);
            }
            if (UIProducts.instance.typeForm == 1)
            {
                btnTitle.Text = "Add";
                btnClose.Hide();
            }
            if (UIProducts.instance.typeForm == 2)
            {
                btnTitle.Text = "Edit";
                btnClose.Hide();
                LoadData(UIProducts.instance.productID);
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
        private product Initproduct()
        {
            ProductDAO eDAO = new ProductDAO();
            product product = new product();
            product.ID = UIProducts.instance.typeForm == 1 ? eDAO.SetID() : UIProducts.instance.productID;
            product.NAMEPROD = tbNameProd.Text.Trim();
            product.CATEGORYID = cbCategory.Text.Trim();
            product.PRICE = Int32.Parse(tbPrice.Text.Trim());
            product.BOUGHT = Int32.Parse(tbBought.Text.Trim());
            product.SOLD = Int32.Parse(tbSold.Text.Trim());
            return product;
        }
        
        private void Save()
        {

            if (checkTB())
            {
                ProductDAO eDAO = new ProductDAO();
                if (UIProducts.instance.typeForm == 1)
                {
                    product infoproduct = Initproduct();
                    if (eDAO.Add(infoproduct))
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

                    product infoproduct = Initproduct();
                    if (eDAO.Edit(infoproduct))
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
            ProductDAO eDAO = new ProductDAO();
            product info = eDAO.GetSingleByID(id);
            tbNameProd.Text = info.NAMEPROD;
            cbCategory.Text = info.CATEGORYID;
            tbPrice.Text = info.PRICE.ToString();
            tbBought.Text = info.BOUGHT.ToString();
            tbSold.Text = info.SOLD.ToString();
        }
        private bool checkTB()
        {
            if (tbNameProd.Text.Trim() == "" || cbCategory.Text.Trim() == "" || Int32.TryParse(tbPrice.Text.Trim(), out int salary) == false || Int32.TryParse(tbBought.Text.Trim(), out int bought) == false || Int32.TryParse(tbSold.Text.Trim(), out int sold) == false)
            {
                return false;
            }
            return true;
        }
    }
}
