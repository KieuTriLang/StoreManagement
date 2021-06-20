using StoreManagement.Models.DAO;
using StoreManagement.Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public string categoryID;
        public UICategories()
        {
            InitializeComponent();
            instance = this;
        }

        private void UICategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lLAKCoffeeDataSet.categories' table. You can move, or remove it, as needed.
            //this.categoriesTableAdapter.Fill(this.lLAKCoffeeDataSet.categories);
            LoadData();
        }
        private void LoadData()
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            //dgvCategory.DataSource = categoryDAO.GetAll();
            List<category> data = categoryDAO.GetAll();
            imageList1.Images.Clear();
            dgvCategory.Rows.Clear();
            dgvCategory.Refresh();
            foreach (category category in data)
            {
                imageList1.Images.Add(category.ILLUSTRATION, Image.FromFile(category.IMAGE_PATH));
                dgvCategory.Rows.Add(
                    new Object[]
                    {
                        category.ID,
                        category.CATENAME,
                        imageList1.Images[category.ILLUSTRATION]
                    }
                    );
            }
        }
        private void dgvCategory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            typeForm = 0;
            categoryID = dgvCategory.CurrentRow.Cells["ID"].Value.ToString();
            UIAECategory frm = new UIAECategory();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            typeForm = 1;
            UIAECategory frm = new UIAECategory();
            frm.ShowDialog();
            if (frm.Result)
            {
                imageList1.Images.Add(frm.Key, Image.FromFile(frm.ImagePath));
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow != null)
            {
                typeForm = 2;
                categoryID = dgvCategory.CurrentRow.Cells["ID"].Value.ToString();
                UIAECategory frm = new UIAECategory();
                frm.ShowDialog();
                if (frm.Result)
                {
                    CategoryDAO categoryDAO = new CategoryDAO();
                    imageList1.Images.RemoveByKey(categoryDAO.GetSingleByID(categoryID).ILLUSTRATION);
                    imageList1.Images.Add(frm.Key, Image.FromFile(frm.ImagePath));
                    LoadData();
                }
            }            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dgvCategory.CurrentRow!= null)
            {
                CategoryDAO categoryDAO = new CategoryDAO();
                categoryID = dgvCategory.CurrentRow.Cells["ID"].Value.ToString();
                category cate = categoryDAO.GetSingleByID(categoryID);
                if (categoryDAO.Delete(categoryID))
                {
                    imageList1.Images.Clear();
                    //File.Delete(cate.IMAGE_PATH);
                    MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Delete failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(tbFind.Text.Trim() == "/all")
            {
                LoadData();
            }
            else
            {
                CategoryDAO categoryDAO = new CategoryDAO();
                //dgvCategory.DataSource = categoryDAO.GetAll();
                List<category> data = categoryDAO.GetByKey(tbFind.Text.Trim());
                imageList1.Images.Clear();
                dgvCategory.Rows.Clear();
                dgvCategory.Refresh();
                foreach (category category in data)
                {
                    imageList1.Images.Add(category.ILLUSTRATION, Image.FromFile(category.IMAGE_PATH));
                    dgvCategory.Rows.Add(
                        new Object[]
                        {
                        category.ID,
                        category.CATENAME,
                        imageList1.Images[category.ILLUSTRATION]
                        }
                        );
                }
            }
            
        }
    }
}
