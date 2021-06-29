using StoreManagement.Models.DAO;
using StoreManagement.Models.EF;
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
        public string productID;
        public UIProducts()
        {
            InitializeComponent();
            instance = this;
        }
        private void dgvProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            typeForm = 0;
            UIAEProduct frm = new UIAEProduct();
            frm.ShowDialog();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            typeForm = 1;
            UIAEProduct frm = new UIAEProduct();
            frm.ShowDialog();
            if (frm.Result)
            {
                ProductDAO products = new ProductDAO();
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvProduct.CurrentRow != null)
            {
                productID = dgvProduct.CurrentRow.Cells["ID"].Value.ToString();
                typeForm = 2;
                UIAEProduct frm = new UIAEProduct();
                frm.ShowDialog();
                if (frm.Result)
                {
                    LoadData();
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null)
            {
                productID = dgvProduct.CurrentRow.Cells["ID"].Value.ToString();
                ProductDAO productDAO = new ProductDAO();
                if (productDAO.Delete(productID))
                {
                    MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Delete failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }            
        }

        private void UIProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lLAKCoffeeDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.lLAKCoffeeDataSet1.products);
            // TODO: This line of code loads data into the 'lLAKCoffeeDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.lLAKCoffeeDataSet.products);
            LoadData();
        }
        private void LoadData()
        {
            dgvProduct.Rows.Clear();
            ProductDAO products = new ProductDAO();
            CategoryDAO categoryDAO = new CategoryDAO();
            foreach (product prod in products.GetAll())
            {
                dgvProduct.Rows.Add(new Object[]
                {
                    prod.ID,
                    prod.NAMEPROD,
                    categoryDAO.GetSingleByID(prod.CATEGORYID).CATENAME,
                    prod.PRICE,
                    prod.SOLD
                });
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            if (tbFind.Text.Trim() == "/all")
            {
                LoadData();
                tbFind.Text = "";
            }
            else
            {
                dgvProduct.Rows.Clear();
                CategoryDAO categoryDAO = new CategoryDAO();
                if (categoryDAO.GetSingleByName(tbFind.Text.Trim()) != null)
                {
                    foreach (product prod in productDAO.GetByKey(categoryDAO.GetSingleByName(tbFind.Text.Trim()).ID))
                    {
                        dgvProduct.Rows.Add(new Object[]
                        {
                    prod.ID,
                    prod.NAMEPROD,
                    categoryDAO.GetSingleByID(prod.CATEGORYID).CATENAME,
                    prod.PRICE,
                    prod.SOLD
                        });
                    }
                }
                tbFind.Text = "";
            }
        }
    }
}
