
namespace StoreManagement.Presentation.Admin
{
    partial class UIAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cprgbCompleted = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prgbYtd = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.prgbToday = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPerDay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncome = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdSold = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbOPD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerDay)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cprgbCompleted);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.prgbYtd);
            this.panel1.Controls.Add(this.prgbToday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(617, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 510);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Completed";
            // 
            // cprgbCompleted
            // 
            this.cprgbCompleted.Backwards = true;
            this.cprgbCompleted.FillColor = System.Drawing.Color.Empty;
            this.cprgbCompleted.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cprgbCompleted.ForeColor = System.Drawing.Color.White;
            this.cprgbCompleted.InnerColor = System.Drawing.Color.Empty;
            this.cprgbCompleted.Location = new System.Drawing.Point(66, 183);
            this.cprgbCompleted.Minimum = 0;
            this.cprgbCompleted.Name = "cprgbCompleted";
            this.cprgbCompleted.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cprgbCompleted.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(203)))));
            this.cprgbCompleted.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cprgbCompleted.ShadowDecoration.Parent = this.cprgbCompleted;
            this.cprgbCompleted.ShowPercentage = true;
            this.cprgbCompleted.Size = new System.Drawing.Size(152, 152);
            this.cprgbCompleted.TabIndex = 4;
            this.cprgbCompleted.Text = "guna2CircleProgressBar1";
            this.cprgbCompleted.Value = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yesterday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today";
            // 
            // prgbYtd
            // 
            this.prgbYtd.BorderRadius = 4;
            this.prgbYtd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(94)))));
            this.prgbYtd.Location = new System.Drawing.Point(31, 106);
            this.prgbYtd.Name = "prgbYtd";
            this.prgbYtd.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.prgbYtd.ShadowDecoration.Parent = this.prgbYtd;
            this.prgbYtd.Size = new System.Drawing.Size(227, 10);
            this.prgbYtd.TabIndex = 2;
            this.prgbYtd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.prgbYtd.Value = 87;
            // 
            // prgbToday
            // 
            this.prgbToday.BorderRadius = 4;
            this.prgbToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(94)))));
            this.prgbToday.Location = new System.Drawing.Point(31, 59);
            this.prgbToday.Name = "prgbToday";
            this.prgbToday.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.prgbToday.ShadowDecoration.Parent = this.prgbToday;
            this.prgbToday.Size = new System.Drawing.Size(227, 10);
            this.prgbToday.TabIndex = 0;
            this.prgbToday.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.prgbToday.Value = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPerDay);
            this.panel2.Controls.Add(this.btnIncome);
            this.panel2.Controls.Add(this.btnProdSold);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.lbOPD);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 335);
            this.panel2.TabIndex = 1;
            // 
            // dgvPerDay
            // 
            this.dgvPerDay.AllowUserToAddRows = false;
            this.dgvPerDay.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dgvPerDay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPerDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerDay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.dgvPerDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPerDay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerDay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPerDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerDay.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPerDay.Enabled = false;
            this.dgvPerDay.EnableHeadersVisualStyles = false;
            this.dgvPerDay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.dgvPerDay.Location = new System.Drawing.Point(47, 262);
            this.dgvPerDay.Name = "dgvPerDay";
            this.dgvPerDay.ReadOnly = true;
            this.dgvPerDay.RowHeadersVisible = false;
            this.dgvPerDay.RowHeadersWidth = 62;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvPerDay.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPerDay.RowTemplate.Height = 28;
            this.dgvPerDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerDay.Size = new System.Drawing.Size(453, 67);
            this.dgvPerDay.TabIndex = 8;
            this.dgvPerDay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerDay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPerDay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPerDay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPerDay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPerDay.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.dgvPerDay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.dgvPerDay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPerDay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPerDay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerDay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPerDay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPerDay.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvPerDay.ThemeStyle.ReadOnly = true;
            this.dgvPerDay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerDay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerDay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPerDay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPerDay.ThemeStyle.RowsStyle.Height = 28;
            this.dgvPerDay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerDay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mon";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tue";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Wed";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thu";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fri";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sat";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sun";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnIncome
            // 
            this.btnIncome.BorderRadius = 15;
            this.btnIncome.CheckedState.Parent = this.btnIncome;
            this.btnIncome.CustomImages.Parent = this.btnIncome;
            this.btnIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncome.DisabledState.Parent = this.btnIncome;
            this.btnIncome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(126)))));
            this.btnIncome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.HoverState.Parent = this.btnIncome;
            this.btnIncome.Image = global::StoreManagement.Properties.Resources.dollar;
            this.btnIncome.ImageOffset = new System.Drawing.Point(13, -17);
            this.btnIncome.ImageSize = new System.Drawing.Size(48, 48);
            this.btnIncome.Location = new System.Drawing.Point(388, 143);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.ShadowDecoration.Parent = this.btnIncome;
            this.btnIncome.Size = new System.Drawing.Size(100, 100);
            this.btnIncome.TabIndex = 7;
            this.btnIncome.Text = "Income";
            this.btnIncome.TextOffset = new System.Drawing.Point(-13, 20);
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnProdSold
            // 
            this.btnProdSold.BorderRadius = 15;
            this.btnProdSold.CheckedState.Parent = this.btnProdSold;
            this.btnProdSold.CustomImages.Parent = this.btnProdSold;
            this.btnProdSold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdSold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdSold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdSold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdSold.DisabledState.Parent = this.btnProdSold;
            this.btnProdSold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.btnProdSold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProdSold.ForeColor = System.Drawing.Color.White;
            this.btnProdSold.HoverState.Parent = this.btnProdSold;
            this.btnProdSold.Image = global::StoreManagement.Properties.Resources.box__1_;
            this.btnProdSold.ImageOffset = new System.Drawing.Point(15, -17);
            this.btnProdSold.ImageSize = new System.Drawing.Size(48, 48);
            this.btnProdSold.Location = new System.Drawing.Point(218, 143);
            this.btnProdSold.Name = "btnProdSold";
            this.btnProdSold.ShadowDecoration.Parent = this.btnProdSold;
            this.btnProdSold.Size = new System.Drawing.Size(100, 100);
            this.btnProdSold.TabIndex = 6;
            this.btnProdSold.Text = "Prod Sold";
            this.btnProdSold.TextOffset = new System.Drawing.Point(-13, 20);
            this.btnProdSold.Click += new System.EventHandler(this.btnProdSold_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BorderRadius = 15;
            this.btnOrder.CheckedState.Parent = this.btnOrder;
            this.btnOrder.CustomImages.Parent = this.btnOrder;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.DisabledState.Parent = this.btnOrder;
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(159)))));
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.Parent = this.btnOrder;
            this.btnOrder.Image = global::StoreManagement.Properties.Resources.shopping;
            this.btnOrder.ImageOffset = new System.Drawing.Point(10, -17);
            this.btnOrder.ImageSize = new System.Drawing.Size(48, 48);
            this.btnOrder.Location = new System.Drawing.Point(47, 143);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ShadowDecoration.Parent = this.btnOrder;
            this.btnOrder.Size = new System.Drawing.Size(100, 100);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextOffset = new System.Drawing.Point(-13, 20);
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(375, 35);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(206, 32);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Total orders: 20000";
            // 
            // lbOPD
            // 
            this.lbOPD.BackColor = System.Drawing.Color.Transparent;
            this.lbOPD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbOPD.ForeColor = System.Drawing.Color.White;
            this.lbOPD.Location = new System.Drawing.Point(375, 82);
            this.lbOPD.Name = "lbOPD";
            this.lbOPD.Size = new System.Drawing.Size(138, 32);
            this.lbOPD.TabIndex = 1;
            this.lbOPD.Text = "Orders/D: 56";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(223)))), ((int)(((byte)(235)))));
            this.guna2Panel1.Location = new System.Drawing.Point(20, 24);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(322, 95);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(27, 55);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(307, 34);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "It\'s good to see you again.";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(27, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(169, 34);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Hello, Admin!!";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2Separator1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 175);
            this.panel3.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(20, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(577, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // UIAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(894, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIAdmin";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.UIAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerDay)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ProgressBar prgbYtd;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar prgbToday;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbOPD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTotal;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnIncome;
        private Guna.UI2.WinForms.Guna2Button btnProdSold;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cprgbCompleted;
        private System.Windows.Forms.Label label3;
    }
}