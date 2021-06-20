using Guna.UI2.WinForms;
using Newtonsoft.Json;
using StoreManagement.Models.DAO;
using StoreManagement.Models.EF;
using StoreManagement.Presentation.Main.UISubOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Presentation.Main
{
    public partial class UIOrderControl : Form
    {
        public Guna2Button currentButton;
        public Form currentChildForm;
        List<ProductOrder> bill = new List<ProductOrder>();
        public UIOrderControl()
        {
            InitializeComponent();
            dgvProduct.BackgroundColor = Color.FromArgb(110, 117, 130);
            LoadOrderForm();
            
        }
        private void LoadOrderForm()
        {
            lbIDBill.Text = new BillDAO().SetID();
            LoadCateList();
            LoadListOrder(bill);
        }
        private void LoadCateList()
        {
            ProductDAO productDAO = new ProductDAO();
            CategoryDAO categoryDAO = new CategoryDAO();
            dgvProduct.DataSource = productDAO.GetAll();
            cbCate.DisplayMember = "CateText";
            cbCate.ValueMember = "CateID";
            List<CategoryDAO.Cate> all = new List<CategoryDAO.Cate>(){new CategoryDAO.Cate { CateID = "/all", CateText = "All" }};
            categoryDAO.GetCategory().ForEach(e => all.Add(e));
            cbCate.DataSource = all;
            
        }
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            { 
                DisableButton();
                //Button{
                currentButton = (Guna2Button)senderBtn;
                currentButton.ForeColor = Color.FromArgb(255, 136, 75);
                //currentButton.CustomBorderThickness = new Padding(0, 0, 0, 3);
                //currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void DisableButton()
        {
            foreach (Guna2Button previousBtn in tableLayoutPanel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    previousBtn.CustomBorderThickness = new Padding(0, 0, 0, 0);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender, Color color)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            ActivateButton(btnSender, color);
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BackColor = ChangeColorBrightness(color, 0);
            this.pnMainView.Controls.Add(childForm);
            this.pnMainView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //panel1.BackColor = ChangeColorBrightness(color, -0.3);

            //End

        }
        private void btnProd_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                ActivateButton(sender, Color.FromArgb(71, 89, 126));
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubOrderHistory(), sender, Color.FromArgb(71, 89, 126));
        }

        private void UIOrderControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lLAKCoffeeDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.lLAKCoffeeDataSet.products);

        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int quantity = 0;
            foreach (ProductOrder po in bill.ToArray())
            {
                if(po.ProductName == dgvProduct.CurrentRow.Cells["NAMEPROD"].Value.ToString())
                {
                    quantity = po.Quantity;
                }
            }
            QuantityForm frm = new QuantityForm(quantity);
            frm.ShowDialog();
            if (frm.Quantity>=0)
            {
                AddToPnListOrder(frm.Quantity);
                LoadListOrder(bill);
            }
        }

        private void cbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            if (cbCate.SelectedValue.ToString() == "/all")
            {
                dgvProduct.DataSource = productDAO.GetAll();
            }
            else
            {
                dgvProduct.DataSource = productDAO.GetByKey(cbCate.SelectedValue.ToString());
            }
        }
        private void AddToPnListOrder(int quantity)
        {
            string prodName = dgvProduct.CurrentRow.Cells["NAMEPROD"].Value.ToString();
            double price = (double)dgvProduct.CurrentRow.Cells["PRICE"].Value;
            int quanity = quantity;
            if (quantity == 0)
            {
                foreach (ProductOrder po in bill.ToArray())
                {
                    if(po.ProductName == prodName)
                    {
                        bill.Remove(po);
                    }
                }
            }
            else
            {
                if(bill.Exists(po => po.ProductName == prodName))
                {
                    foreach (ProductOrder po in bill.ToArray())
                    {
                        if (po.ProductName == prodName)
                        {
                            po.Quantity = quantity;
                        }
                    }
                }
                else
                {
                    bill.Add(new ProductOrder(prodName, price, quanity));
                }
            }
        }
        private void LoadListOrder(List<ProductOrder> bill)
        {
            pnListOrder.Controls.Clear();
            double totalBill = 0;
            foreach (ProductOrder productOrder in bill)
            {
                totalBill += productOrder.Price * (double)productOrder.Quantity;

                Panel pnItem = new Panel();
                pnItem.SuspendLayout();
                Label lbProdName = new Label();
                Label lbPrice = new Label();
                Label lbQuantity = new Label();
                Label lbTotal = new Label();
                // pnItem
                // 
                pnListOrder.Controls.Add(pnItem);
                pnItem.Controls.Add(lbTotal);
                pnItem.Controls.Add(lbQuantity);
                pnItem.Controls.Add(lbPrice);
                pnItem.Controls.Add(lbProdName);
                pnItem.Dock = System.Windows.Forms.DockStyle.Top;
                pnItem.Location = new System.Drawing.Point(0, 0);
                pnItem.Name = "pnItem";
                pnItem.Size = new System.Drawing.Size(531, 40);
                pnItem.TabIndex = 1;
                // 
                // lbTotal
                // 
                lbTotal.AutoSize = true;
                lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbTotal.ForeColor = System.Drawing.Color.White;
                lbTotal.Location = new System.Drawing.Point(307, 15);
                lbTotal.Name = "lbTotal";
                lbTotal.Size = new System.Drawing.Size(39, 25);
                lbTotal.TabIndex = 13;
                lbTotal.Text = "$" + productOrder.Price*(double)productOrder.Quantity;
                // 
                // lbQuantity
                // 
                lbQuantity.AutoSize = true;
                lbQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbQuantity.ForeColor = System.Drawing.Color.White;
                lbQuantity.Location = new System.Drawing.Point(235, 15);
                lbQuantity.Name = "lbQuantity";
                lbQuantity.Size = new System.Drawing.Size(22, 25);
                lbQuantity.TabIndex = 12;
                lbQuantity.Text = productOrder.Quantity.ToString();
                // 
                // lbPrice
                // 
                lbPrice.AutoSize = true;
                lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbPrice.ForeColor = System.Drawing.Color.White;
                lbPrice.Location = new System.Drawing.Point(164, 15);
                lbPrice.Name = "lbPrice";
                lbPrice.Size = new System.Drawing.Size(46, 25);
                lbPrice.TabIndex = 11;
                lbPrice.Text = "$"+ productOrder.Price;
                // 
                // lbProdName
                // 
                lbProdName.AutoSize = true;
                lbProdName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbProdName.ForeColor = System.Drawing.Color.White;
                lbProdName.Location = new System.Drawing.Point(3, 15);
                lbProdName.Name = "lbProdName";
                lbProdName.Size = new System.Drawing.Size(107, 25);
                lbProdName.TabIndex = 10;
                lbProdName.Text = "" + productOrder.ProductName;
            }
            lbTotalBill.Text ="$"+ totalBill.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bill.Clear();
            LoadListOrder(bill);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BillDAO billDAO = new BillDAO();
            if(bill.Count() != 0)
            {
                bill b = InitBill();
                if (billDAO.Add(b))
                {
                    MessageBox.Show("Add successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            bill.Clear();
            LoadOrderForm();
        }
        private bill InitBill()
        {
            BillDAO billDAO = new BillDAO();
            bill b = new bill();
            b.ID = billDAO.SetID();
            b.IDTABLE = lbIDTable.Text;
            b.BILL1 = JsonConvert.SerializeObject(bill);
            return b;
        }
    }
}
