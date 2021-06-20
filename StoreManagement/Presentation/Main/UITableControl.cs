using Guna.UI2.WinForms;
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

namespace StoreManagement.Presentation.Main
{
    public partial class UITableControl : Form
    { 
        public UITableControl()
        {
            InitializeComponent();
            fpn.BackColor = Color.FromArgb(173, 108, 128);
            TableDAO tableDAO = new TableDAO();
            List<table> tables = tableDAO.GetAll();
            foreach(table tb in tables)
            {
                Guna2Button btn = new Guna2Button();
                fpn.Controls.Add(btn);
                btn.BorderRadius = 10;
                btn.CheckedState.Parent = btn;
                btn.CustomImages.Parent = btn;
                btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.DisabledState.Parent = btn;
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.White;
                btn.HoverState.Parent = btn;
                btn.Image = global::StoreManagement.Properties.Resources.table;
                btn.ImageOffset = new System.Drawing.Point(22, 0);
                btn.ImageSize = new System.Drawing.Size(48, 48);
                btn.Location = new System.Drawing.Point(10, 10);
                btn.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
                btn.Name = tb.ID;
                btn.ShadowDecoration.Parent = btn;
                btn.Size = new System.Drawing.Size(158, 149);
                btn.TabIndex = 1;
                btn.Text = "Table " + tb.ID +"("+tb.ISEMPTY+"/"+tb.RESERVES+")";
                btn.TextOffset = new System.Drawing.Point(-12, 30);
                btn.Click += new System.EventHandler(this.table_click);
            }
            
        }
        private void table_click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            MessageBox.Show("There are no feature. " + btn.Text);
        }
    }
}
