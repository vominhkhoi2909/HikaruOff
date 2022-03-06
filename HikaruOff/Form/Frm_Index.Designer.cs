
namespace HikaruOff
{
    partial class frm_Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Index));
            this.pnl_Index = new System.Windows.Forms.Panel();
            this.pic_LogoShop = new System.Windows.Forms.PictureBox();
            this.btn_Billing = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Staff = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Item = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Category = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Setting = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.ele_Frm_Index = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Account = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.uC_Billing1 = new HikaruOff.UC_Billing();
            this.pnl_Index.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Index
            // 
            this.pnl_Index.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Index.Controls.Add(this.uC_Billing1);
            this.pnl_Index.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Index.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Index.Location = new System.Drawing.Point(257, 0);
            this.pnl_Index.Name = "pnl_Index";
            this.pnl_Index.Size = new System.Drawing.Size(1023, 1024);
            this.pnl_Index.TabIndex = 23;
            // 
            // pic_LogoShop
            // 
            this.pic_LogoShop.Image = ((System.Drawing.Image)(resources.GetObject("pic_LogoShop.Image")));
            this.pic_LogoShop.Location = new System.Drawing.Point(12, 12);
            this.pic_LogoShop.Name = "pic_LogoShop";
            this.pic_LogoShop.Size = new System.Drawing.Size(239, 208);
            this.pic_LogoShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_LogoShop.TabIndex = 99;
            this.pic_LogoShop.TabStop = false;
            // 
            // btn_Billing
            // 
            this.btn_Billing.BackColor = System.Drawing.Color.Transparent;
            this.btn_Billing.BorderRadius = 22;
            this.btn_Billing.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Billing.Checked = true;
            this.btn_Billing.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Billing.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Billing.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_Billing.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_Billing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Billing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Billing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Billing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Billing.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Billing.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Billing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Billing.Image = ((System.Drawing.Image)(resources.GetObject("btn_Billing.Image")));
            this.btn_Billing.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Billing.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Billing.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Billing.Location = new System.Drawing.Point(12, 226);
            this.btn_Billing.Name = "btn_Billing";
            this.btn_Billing.Size = new System.Drawing.Size(239, 50);
            this.btn_Billing.TabIndex = 114;
            this.btn_Billing.Text = "Billing";
            this.btn_Billing.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Billing.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.Transparent;
            this.btn_Staff.BorderRadius = 22;
            this.btn_Staff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Staff.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Staff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Staff.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_Staff.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_Staff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Staff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Staff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Staff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Staff.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Staff.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Staff.Image = ((System.Drawing.Image)(resources.GetObject("btn_Staff.Image")));
            this.btn_Staff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Staff.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Staff.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Staff.Location = new System.Drawing.Point(12, 394);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(239, 50);
            this.btn_Staff.TabIndex = 115;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Staff.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // btn_Item
            // 
            this.btn_Item.BackColor = System.Drawing.Color.Transparent;
            this.btn_Item.BorderRadius = 22;
            this.btn_Item.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Item.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Item.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Item.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_Item.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btn_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Item.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Item.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Item.Image = ((System.Drawing.Image)(resources.GetObject("btn_Item.Image")));
            this.btn_Item.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Item.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Item.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Item.Location = new System.Drawing.Point(12, 338);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(239, 50);
            this.btn_Item.TabIndex = 116;
            this.btn_Item.Text = "Item";
            this.btn_Item.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Item.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // btn_Category
            // 
            this.btn_Category.BackColor = System.Drawing.Color.Transparent;
            this.btn_Category.BorderRadius = 22;
            this.btn_Category.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Category.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Category.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Category.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btn_Category.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Category.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Category.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Category.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Category.Image = ((System.Drawing.Image)(resources.GetObject("btn_Category.Image")));
            this.btn_Category.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Category.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Category.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Category.Location = new System.Drawing.Point(12, 282);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(239, 50);
            this.btn_Category.TabIndex = 117;
            this.btn_Category.Text = "Category";
            this.btn_Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Customer.BorderRadius = 22;
            this.btn_Customer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Customer.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Customer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Customer.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_Customer.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btn_Customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Customer.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Customer.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Customer.Image")));
            this.btn_Customer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Customer.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Customer.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Customer.Location = new System.Drawing.Point(12, 450);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(239, 50);
            this.btn_Customer.TabIndex = 119;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Customer.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.BorderRadius = 22;
            this.btn_Dashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Dashboard.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Dashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Dashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_Dashboard.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btn_Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Dashboard.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Dashboard.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Dashboard.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Dashboard.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Dashboard.Location = new System.Drawing.Point(12, 506);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(239, 50);
            this.btn_Dashboard.TabIndex = 118;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Dashboard.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.BorderRadius = 22;
            this.btn_Setting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Setting.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Setting.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Setting.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_Setting.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btn_Setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Setting.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Setting.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_Setting.Image")));
            this.btn_Setting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Setting.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Setting.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Setting.Location = new System.Drawing.Point(12, 562);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(239, 50);
            this.btn_Setting.TabIndex = 120;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Setting.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BorderRadius = 22;
            this.btn_Exit.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Exit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Exit.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Exit.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Exit.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Exit.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Exit.Location = new System.Drawing.Point(12, 962);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(239, 50);
            this.btn_Exit.TabIndex = 121;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ele_Frm_Index
            // 
            this.ele_Frm_Index.BorderRadius = 30;
            this.ele_Frm_Index.TargetControl = this;
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.Transparent;
            this.btn_Account.BorderRadius = 22;
            this.btn_Account.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Account.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Account.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_Account.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            this.btn_Account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Account.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Account.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Account.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.Image")));
            this.btn_Account.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Account.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Account.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Account.Location = new System.Drawing.Point(12, 850);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(239, 50);
            this.btn_Account.TabIndex = 124;
            this.btn_Account.Text = "Account";
            this.btn_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BorderRadius = 22;
            this.btn_Minimize.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_Minimize.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Minimize.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Minimize.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.btn_Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Minimize.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Minimize.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Minimize.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Minimize.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Minimize.Location = new System.Drawing.Point(12, 906);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(239, 50);
            this.btn_Minimize.TabIndex = 125;
            this.btn_Minimize.Text = "Minimize";
            this.btn_Minimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // uC_Billing1
            // 
            this.uC_Billing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uC_Billing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Billing1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Billing1.Location = new System.Drawing.Point(0, 0);
            this.uC_Billing1.Name = "uC_Billing1";
            this.uC_Billing1.Size = new System.Drawing.Size(1023, 1024);
            this.uC_Billing1.TabIndex = 0;
            // 
            // frm_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Dashboard);
            this.Controls.Add(this.btn_Category);
            this.Controls.Add(this.btn_Item);
            this.Controls.Add(this.btn_Staff);
            this.Controls.Add(this.btn_Billing);
            this.Controls.Add(this.pnl_Index);
            this.Controls.Add(this.pic_LogoShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.pnl_Index.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Index;
        private System.Windows.Forms.PictureBox pic_LogoShop;
        private Guna.UI2.WinForms.Guna2Button btn_Billing;
        private Guna.UI2.WinForms.Guna2Button btn_Staff;
        private Guna.UI2.WinForms.Guna2Button btn_Item;
        private Guna.UI2.WinForms.Guna2Button btn_Category;
        private Guna.UI2.WinForms.Guna2Button btn_Customer;
        private Guna.UI2.WinForms.Guna2Button btn_Dashboard;
        private Guna.UI2.WinForms.Guna2Button btn_Setting;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Guna.UI2.WinForms.Guna2Elipse ele_Frm_Index;
        private Guna.UI2.WinForms.Guna2Button btn_Minimize;
        private Guna.UI2.WinForms.Guna2Button btn_Account;
        private UC_Billing uC_Billing1;
    }
}

