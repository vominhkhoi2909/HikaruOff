
namespace HikaruOff
{
    partial class UC_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_ButtonList = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Renew = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Data = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Customer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Customer = new Guna.UI2.WinForms.Guna2Panel();
            this.rtb_Notes = new System.Windows.Forms.RichTextBox();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.dtm_BirthDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbo_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_BirthDay = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.ele_UC_Customer = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_ButtonList.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.pnl_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ButtonList
            // 
            this.pnl_ButtonList.Controls.Add(this.btn_Add);
            this.pnl_ButtonList.Controls.Add(this.btn_Renew);
            this.pnl_ButtonList.Controls.Add(this.btn_Delete);
            this.pnl_ButtonList.Controls.Add(this.btn_Save);
            this.pnl_ButtonList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_ButtonList.Location = new System.Drawing.Point(0, 959);
            this.pnl_ButtonList.Name = "pnl_ButtonList";
            this.pnl_ButtonList.Size = new System.Drawing.Size(1023, 65);
            this.pnl_ButtonList.TabIndex = 1;
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
            this.btn_Add.TabIndex = 102;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            // pnl_Data
            // 
            this.pnl_Data.Controls.Add(this.btn_Search);
            this.pnl_Data.Controls.Add(this.txt_Search);
            this.pnl_Data.Controls.Add(this.dgv_Customer);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Data.Location = new System.Drawing.Point(0, 428);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(1023, 531);
            this.pnl_Data.TabIndex = 3;
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
            this.btn_Search.Location = new System.Drawing.Point(957, 5);
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
            this.txt_Search.Location = new System.Drawing.Point(518, 5);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Enter Text";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(431, 55);
            this.txt_Search.TabIndex = 129;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.AllowUserToAddRows = false;
            this.dgv_Customer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Customer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Customer.ColumnHeadersHeight = 50;
            this.dgv_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.CustomerEmail,
            this.CustomerBirthDay,
            this.CustomerGender,
            this.CustomerPhone,
            this.CustomerNotes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Customer.EnableHeadersVisualStyles = false;
            this.dgv_Customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customer.Location = new System.Drawing.Point(10, 68);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.ReadOnly = true;
            this.dgv_Customer.RowHeadersVisible = false;
            this.dgv_Customer.RowTemplate.Height = 45;
            this.dgv_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customer.Size = new System.Drawing.Size(1001, 457);
            this.dgv_Customer.TabIndex = 128;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Customer.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_Customer.ThemeStyle.ReadOnly = true;
            this.dgv_Customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Customer.ThemeStyle.RowsStyle.Height = 45;
            this.dgv_Customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellContentClick);
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "ID";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Width = 80;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 127;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.DataPropertyName = "CustomerEmail";
            this.CustomerEmail.HeaderText = "Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.ReadOnly = true;
            this.CustomerEmail.Width = 127;
            // 
            // CustomerBirthDay
            // 
            this.CustomerBirthDay.DataPropertyName = "CustomerBirthDay";
            this.CustomerBirthDay.HeaderText = "Birth Day";
            this.CustomerBirthDay.Name = "CustomerBirthDay";
            this.CustomerBirthDay.ReadOnly = true;
            this.CustomerBirthDay.Width = 190;
            // 
            // CustomerGender
            // 
            this.CustomerGender.DataPropertyName = "CustomerGender";
            this.CustomerGender.HeaderText = "Gender";
            this.CustomerGender.Name = "CustomerGender";
            this.CustomerGender.ReadOnly = true;
            this.CustomerGender.Width = 154;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.DataPropertyName = "CustomerPhone";
            this.CustomerPhone.HeaderText = "Phone";
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.ReadOnly = true;
            this.CustomerPhone.Width = 135;
            // 
            // CustomerNotes
            // 
            this.CustomerNotes.DataPropertyName = "CustomerNotes";
            this.CustomerNotes.HeaderText = "Notes";
            this.CustomerNotes.Name = "CustomerNotes";
            this.CustomerNotes.ReadOnly = true;
            this.CustomerNotes.Width = 126;
            // 
            // pnl_Customer
            // 
            this.pnl_Customer.Controls.Add(this.rtb_Notes);
            this.pnl_Customer.Controls.Add(this.txt_Phone);
            this.pnl_Customer.Controls.Add(this.txt_Email);
            this.pnl_Customer.Controls.Add(this.txt_Name);
            this.pnl_Customer.Controls.Add(this.lbl_Notes);
            this.pnl_Customer.Controls.Add(this.dtm_BirthDay);
            this.pnl_Customer.Controls.Add(this.cbo_Gender);
            this.pnl_Customer.Controls.Add(this.lbl_Gender);
            this.pnl_Customer.Controls.Add(this.lbl_BirthDay);
            this.pnl_Customer.Controls.Add(this.lbl_Phone);
            this.pnl_Customer.Controls.Add(this.lbl_Email);
            this.pnl_Customer.Controls.Add(this.lbl_Name);
            this.pnl_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Customer.Location = new System.Drawing.Point(0, 0);
            this.pnl_Customer.Name = "pnl_Customer";
            this.pnl_Customer.Size = new System.Drawing.Size(1023, 422);
            this.pnl_Customer.TabIndex = 4;
            // 
            // rtb_Notes
            // 
            this.rtb_Notes.Location = new System.Drawing.Point(518, 163);
            this.rtb_Notes.Name = "rtb_Notes";
            this.rtb_Notes.Size = new System.Drawing.Size(493, 242);
            this.rtb_Notes.TabIndex = 142;
            this.rtb_Notes.Text = "";
            // 
            // txt_Phone
            // 
            this.txt_Phone.AutoRoundedCorners = true;
            this.txt_Phone.BorderColor = System.Drawing.Color.Black;
            this.txt_Phone.BorderRadius = 26;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Location = new System.Drawing.Point(10, 165);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderText = "Enter Number";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.Size = new System.Drawing.Size(493, 55);
            this.txt_Phone.TabIndex = 141;
            // 
            // txt_Email
            // 
            this.txt_Email.AutoRoundedCorners = true;
            this.txt_Email.BorderColor = System.Drawing.Color.Black;
            this.txt_Email.BorderRadius = 26;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Location = new System.Drawing.Point(518, 60);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderText = "Enter Text";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(493, 55);
            this.txt_Email.TabIndex = 139;
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
            this.lbl_Notes.Location = new System.Drawing.Point(511, 120);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(102, 40);
            this.lbl_Notes.TabIndex = 138;
            this.lbl_Notes.Text = "Notes";
            // 
            // dtm_BirthDay
            // 
            this.dtm_BirthDay.AutoRoundedCorners = true;
            this.dtm_BirthDay.BorderRadius = 26;
            this.dtm_BirthDay.Checked = true;
            this.dtm_BirthDay.FillColor = System.Drawing.Color.White;
            this.dtm_BirthDay.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.dtm_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_BirthDay.Location = new System.Drawing.Point(10, 268);
            this.dtm_BirthDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtm_BirthDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtm_BirthDay.Name = "dtm_BirthDay";
            this.dtm_BirthDay.Size = new System.Drawing.Size(493, 55);
            this.dtm_BirthDay.TabIndex = 136;
            this.dtm_BirthDay.Value = new System.DateTime(2022, 2, 22, 22, 31, 13, 10);
            // 
            // cbo_Gender
            // 
            this.cbo_Gender.AutoRoundedCorners = true;
            this.cbo_Gender.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Gender.BorderColor = System.Drawing.Color.Black;
            this.cbo_Gender.BorderRadius = 17;
            this.cbo_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Gender.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.cbo_Gender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbo_Gender.ItemHeight = 30;
            this.cbo_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbo_Gender.Location = new System.Drawing.Point(10, 369);
            this.cbo_Gender.Name = "cbo_Gender";
            this.cbo_Gender.Size = new System.Drawing.Size(493, 36);
            this.cbo_Gender.TabIndex = 135;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_Gender.Location = new System.Drawing.Point(3, 326);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(130, 40);
            this.lbl_Gender.TabIndex = 130;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_BirthDay
            // 
            this.lbl_BirthDay.AutoSize = true;
            this.lbl_BirthDay.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BirthDay.ForeColor = System.Drawing.Color.Black;
            this.lbl_BirthDay.Location = new System.Drawing.Point(3, 225);
            this.lbl_BirthDay.Name = "lbl_BirthDay";
            this.lbl_BirthDay.Size = new System.Drawing.Size(157, 40);
            this.lbl_BirthDay.TabIndex = 129;
            this.lbl_BirthDay.Text = "BirthDay";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_Phone.Location = new System.Drawing.Point(3, 120);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(111, 40);
            this.lbl_Phone.TabIndex = 128;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email.Location = new System.Drawing.Point(511, 15);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(103, 40);
            this.lbl_Email.TabIndex = 126;
            this.lbl_Email.Text = "Email";
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
            // ele_UC_Customer
            // 
            this.ele_UC_Customer.BorderRadius = 26;
            this.ele_UC_Customer.TargetControl = this;
            // 
            // UC_Customer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.pnl_Customer);
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.pnl_ButtonList);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1023, 1024);
            this.pnl_ButtonList.ResumeLayout(false);
            this.pnl_ButtonList.PerformLayout();
            this.pnl_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.pnl_Customer.ResumeLayout(false);
            this.pnl_Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_ButtonList;
        private Guna.UI2.WinForms.Guna2Button btn_Renew;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2Panel pnl_Data;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Customer;
        private Guna.UI2.WinForms.Guna2Panel pnl_Customer;
        private System.Windows.Forms.RichTextBox rtb_Notes;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Notes;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtm_BirthDay;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Gender;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_BirthDay;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Name;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Elipse ele_UC_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNotes;
    }
}
