using Newtonsoft.Json;
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

namespace StoreManagement.Presentation.Main.UISubOrder
{
    public partial class SubOrderHistory : Form
    {
        public string json;
        public SubOrderHistory()
        {
            InitializeComponent();
            guna2DataGridView1.DataSource = new BillDAO().GetAll();
            guna2DataGridView1.BackgroundColor = Color.FromArgb(71, 89, 126);
            pnListOrder.Controls.Clear();
        }

        private void SubOrderHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lLAKCoffeeDataSet.bills' table. You can move, or remove it, as needed.
            //this.billsTableAdapter.Fill(this.lLAKCoffeeDataSet.bills);

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
                lbTotal.Text = "$" + productOrder.Price * (double)productOrder.Quantity;
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
                lbPrice.Text = "$" + productOrder.Price;
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
            lbTotalBill.Text = "$" + totalBill.ToString();
        }

        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbIDBill.Text = guna2DataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            lbIDTable.Text = guna2DataGridView1.CurrentRow.Cells["IDTable"].Value.ToString();
            json = guna2DataGridView1.CurrentRow.Cells["BILL1"].Value.ToString();
            LoadListOrder(JsonConvert.DeserializeObject<List<ProductOrder>>(json));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = guna2DataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            BillDAO billDAO = new BillDAO();
            if (billDAO.Delete(id))
            {
                MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guna2DataGridView1.DataSource = new BillDAO().GetAll();
                pnListOrder.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Delete failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
