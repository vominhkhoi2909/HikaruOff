
namespace HikaruOff
{
    partial class UC_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Item));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_ButtonList = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Renew = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Item = new Guna.UI2.WinForms.Guna2Panel();
            this.rtb_Notes = new System.Windows.Forms.RichTextBox();
            this.txt_SellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_BuyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Quantily = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.dtm_AddDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbo_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Catelory = new System.Windows.Forms.Label();
            this.lbl_AddedOn = new System.Windows.Forms.Label();
            this.lbl_SellPrice = new System.Windows.Forms.Label();
            this.lbl_BuyPrice = new System.Windows.Forms.Label();
            this.lbl_Quantily = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pnl_Data = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Item = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAddDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ele_UC_Item = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_ButtonList.SuspendLayout();
            this.pnl_Item.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ButtonList
            // 
            this.pnl_ButtonList.Controls.Add(this.btn_Renew);
            this.pnl_ButtonList.Controls.Add(this.btn_Delete);
            this.pnl_ButtonList.Controls.Add(this.btn_Add);
            this.pnl_ButtonList.Controls.Add(this.btn_Save);
            this.pnl_ButtonList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_ButtonList.Location = new System.Drawing.Point(0, 959);
            this.pnl_ButtonList.Name = "pnl_ButtonList";
            this.pnl_ButtonList.Size = new System.Drawing.Size(1023, 65);
            this.pnl_ButtonList.TabIndex = 0;
            // 
            // btn_Renew
            // 
            this.btn_Renew.AutoRoundedCorners = true;
            this.btn_Renew.BorderRadius = 25;
            this.btn_Renew.BorderThickness = 1;
            this.btn_Renew.DefaultAutoSize = true;
            this.btn_Renew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Renew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Renew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Renew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Renew.FillColor = System.Drawing.Color.White;
            this.btn_Renew.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Renew.ForeColor = System.Drawing.Color.Black;
            this.btn_Renew.Location = new System.Drawing.Point(879, 9);
            this.btn_Renew.Name = "btn_Renew";
            this.btn_Renew.Size = new System.Drawing.Size(141, 53);
            this.btn_Renew.TabIndex = 101;
            this.btn_Renew.Text = "Renew";
            this.btn_Renew.Click += new System.EventHandler(this.btn_Renew_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoRoundedCorners = true;
            this.btn_Delete.BorderRadius = 25;
            this.btn_Delete.BorderThickness = 1;
            this.btn_Delete.DefaultAutoSize = true;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.White;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(740, 9);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(133, 53);
            this.btn_Delete.TabIndex = 100;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AutoRoundedCorners = true;
            this.btn_Add.BorderRadius = 25;
            this.btn_Add.BorderThickness = 1;
            this.btn_Add.DefaultAutoSize = true;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(516, 9);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(103, 53);
            this.btn_Add.TabIndex = 99;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoRoundedCorners = true;
            this.btn_Save.BorderRadius = 25;
            this.btn_Save.BorderThickness = 1;
            this.btn_Save.DefaultAutoSize = true;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.FillColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(625, 9);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 53);
            this.btn_Save.TabIndex = 98;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pnl_Item
            // 
            this.pnl_Item.Controls.Add(this.rtb_Notes);
            this.pnl_Item.Controls.Add(this.txt_SellPrice);
            this.pnl_Item.Controls.Add(this.txt_BuyPrice);
            this.pnl_Item.Controls.Add(this.txt_Quantily);
            this.pnl_Item.Controls.Add(this.txt_Name);
            this.pnl_Item.Controls.Add(this.lbl_Notes);
            this.pnl_Item.Controls.Add(this.dtm_AddDate);
            this.pnl_Item.Controls.Add(this.cbo_Category);
            this.pnl_Item.Controls.Add(this.lbl_Catelory);
            this.pnl_Item.Controls.Add(this.lbl_AddedOn);
            this.pnl_Item.Controls.Add(this.lbl_SellPrice);
            this.pnl_Item.Controls.Add(this.lbl_BuyPrice);
            this.pnl_Item.Controls.Add(this.lbl_Quantily);
            this.pnl_Item.Controls.Add(this.lbl_Name);
            this.pnl_Item.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Item.Location = new System.Drawing.Point(0, 0);
            this.pnl_Item.Name = "pnl_Item";
            this.pnl_Item.Size = new System.Drawing.Size(1023, 438);
            this.pnl_Item.TabIndex = 1;
            // 
            // rtb_Notes
            // 
            this.rtb_Notes.Location = new System.Drawing.Point(518, 268);
            this.rtb_Notes.Name = "rtb_Notes";
            this.rtb_Notes.Size = new System.Drawing.Size(493, 137);
            this.rtb_Notes.TabIndex = 142;
            this.rtb_Notes.Text = "";
            // 
            // txt_SellPrice
            // 
            this.txt_SellPrice.AutoRoundedCorners = true;
            this.txt_SellPrice.BorderColor = System.Drawing.Color.Black;
            this.txt_SellPrice.BorderRadius = 26;
            this.txt_SellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SellPrice.DefaultText = "";
            this.txt_SellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SellPrice.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_SellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SellPrice.Location = new System.Drawing.Point(518, 165);
            this.txt_SellPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txt_SellPrice.Name = "txt_SellPrice";
            this.txt_SellPrice.PasswordChar = '\0';
            this.txt_SellPrice.PlaceholderText = "Enter Text";
            this.txt_SellPrice.SelectedText = "";
            this.txt_SellPrice.Size = new System.Drawing.Size(493, 55);
            this.txt_SellPrice.TabIndex = 141;
            // 
            // txt_BuyPrice
            // 
            this.txt_BuyPrice.AutoRoundedCorners = true;
            this.txt_BuyPrice.BorderColor = System.Drawing.Color.Black;
            this.txt_BuyPrice.BorderRadius = 26;
            this.txt_BuyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BuyPrice.DefaultText = "";
            this.txt_BuyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_BuyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_BuyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BuyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BuyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BuyPrice.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_BuyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BuyPrice.Location = new System.Drawing.Point(10, 165);
            this.txt_BuyPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txt_BuyPrice.Name = "txt_BuyPrice";
            this.txt_BuyPrice.PasswordChar = '\0';
            this.txt_BuyPrice.PlaceholderText = "Enter Text";
            this.txt_BuyPrice.SelectedText = "";
            this.txt_BuyPrice.Size = new System.Drawing.Size(493, 55);
            this.txt_BuyPrice.TabIndex = 140;
            // 
            // txt_Quantily
            // 
            this.txt_Quantily.AutoRoundedCorners = true;
            this.txt_Quantily.BorderColor = System.Drawing.Color.Black;
            this.txt_Quantily.BorderRadius = 26;
            this.txt_Quantily.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Quantily.DefaultText = "";
            this.txt_Quantily.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Quantily.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Quantily.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Quantily.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Quantily.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Quantily.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_Quantily.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Quantily.Location = new System.Drawing.Point(518, 60);
            this.txt_Quantily.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Quantily.Name = "txt_Quantily";
            this.txt_Quantily.PasswordChar = '\0';
            this.txt_Quantily.PlaceholderText = "Enter Text";
            this.txt_Quantily.SelectedText = "";
            this.txt_Quantily.Size = new System.Drawing.Size(493, 55);
            this.txt_Quantily.TabIndex = 139;
            // 
            // txt_Name
            // 
            this.txt_Name.AutoRoundedCorners = true;
            this.txt_Name.BorderColor = System.Drawing.Color.Black;
            this.txt_Name.BorderRadius = 26;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(10, 60);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "Enter Text";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(493, 55);
            this.txt_Name.TabIndex = 131;
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notes.ForeColor = System.Drawing.Color.Black;
            this.lbl_Notes.Location = new System.Drawing.Point(511, 225);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(102, 40);
            this.lbl_Notes.TabIndex = 138;
            this.lbl_Notes.Text = "Notes";
            // 
            // dtm_AddDate
            // 
            this.dtm_AddDate.AutoRoundedCorners = true;
            this.dtm_AddDate.BorderRadius = 26;
            this.dtm_AddDate.Checked = true;
            this.dtm_AddDate.FillColor = System.Drawing.Color.White;
            this.dtm_AddDate.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.dtm_AddDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_AddDate.Location = new System.Drawing.Point(10, 268);
            this.dtm_AddDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtm_AddDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtm_AddDate.Name = "dtm_AddDate";
            this.dtm_AddDate.Size = new System.Drawing.Size(493, 55);
            this.dtm_AddDate.TabIndex = 136;
            this.dtm_AddDate.Value = new System.DateTime(2022, 2, 22, 22, 31, 13, 10);
            // 
            // cbo_Category
            // 
            this.cbo_Category.AutoRoundedCorners = true;
            this.cbo_Category.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Category.BorderColor = System.Drawing.Color.Black;
            this.cbo_Category.BorderRadius = 17;
            this.cbo_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Category.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.cbo_Category.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbo_Category.ItemHeight = 30;
            this.cbo_Category.Location = new System.Drawing.Point(10, 369);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(493, 36);
            this.cbo_Category.TabIndex = 135;
            // 
            // lbl_Catelory
            // 
            this.lbl_Catelory.AutoSize = true;
            this.lbl_Catelory.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Catelory.ForeColor = System.Drawing.Color.Black;
            this.lbl_Catelory.Location = new System.Drawing.Point(3, 326);
            this.lbl_Catelory.Name = "lbl_Catelory";
            this.lbl_Catelory.Size = new System.Drawing.Size(157, 40);
            this.lbl_Catelory.TabIndex = 130;
            this.lbl_Catelory.Text = "Category";
            // 
            // lbl_AddedOn
            // 
            this.lbl_AddedOn.AutoSize = true;
            this.lbl_AddedOn.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddedOn.ForeColor = System.Drawing.Color.Black;
            this.lbl_AddedOn.Location = new System.Drawing.Point(3, 225);
            this.lbl_AddedOn.Name = "lbl_AddedOn";
            this.lbl_AddedOn.Size = new System.Drawing.Size(170, 40);
            this.lbl_AddedOn.TabIndex = 129;
            this.lbl_AddedOn.Text = "Added On";
            // 
            // lbl_SellPrice
            // 
            this.lbl_SellPrice.AutoSize = true;
            this.lbl_SellPrice.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SellPrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_SellPrice.Location = new System.Drawing.Point(511, 120);
            this.lbl_SellPrice.Name = "lbl_SellPrice";
            this.lbl_SellPrice.Size = new System.Drawing.Size(158, 40);
            this.lbl_SellPrice.TabIndex = 128;
            this.lbl_SellPrice.Text = "Sell Price";
            // 
            // lbl_BuyPrice
            // 
            this.lbl_BuyPrice.AutoSize = true;
            this.lbl_BuyPrice.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuyPrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_BuyPrice.Location = new System.Drawing.Point(3, 120);
            this.lbl_BuyPrice.Name = "lbl_BuyPrice";
            this.lbl_BuyPrice.Size = new System.Drawing.Size(165, 40);
            this.lbl_BuyPrice.TabIndex = 127;
            this.lbl_BuyPrice.Text = "Buy Price";
            // 
            // lbl_Quantily
            // 
            this.lbl_Quantily.AutoSize = true;
            this.lbl_Quantily.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantily.ForeColor = System.Drawing.Color.Black;
            this.lbl_Quantily.Location = new System.Drawing.Point(511, 15);
            this.lbl_Quantily.Name = "lbl_Quantily";
            this.lbl_Quantily.Size = new System.Drawing.Size(148, 40);
            this.lbl_Quantily.TabIndex = 126;
            this.lbl_Quantily.Text = "Quantily";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Location = new System.Drawing.Point(3, 15);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(103, 40);
            this.lbl_Name.TabIndex = 125;
            this.lbl_Name.Text = "Name";
            // 
            // pnl_Data
            // 
            this.pnl_Data.Controls.Add(this.btn_Search);
            this.pnl_Data.Controls.Add(this.txt_Search);
            this.pnl_Data.Controls.Add(this.dgv_Item);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Data.Location = new System.Drawing.Point(0, 438);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(1023, 515);
            this.pnl_Data.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.BorderRadius = 26;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Search.Location = new System.Drawing.Point(957, 8);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(54, 55);
            this.btn_Search.TabIndex = 130;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.AutoRoundedCorners = true;
            this.txt_Search.BorderColor = System.Drawing.Color.Black;
            this.txt_Search.BorderRadius = 26;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(511, 8);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Enter Text";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(438, 55);
            this.txt_Search.TabIndex = 129;
            // 
            // dgv_Item
            // 
            this.dgv_Item.AllowUserToAddRows = false;
            this.dgv_Item.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Item.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Item.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Item.ColumnHeadersHeight = 50;
            this.dgv_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.CategoryName,
            this.ItemQuantily,
            this.ItemBuyPrice,
            this.ItemSellPrice,
            this.ItemProfit,
            this.ItemDetails,
            this.ItemAddDate,
            this.CategoryId,
            this.ItemCategory});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Item.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Item.EnableHeadersVisualStyles = false;
            this.dgv_Item.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Item.Location = new System.Drawing.Point(10, 71);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.ReadOnly = true;
            this.dgv_Item.RowHeadersVisible = false;
            this.dgv_Item.RowHeadersWidth = 45;
            this.dgv_Item.RowTemplate.Height = 45;
            this.dgv_Item.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Item.Size = new System.Drawing.Size(1001, 441);
            this.dgv_Item.TabIndex = 128;
            this.dgv_Item.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Item.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Item.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Item.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Item.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Item.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Item.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Item.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Item.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Item.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Item.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Item.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Item.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_Item.ThemeStyle.ReadOnly = true;
            this.dgv_Item.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Item.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Item.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Item.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Item.ThemeStyle.RowsStyle.Height = 45;
            this.dgv_Item.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Item.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Item_CellContentClick);
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "ID";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Width = 80;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 127;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 181;
            // 
            // ItemQuantily
            // 
            this.ItemQuantily.DataPropertyName = "ItemQuantily";
            this.ItemQuantily.HeaderText = "Quantily";
            this.ItemQuantily.Name = "ItemQuantily";
            this.ItemQuantily.ReadOnly = true;
            this.ItemQuantily.Width = 172;
            // 
            // ItemBuyPrice
            // 
            this.ItemBuyPrice.DataPropertyName = "ItemBuyPrice";
            this.ItemBuyPrice.HeaderText = "Buy Price";
            this.ItemBuyPrice.Name = "ItemBuyPrice";
            this.ItemBuyPrice.ReadOnly = true;
            this.ItemBuyPrice.Width = 189;
            // 
            // ItemSellPrice
            // 
            this.ItemSellPrice.DataPropertyName = "ItemSellPrice";
            this.ItemSellPrice.HeaderText = "Sell Price";
            this.ItemSellPrice.Name = "ItemSellPrice";
            this.ItemSellPrice.ReadOnly = true;
            this.ItemSellPrice.Width = 182;
            // 
            // ItemProfit
            // 
            this.ItemProfit.DataPropertyName = "ItemProfit";
            this.ItemProfit.HeaderText = "Profit";
            this.ItemProfit.Name = "ItemProfit";
            this.ItemProfit.ReadOnly = true;
            this.ItemProfit.Width = 129;
            // 
            // ItemDetails
            // 
            this.ItemDetails.DataPropertyName = "ItemDetails";
            this.ItemDetails.HeaderText = "Details";
            this.ItemDetails.Name = "ItemDetails";
            this.ItemDetails.ReadOnly = true;
            this.ItemDetails.Width = 144;
            // 
            // ItemAddDate
            // 
            this.ItemAddDate.DataPropertyName = "ItemAddDate";
            this.ItemAddDate.HeaderText = "Add Date";
            this.ItemAddDate.Name = "ItemAddDate";
            this.ItemAddDate.ReadOnly = true;
            this.ItemAddDate.Width = 184;
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "Category ID";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Visible = false;
            this.CategoryId.Width = 229;
            // 
            // ItemCategory
            // 
            this.ItemCategory.DataPropertyName = "ItemCategory";
            this.ItemCategory.HeaderText = "Item Cat  ID";
            this.ItemCategory.Name = "ItemCategory";
            this.ItemCategory.ReadOnly = true;
            this.ItemCategory.Visible = false;
            this.ItemCategory.Width = 231;
            // 
            // ele_UC_Item
            // 
            this.ele_UC_Item.BorderRadius = 26;
            this.ele_UC_Item.TargetControl = this;
            // 
            // UC_Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.pnl_Item);
            this.Controls.Add(this.pnl_ButtonList);
            this.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(1023, 1024);
            this.pnl_ButtonList.ResumeLayout(false);
            this.pnl_ButtonList.PerformLayout();
            this.pnl_Item.ResumeLayout(false);
            this.pnl_Item.PerformLayout();
            this.pnl_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_ButtonList;
        private Guna.UI2.WinForms.Guna2Panel pnl_Item;
        private Guna.UI2.WinForms.Guna2Panel pnl_Data;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private System.Windows.Forms.Label lbl_Notes;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Category;
        private System.Windows.Forms.Label lbl_Catelory;
        private System.Windows.Forms.Label lbl_AddedOn;
        private System.Windows.Forms.Label lbl_SellPrice;
        private System.Windows.Forms.Label lbl_BuyPrice;
        private System.Windows.Forms.Label lbl_Quantily;
        private System.Windows.Forms.Label lbl_Name;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Item;
        private Guna.UI2.WinForms.Guna2Elipse ele_UC_Item;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtm_AddDate;
        private Guna.UI2.WinForms.Guna2TextBox txt_SellPrice;
        private Guna.UI2.WinForms.Guna2TextBox txt_BuyPrice;
        private Guna.UI2.WinForms.Guna2TextBox txt_Quantily;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private System.Windows.Forms.RichTextBox rtb_Notes;
        private Guna.UI2.WinForms.Guna2Button btn_Renew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantily;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAddDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategory;
    }
}
