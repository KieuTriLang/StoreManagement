
namespace StoreManagement.Presentation.Main.UISubOrder
{
    partial class SubOrderHistory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnViewOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.tbPayer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.lbIDBill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnListOrder = new System.Windows.Forms.Panel();
            this.pnItem = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbProdName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lLAKCoffeeDataSet = new StoreManagement.LLAKCoffeeDataSet();
            this.billsTableAdapter = new StoreManagement.LLAKCoffeeDataSetTableAdapters.billsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnViewOrder.SuspendLayout();
            this.pnListOrder.SuspendLayout();
            this.pnItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLAKCoffeeDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnViewOrder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1226, 531);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pnViewOrder
            // 
            this.pnViewOrder.Controls.Add(this.tbPayer);
            this.pnViewOrder.Controls.Add(this.btnPay);
            this.pnViewOrder.Controls.Add(this.btnDel);
            this.pnViewOrder.Controls.Add(this.lbIDBill);
            this.pnViewOrder.Controls.Add(this.label6);
            this.pnViewOrder.Controls.Add(this.lbTotalBill);
            this.pnViewOrder.Controls.Add(this.lbTB);
            this.pnViewOrder.Controls.Add(this.label5);
            this.pnViewOrder.Controls.Add(this.label4);
            this.pnViewOrder.Controls.Add(this.label3);
            this.pnViewOrder.Controls.Add(this.label2);
            this.pnViewOrder.Controls.Add(this.pnListOrder);
            this.pnViewOrder.Controls.Add(this.label1);
            this.pnViewOrder.CustomBorderColor = System.Drawing.Color.White;
            this.pnViewOrder.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnViewOrder.Location = new System.Drawing.Point(616, 3);
            this.pnViewOrder.Name = "pnViewOrder";
            this.pnViewOrder.ShadowDecoration.Parent = this.pnViewOrder;
            this.pnViewOrder.Size = new System.Drawing.Size(607, 525);
            this.pnViewOrder.TabIndex = 1;
            // 
            // tbPayer
            // 
            this.tbPayer.BorderRadius = 3;
            this.tbPayer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPayer.DefaultText = "";
            this.tbPayer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPayer.DisabledState.Parent = this.tbPayer;
            this.tbPayer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPayer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPayer.FocusedState.Parent = this.tbPayer;
            this.tbPayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPayer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPayer.HoverState.Parent = this.tbPayer;
            this.tbPayer.Location = new System.Drawing.Point(382, 463);
            this.tbPayer.Name = "tbPayer";
            this.tbPayer.PasswordChar = '\0';
            this.tbPayer.PlaceholderText = "Type the payer\'s name";
            this.tbPayer.SelectedText = "";
            this.tbPayer.ShadowDecoration.Parent = this.tbPayer;
            this.tbPayer.Size = new System.Drawing.Size(222, 31);
            this.tbPayer.TabIndex = 24;
            this.tbPayer.TextChanged += new System.EventHandler(this.tbPayer_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.DisabledState.Parent = this.btnPay;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Image = global::StoreManagement.Properties.Resources.ok_64px;
            this.btnPay.Location = new System.Drawing.Point(46, 435);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(142, 60);
            this.btnPay.TabIndex = 23;
            this.btnPay.Text = "Pay the bill";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDel
            // 
            this.btnDel.CheckedState.Parent = this.btnDel;
            this.btnDel.CustomImages.Parent = this.btnDel;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.DisabledState.Parent = this.btnDel;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.HoverState.Parent = this.btnDel;
            this.btnDel.Image = global::StoreManagement.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(208, 435);
            this.btnDel.Name = "btnDel";
            this.btnDel.ShadowDecoration.Parent = this.btnDel;
            this.btnDel.Size = new System.Drawing.Size(142, 60);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbIDBill
            // 
            this.lbIDBill.AutoSize = true;
            this.lbIDBill.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDBill.ForeColor = System.Drawing.Color.White;
            this.lbIDBill.Location = new System.Drawing.Point(347, 26);
            this.lbIDBill.Name = "lbIDBill";
            this.lbIDBill.Size = new System.Drawing.Size(55, 21);
            this.lbIDBill.TabIndex = 18;
            this.lbIDBill.Text = "00000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(290, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID Bill :";
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBill.ForeColor = System.Drawing.Color.White;
            this.lbTotalBill.Location = new System.Drawing.Point(496, 435);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(32, 25);
            this.lbTotalBill.TabIndex = 14;
            this.lbTotalBill.Text = "$0";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(75)))));
            this.lbTB.Location = new System.Drawing.Point(377, 435);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(83, 25);
            this.lbTB.TabIndex = 13;
            this.lbTB.Text = "Total Bill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(75)))));
            this.label5.Location = new System.Drawing.Point(503, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(377, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(75)))));
            this.label3.Location = new System.Drawing.Point(289, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prod Name";
            // 
            // pnListOrder
            // 
            this.pnListOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnListOrder.AutoScroll = true;
            this.pnListOrder.Controls.Add(this.pnItem);
            this.pnListOrder.Location = new System.Drawing.Point(46, 95);
            this.pnListOrder.Name = "pnListOrder";
            this.pnListOrder.Size = new System.Drawing.Size(528, 323);
            this.pnListOrder.TabIndex = 1;
            // 
            // pnItem
            // 
            this.pnItem.Controls.Add(this.lbTotal);
            this.pnItem.Controls.Add(this.lbQuantity);
            this.pnItem.Controls.Add(this.lbPrice);
            this.pnItem.Controls.Add(this.lbProdName);
            this.pnItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnItem.Location = new System.Drawing.Point(0, 0);
            this.pnItem.Name = "pnItem";
            this.pnItem.Size = new System.Drawing.Size(528, 40);
            this.pnItem.TabIndex = 1;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(466, 15);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(39, 25);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "$14";
            // 
            // lbQuantity
            // 
            this.lbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.White;
            this.lbQuantity.Location = new System.Drawing.Point(364, 15);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(22, 25);
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Text = "4";
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(250, 15);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 25);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "$3.5";
            // 
            // lbProdName
            // 
            this.lbProdName.AutoSize = true;
            this.lbProdName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdName.ForeColor = System.Drawing.Color.White;
            this.lbProdName.Location = new System.Drawing.Point(3, 15);
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(107, 25);
            this.lbProdName.TabIndex = 10;
            this.lbProdName.Text = "Black Cofee";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Order";
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "bills";
            this.billsBindingSource.DataSource = this.lLAKCoffeeDataSet;
            // 
            // lLAKCoffeeDataSet
            // 
            this.lLAKCoffeeDataSet.DataSetName = "LLAKCoffeeDataSet";
            this.lLAKCoffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbFind);
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 525);
            this.panel1.TabIndex = 2;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 69);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(607, 456);
            this.guna2DataGridView1.TabIndex = 3;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 32;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.guna2DataGridView1_CellMouseClick);
            // 
            // tbFind
            // 
            this.tbFind.BorderRadius = 4;
            this.tbFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFind.DefaultText = "";
            this.tbFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFind.DisabledState.Parent = this.tbFind;
            this.tbFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFind.FocusedState.Parent = this.tbFind;
            this.tbFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFind.HoverState.Parent = this.tbFind;
            this.tbFind.Location = new System.Drawing.Point(28, 15);
            this.tbFind.Name = "tbFind";
            this.tbFind.PasswordChar = '\0';
            this.tbFind.PlaceholderText = "Type the payer\'s name";
            this.tbFind.SelectedText = "";
            this.tbFind.ShadowDecoration.Parent = this.tbFind;
            this.tbFind.Size = new System.Drawing.Size(218, 31);
            this.tbFind.TabIndex = 4;
            this.tbFind.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // SubOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1226, 531);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "SubOrderHistory";
            this.Text = "SubOrderHistory";
            this.Load += new System.EventHandler(this.SubOrderHistory_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnViewOrder.ResumeLayout(false);
            this.pnViewOrder.PerformLayout();
            this.pnListOrder.ResumeLayout(false);
            this.pnItem.ResumeLayout(false);
            this.pnItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLAKCoffeeDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel pnViewOrder;
        private System.Windows.Forms.Label lbIDBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnListOrder;
        private System.Windows.Forms.Panel pnItem;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProdName;
        private System.Windows.Forms.Label label1;
        private LLAKCoffeeDataSet lLAKCoffeeDataSet;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private LLAKCoffeeDataSetTableAdapters.billsTableAdapter billsTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2TextBox tbPayer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbFind;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}