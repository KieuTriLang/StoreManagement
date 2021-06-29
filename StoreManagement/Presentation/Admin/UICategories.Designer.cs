
namespace StoreManagement.Presentation.Admin
{
    partial class UICategories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tbFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VSBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dgvCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lLAKCoffeeDataSet1 = new StoreManagement.LLAKCoffeeDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.categoriesTableAdapter = new StoreManagement.LLAKCoffeeDataSet1TableAdapters.categoriesTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPDATEDATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLAKCoffeeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.tbFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 105);
            this.panel1.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnDel.FlatAppearance.BorderSize = 2;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnDel.Location = new System.Drawing.Point(975, 29);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(91, 47);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.btnEdit.Location = new System.Drawing.Point(862, 29);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 47);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(169)))), ((int)(((byte)(108)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(169)))), ((int)(((byte)(108)))));
            this.btnAdd.Location = new System.Drawing.Point(747, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 47);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.DisabledState.Parent = this.btnFind;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Image = global::StoreManagement.Properties.Resources.search_64px;
            this.btnFind.ImageSize = new System.Drawing.Size(12, 12);
            this.btnFind.Location = new System.Drawing.Point(337, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(38, 39);
            this.btnFind.TabIndex = 6;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbFind
            // 
            this.tbFind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFind.BorderRadius = 10;
            this.tbFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFind.DefaultText = "";
            this.tbFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFind.DisabledState.Parent = this.tbFind;
            this.tbFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.tbFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFind.FocusedState.Parent = this.tbFind;
            this.tbFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.tbFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFind.HoverState.Parent = this.tbFind;
            this.tbFind.Location = new System.Drawing.Point(48, 29);
            this.tbFind.Name = "tbFind";
            this.tbFind.PasswordChar = '\0';
            this.tbFind.PlaceholderText = "ID,Name";
            this.tbFind.SelectedText = "";
            this.tbFind.ShadowDecoration.Parent = this.tbFind;
            this.tbFind.Size = new System.Drawing.Size(270, 39);
            this.tbFind.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.VSBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1043, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 634);
            this.panel3.TabIndex = 5;
            // 
            // VSBar
            // 
            this.VSBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VSBar.BindingContainer = this.dgvCategory;
            this.VSBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(94)))));
            this.VSBar.HoverState.Parent = null;
            this.VSBar.InUpdate = false;
            this.VSBar.LargeChange = 1;
            this.VSBar.Location = new System.Drawing.Point(15, 0);
            this.VSBar.Maximum = 1;
            this.VSBar.Name = "VSBar";
            this.VSBar.PressedState.Parent = this.VSBar;
            this.VSBar.ScrollbarSize = 16;
            this.VSBar.Size = new System.Drawing.Size(16, 619);
            this.VSBar.TabIndex = 3;
            this.VSBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.ColumnHeadersHeight = 20;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cATENAMEDataGridViewTextBoxColumn,
            this.cREATEDATDataGridViewTextBoxColumn,
            this.uPDATEDATDataGridViewTextBoxColumn});
            this.dgvCategory.DataSource = this.categoriesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCategory.Location = new System.Drawing.Point(0, 105);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowHeadersWidth = 62;
            this.dgvCategory.RowTemplate.Height = 56;
            this.dgvCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(1043, 619);
            this.dgvCategory.TabIndex = 7;
            this.dgvCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategory.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvCategory.ThemeStyle.ReadOnly = true;
            this.dgvCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.RowsStyle.Height = 56;
            this.dgvCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCategory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategory_CellMouseDoubleClick);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.lLAKCoffeeDataSet1;
            // 
            // lLAKCoffeeDataSet1
            // 
            this.lLAKCoffeeDataSet1.DataSetName = "LLAKCoffeeDataSet1";
            this.lLAKCoffeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 724);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 15);
            this.panel2.TabIndex = 6;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // cATENAMEDataGridViewTextBoxColumn
            // 
            this.cATENAMEDataGridViewTextBoxColumn.DataPropertyName = "CATENAME";
            this.cATENAMEDataGridViewTextBoxColumn.HeaderText = "CATENAME";
            this.cATENAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cATENAMEDataGridViewTextBoxColumn.Name = "cATENAMEDataGridViewTextBoxColumn";
            this.cATENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cREATEDATDataGridViewTextBoxColumn
            // 
            this.cREATEDATDataGridViewTextBoxColumn.DataPropertyName = "CREATED_AT";
            this.cREATEDATDataGridViewTextBoxColumn.HeaderText = "CREATED_AT";
            this.cREATEDATDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cREATEDATDataGridViewTextBoxColumn.Name = "cREATEDATDataGridViewTextBoxColumn";
            this.cREATEDATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uPDATEDATDataGridViewTextBoxColumn
            // 
            this.uPDATEDATDataGridViewTextBoxColumn.DataPropertyName = "UPDATED_AT";
            this.uPDATEDATDataGridViewTextBoxColumn.HeaderText = "UPDATED_AT";
            this.uPDATEDATDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.uPDATEDATDataGridViewTextBoxColumn.Name = "uPDATEDATDataGridViewTextBoxColumn";
            this.uPDATEDATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UICategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1086, 739);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UICategories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.UICategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLAKCoffeeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2VScrollBar VSBar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategory;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private Guna.UI2.WinForms.Guna2CircleButton btnFind;
        private Guna.UI2.WinForms.Guna2TextBox tbFind;
        private LLAKCoffeeDataSet1 lLAKCoffeeDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private LLAKCoffeeDataSet1TableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPDATEDATDataGridViewTextBoxColumn;
    }
}