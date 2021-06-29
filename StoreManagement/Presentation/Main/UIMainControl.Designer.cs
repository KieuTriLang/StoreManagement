
namespace StoreManagement.Presentation.Main
{
    partial class UIMainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMainControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnUIHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUIOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnUITable = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnView = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pnView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(145)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.pnButton);
            this.panel1.Controls.Add(this.btnLogo);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 148);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(578, 26);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(63, 25);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "label1";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(278, 26);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(63, 25);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "label1";
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(147)))), ((int)(((byte)(154)))));
            this.pnButton.Controls.Add(this.btnUIHistory);
            this.pnButton.Controls.Add(this.btnUIOrder);
            this.pnButton.Controls.Add(this.btnUITable);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButton.Location = new System.Drawing.Point(223, 73);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(1077, 75);
            this.pnButton.TabIndex = 7;
            // 
            // btnUIHistory
            // 
            this.btnUIHistory.CheckedState.Parent = this.btnUIHistory;
            this.btnUIHistory.CustomBorderColor = System.Drawing.Color.Red;
            this.btnUIHistory.CustomImages.Parent = this.btnUIHistory;
            this.btnUIHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUIHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUIHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUIHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUIHistory.DisabledState.Parent = this.btnUIHistory;
            this.btnUIHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUIHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(145)))), ((int)(((byte)(137)))));
            this.btnUIHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnUIHistory.ForeColor = System.Drawing.Color.White;
            this.btnUIHistory.HoverState.Parent = this.btnUIHistory;
            this.btnUIHistory.Image = global::StoreManagement.Properties.Resources.history;
            this.btnUIHistory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUIHistory.Location = new System.Drawing.Point(718, 0);
            this.btnUIHistory.Name = "btnUIHistory";
            this.btnUIHistory.ShadowDecoration.Parent = this.btnUIHistory;
            this.btnUIHistory.Size = new System.Drawing.Size(359, 75);
            this.btnUIHistory.TabIndex = 2;
            this.btnUIHistory.Text = "History";
            this.btnUIHistory.TextOffset = new System.Drawing.Point(3, 0);
            this.btnUIHistory.Click += new System.EventHandler(this.btnUIHistory_Click);
            // 
            // btnUIOrder
            // 
            this.btnUIOrder.CheckedState.Parent = this.btnUIOrder;
            this.btnUIOrder.CustomBorderColor = System.Drawing.Color.Yellow;
            this.btnUIOrder.CustomImages.Parent = this.btnUIOrder;
            this.btnUIOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUIOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUIOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUIOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUIOrder.DisabledState.Parent = this.btnUIOrder;
            this.btnUIOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUIOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(145)))), ((int)(((byte)(137)))));
            this.btnUIOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnUIOrder.ForeColor = System.Drawing.Color.White;
            this.btnUIOrder.HoverState.Parent = this.btnUIOrder;
            this.btnUIOrder.Image = global::StoreManagement.Properties.Resources.shopping_list;
            this.btnUIOrder.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUIOrder.Location = new System.Drawing.Point(359, 0);
            this.btnUIOrder.Name = "btnUIOrder";
            this.btnUIOrder.ShadowDecoration.Parent = this.btnUIOrder;
            this.btnUIOrder.Size = new System.Drawing.Size(359, 75);
            this.btnUIOrder.TabIndex = 1;
            this.btnUIOrder.Text = "Order";
            this.btnUIOrder.TextOffset = new System.Drawing.Point(3, 0);
            this.btnUIOrder.Click += new System.EventHandler(this.btnUIOrder_Click);
            // 
            // btnUITable
            // 
            this.btnUITable.CheckedState.Parent = this.btnUITable;
            this.btnUITable.CustomBorderColor = System.Drawing.Color.Red;
            this.btnUITable.CustomImages.Parent = this.btnUITable;
            this.btnUITable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUITable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUITable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUITable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUITable.DisabledState.Parent = this.btnUITable;
            this.btnUITable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUITable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(145)))), ((int)(((byte)(137)))));
            this.btnUITable.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnUITable.ForeColor = System.Drawing.Color.White;
            this.btnUITable.HoverState.Parent = this.btnUITable;
            this.btnUITable.Image = global::StoreManagement.Properties.Resources.table;
            this.btnUITable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUITable.Location = new System.Drawing.Point(0, 0);
            this.btnUITable.Name = "btnUITable";
            this.btnUITable.ShadowDecoration.Parent = this.btnUITable;
            this.btnUITable.Size = new System.Drawing.Size(359, 75);
            this.btnUITable.TabIndex = 0;
            this.btnUITable.Text = "Table";
            this.btnUITable.TextOffset = new System.Drawing.Point(3, 0);
            this.btnUITable.Click += new System.EventHandler(this.btnUITable_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(128)))), ((int)(((byte)(130)))));
            this.btnLogo.CheckedState.Parent = this.btnLogo;
            this.btnLogo.CustomImages.Parent = this.btnLogo;
            this.btnLogo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogo.DisabledState.Parent = this.btnLogo;
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogo.FillColor = System.Drawing.Color.Transparent;
            this.btnLogo.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnLogo.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogo.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLogo.HoverState.Parent = this.btnLogo;
            this.btnLogo.Image = global::StoreManagement.Properties.Resources.coffee;
            this.btnLogo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.PressedColor = System.Drawing.Color.Transparent;
            this.btnLogo.ShadowDecoration.Parent = this.btnLogo;
            this.btnLogo.Size = new System.Drawing.Size(223, 148);
            this.btnLogo.TabIndex = 6;
            this.btnLogo.Text = "LLAK Coffee";
            this.btnLogo.TextOffset = new System.Drawing.Point(0, 5);
            this.btnLogo.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.DisabledState.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(94)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(1222, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(94)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1258, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnView
            // 
            this.pnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.pnView.Controls.Add(this.guna2Button2);
            this.pnView.Controls.Add(this.guna2ImageButton4);
            this.pnView.Controls.Add(this.guna2ImageButton3);
            this.pnView.Controls.Add(this.guna2ImageButton2);
            this.pnView.Controls.Add(this.guna2Separator1);
            this.pnView.Controls.Add(this.label2);
            this.pnView.Controls.Add(this.label1);
            this.pnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnView.Location = new System.Drawing.Point(0, 148);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(1300, 672);
            this.pnView.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(153)))), ((int)(((byte)(160)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::StoreManagement.Properties.Resources.logout;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(1123, 506);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(195, 67);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Logout";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.CheckedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Image = global::StoreManagement.Properties.Resources.green_tea_64px;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.Location = new System.Drawing.Point(600, 407);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.PressedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.ShadowDecoration.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Size = new System.Drawing.Size(150, 150);
            this.guna2ImageButton4.TabIndex = 6;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::StoreManagement.Properties.Resources.coffee_to_go_64px;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 20F;
            this.guna2ImageButton3.Location = new System.Drawing.Point(1078, 201);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.ShadowDecoration.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(150, 150);
            this.guna2ImageButton3.TabIndex = 5;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = global::StoreManagement.Properties.Resources.ice_cream_sundae_64px;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 340F;
            this.guna2ImageButton2.Location = new System.Drawing.Point(73, 183);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.ShadowDecoration.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(150, 150);
            this.guna2ImageButton2.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(463, 255);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(385, 35);
            this.guna2Separator1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 120);
            this.label2.TabIndex = 1;
            this.label2.Text = "Have a nice day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(991, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome to LLAK Coffee";
            // 
            // UIMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(147)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UIMainControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIMainControl";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnView.ResumeLayout(false);
            this.pnView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogo;
        private System.Windows.Forms.Panel pnButton;
        private Guna.UI2.WinForms.Guna2Button btnUITable;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnUIHistory;
        private Guna.UI2.WinForms.Guna2Button btnUIOrder;
        private System.Windows.Forms.Panel pnView;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}