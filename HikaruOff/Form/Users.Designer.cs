
namespace HikaruOff
{
    partial class frm_ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManageUsers));
            this.lbl_DataList = new System.Windows.Forms.Label();
            this.dgv_DataList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbo_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_BirthDay = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ManageUsers = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.pnl_ManageUsers = new System.Windows.Forms.Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.pic_Hide = new System.Windows.Forms.PictureBox();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.pic_Account = new System.Windows.Forms.PictureBox();
            this.cbo_Office = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Office = new System.Windows.Forms.Label();
            this.pic_LogoShop = new System.Windows.Forms.PictureBox();
            this.pic_Setting = new System.Windows.Forms.PictureBox();
            this.lbl_Setting = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.pic_Customer = new System.Windows.Forms.PictureBox();
            this.pic_Items = new System.Windows.Forms.PictureBox();
            this.pic_Dashboard = new System.Windows.Forms.PictureBox();
            this.pic_Staff = new System.Windows.Forms.PictureBox();
            this.lbl_Billing = new System.Windows.Forms.Label();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.pic_Billing = new System.Windows.Forms.PictureBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.pic_Category = new System.Windows.Forms.PictureBox();
            this.lbl_Staff = new System.Windows.Forms.Label();
            this.lbl_Items = new System.Windows.Forms.Label();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataList)).BeginInit();
            this.pnl_ManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Billing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DataList
            // 
            this.lbl_DataList.AutoSize = true;
            this.lbl_DataList.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_DataList.Location = new System.Drawing.Point(536, 226);
            this.lbl_DataList.Name = "lbl_DataList";
            this.lbl_DataList.Size = new System.Drawing.Size(166, 40);
            this.lbl_DataList.TabIndex = 33;
            this.lbl_DataList.Text = "Data List ";
            // 
            // dgv_DataList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_DataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DataList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DataList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DataList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DataList.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DataList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DataList.EnableHeadersVisualStyles = false;
            this.dgv_DataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DataList.Location = new System.Drawing.Point(540, 338);
            this.dgv_DataList.Name = "dgv_DataList";
            this.dgv_DataList.RowHeadersVisible = false;
            this.dgv_DataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DataList.Size = new System.Drawing.Size(471, 579);
            this.dgv_DataList.TabIndex = 31;
            this.dgv_DataList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DataList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DataList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DataList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DataList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DataList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DataList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DataList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DataList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DataList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DataList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DataList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DataList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_DataList.ThemeStyle.ReadOnly = false;
            this.dgv_DataList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DataList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DataList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DataList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DataList.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_DataList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DataList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbo_Gender
            // 
            this.cbo_Gender.AutoRoundedCorners = true;
            this.cbo_Gender.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Gender.BorderRadius = 17;
            this.cbo_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Gender.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.cbo_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Gender.ItemHeight = 30;
            this.cbo_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbo_Gender.Location = new System.Drawing.Point(22, 581);
            this.cbo_Gender.Name = "cbo_Gender";
            this.cbo_Gender.Size = new System.Drawing.Size(246, 36);
            this.cbo_Gender.TabIndex = 30;
            // 
            // txt_Password
            // 
            this.txt_Password.AutoRoundedCorners = true;
            this.txt_Password.BorderColor = System.Drawing.Color.Black;
            this.txt_Password.BorderRadius = 23;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Location = new System.Drawing.Point(22, 482);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.PlaceholderText = "*************";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(246, 48);
            this.txt_Password.TabIndex = 29;
            // 
            // txt_Phone
            // 
            this.txt_Phone.AutoRoundedCorners = true;
            this.txt_Phone.BorderColor = System.Drawing.Color.Black;
            this.txt_Phone.BorderRadius = 23;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Location = new System.Drawing.Point(286, 482);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderText = "0123456789";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.Size = new System.Drawing.Size(242, 48);
            this.txt_Phone.TabIndex = 28;
            // 
            // txt_Email
            // 
            this.txt_Email.AutoRoundedCorners = true;
            this.txt_Email.BorderColor = System.Drawing.Color.Black;
            this.txt_Email.BorderRadius = 23;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Location = new System.Drawing.Point(22, 378);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderText = "Hikaru@gmail.com";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(506, 48);
            this.txt_Email.TabIndex = 27;
            // 
            // txt_Name
            // 
            this.txt_Name.AutoRoundedCorners = true;
            this.txt_Name.BorderColor = System.Drawing.Color.Black;
            this.txt_Name.BorderRadius = 23;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(22, 274);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "Admin";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(506, 48);
            this.txt_Name.TabIndex = 26;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Gender.Location = new System.Drawing.Point(15, 538);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(130, 40);
            this.lbl_Gender.TabIndex = 20;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_BirthDay
            // 
            this.lbl_BirthDay.AutoSize = true;
            this.lbl_BirthDay.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BirthDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_BirthDay.Location = new System.Drawing.Point(15, 620);
            this.lbl_BirthDay.Name = "lbl_BirthDay";
            this.lbl_BirthDay.Size = new System.Drawing.Size(166, 40);
            this.lbl_BirthDay.TabIndex = 18;
            this.lbl_BirthDay.Text = "Birth Day";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Password.Location = new System.Drawing.Point(15, 434);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(162, 40);
            this.lbl_Password.TabIndex = 16;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Phone.Location = new System.Drawing.Point(279, 434);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(111, 40);
            this.lbl_Phone.TabIndex = 14;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Name.Location = new System.Drawing.Point(15, 226);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(103, 40);
            this.lbl_Name.TabIndex = 10;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_ManageUsers
            // 
            this.lbl_ManageUsers.AutoSize = true;
            this.lbl_ManageUsers.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageUsers.ForeColor = System.Drawing.Color.Lime;
            this.lbl_ManageUsers.Location = new System.Drawing.Point(3, 111);
            this.lbl_ManageUsers.Name = "lbl_ManageUsers";
            this.lbl_ManageUsers.Size = new System.Drawing.Size(631, 109);
            this.lbl_ManageUsers.TabIndex = 8;
            this.lbl_ManageUsers.Text = "Manage Users";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Email.Location = new System.Drawing.Point(15, 330);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(103, 40);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "Email";
            // 
            // pnl_ManageUsers
            // 
            this.pnl_ManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnl_ManageUsers.Controls.Add(this.guna2Button1);
            this.pnl_ManageUsers.Controls.Add(this.guna2TextBox1);
            this.pnl_ManageUsers.Controls.Add(this.guna2DateTimePicker1);
            this.pnl_ManageUsers.Controls.Add(this.btn_Delete);
            this.pnl_ManageUsers.Controls.Add(this.btn_Edit);
            this.pnl_ManageUsers.Controls.Add(this.btn_Save);
            this.pnl_ManageUsers.Controls.Add(this.pic_Hide);
            this.pnl_ManageUsers.Controls.Add(this.lbl_Account);
            this.pnl_ManageUsers.Controls.Add(this.pic_Account);
            this.pnl_ManageUsers.Controls.Add(this.cbo_Office);
            this.pnl_ManageUsers.Controls.Add(this.lbl_Office);
            this.pnl_ManageUsers.Controls.Add(this.lbl_DataList);
            this.pnl_ManageUsers.Controls.Add(this.dgv_DataList);
            this.pnl_ManageUsers.Controls.Add(this.cbo_Gender);
            this.pnl_ManageUsers.Controls.Add(this.txt_Password);
            this.pnl_ManageUsers.Controls.Add(this.txt_Phone);
            this.pnl_ManageUsers.Controls.Add(this.txt_Email);
            this.pnl_ManageUsers.Controls.Add(this.txt_Name);
            this.pnl_ManageUsers.Controls.Add(this.lbl_Gender);
            this.pnl_ManageUsers.Controls.Add(this.lbl_BirthDay);
            this.pnl_ManageUsers.Controls.Add(this.lbl_Password);
            this.pnl_ManageUsers.Controls.Add(this.lbl_Phone);
            this.pnl_ManageUsers.Controls.Add(this.lbl_Email);
            this.pnl_ManageUsers.Controls.Add(this.lbl_Name);
            this.pnl_ManageUsers.Controls.Add(this.lbl_ManageUsers);
            this.pnl_ManageUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_ManageUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_ManageUsers.Location = new System.Drawing.Point(257, 0);
            this.pnl_ManageUsers.Name = "pnl_ManageUsers";
            this.pnl_ManageUsers.Size = new System.Drawing.Size(1023, 1024);
            this.pnl_ManageUsers.TabIndex = 23;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.BorderRadius = 23;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(22, 663);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(250, 48);
            this.guna2DateTimePicker1.TabIndex = 95;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 2, 22, 22, 38, 15, 505);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoRoundedCorners = true;
            this.btn_Delete.BorderRadius = 25;
            this.btn_Delete.DefaultAutoSize = true;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(878, 959);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(133, 53);
            this.btn_Delete.TabIndex = 94;
            this.btn_Delete.Text = "Delete";
            // 
            // btn_Edit
            // 
            this.btn_Edit.AutoRoundedCorners = true;
            this.btn_Edit.BorderRadius = 25;
            this.btn_Edit.DefaultAutoSize = true;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Edit.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(769, 959);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(103, 53);
            this.btn_Edit.TabIndex = 93;
            this.btn_Edit.Text = "Edit";
            // 
            // btn_Save
            // 
            this.btn_Save.AutoRoundedCorners = true;
            this.btn_Save.BorderRadius = 25;
            this.btn_Save.DefaultAutoSize = true;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(654, 959);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 53);
            this.btn_Save.TabIndex = 92;
            this.btn_Save.Text = "Save";
            // 
            // pic_Hide
            // 
            this.pic_Hide.Image = ((System.Drawing.Image)(resources.GetObject("pic_Hide.Image")));
            this.pic_Hide.Location = new System.Drawing.Point(947, 12);
            this.pic_Hide.Name = "pic_Hide";
            this.pic_Hide.Size = new System.Drawing.Size(50, 50);
            this.pic_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hide.TabIndex = 91;
            this.pic_Hide.TabStop = false;
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(653, 22);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Account.Size = new System.Drawing.Size(232, 40);
            this.lbl_Account.TabIndex = 81;
            this.lbl_Account.Text = "Võ Minh Khôi";
            this.lbl_Account.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pic_Account
            // 
            this.pic_Account.Image = ((System.Drawing.Image)(resources.GetObject("pic_Account.Image")));
            this.pic_Account.Location = new System.Drawing.Point(891, 12);
            this.pic_Account.Name = "pic_Account";
            this.pic_Account.Size = new System.Drawing.Size(50, 50);
            this.pic_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Account.TabIndex = 79;
            this.pic_Account.TabStop = false;
            // 
            // cbo_Office
            // 
            this.cbo_Office.AutoRoundedCorners = true;
            this.cbo_Office.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Office.BorderRadius = 17;
            this.cbo_Office.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Office.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Office.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Office.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Office.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.cbo_Office.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Office.ItemHeight = 30;
            this.cbo_Office.Items.AddRange(new object[] {
            "Master",
            "Admin",
            "Staff",
            "Intern"});
            this.cbo_Office.Location = new System.Drawing.Point(286, 581);
            this.cbo_Office.Name = "cbo_Office";
            this.cbo_Office.Size = new System.Drawing.Size(242, 36);
            this.cbo_Office.TabIndex = 35;
            // 
            // lbl_Office
            // 
            this.lbl_Office.AutoSize = true;
            this.lbl_Office.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Office.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Office.Location = new System.Drawing.Point(279, 538);
            this.lbl_Office.Name = "lbl_Office";
            this.lbl_Office.Size = new System.Drawing.Size(107, 40);
            this.lbl_Office.TabIndex = 34;
            this.lbl_Office.Text = "Office";
            // 
            // pic_LogoShop
            // 
            this.pic_LogoShop.Image = ((System.Drawing.Image)(resources.GetObject("pic_LogoShop.Image")));
            this.pic_LogoShop.Location = new System.Drawing.Point(12, 12);
            this.pic_LogoShop.Name = "pic_LogoShop";
            this.pic_LogoShop.Size = new System.Drawing.Size(239, 208);
            this.pic_LogoShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_LogoShop.TabIndex = 76;
            this.pic_LogoShop.TabStop = false;
            // 
            // pic_Setting
            // 
            this.pic_Setting.Image = ((System.Drawing.Image)(resources.GetObject("pic_Setting.Image")));
            this.pic_Setting.Location = new System.Drawing.Point(12, 562);
            this.pic_Setting.Name = "pic_Setting";
            this.pic_Setting.Size = new System.Drawing.Size(50, 50);
            this.pic_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Setting.TabIndex = 109;
            this.pic_Setting.TabStop = false;
            this.pic_Setting.Click += new System.EventHandler(this.pic_Setting_Click);
            // 
            // lbl_Setting
            // 
            this.lbl_Setting.AutoSize = true;
            this.lbl_Setting.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Setting.Location = new System.Drawing.Point(68, 572);
            this.lbl_Setting.Name = "lbl_Setting";
            this.lbl_Setting.Size = new System.Drawing.Size(122, 40);
            this.lbl_Setting.TabIndex = 110;
            this.lbl_Setting.Text = "Setting";
            this.lbl_Setting.Click += new System.EventHandler(this.lbl_Setting_Click);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Exit.Location = new System.Drawing.Point(68, 972);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(79, 40);
            this.lbl_Exit.TabIndex = 108;
            this.lbl_Exit.Text = "Exit";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // pic_Customer
            // 
            this.pic_Customer.Image = ((System.Drawing.Image)(resources.GetObject("pic_Customer.Image")));
            this.pic_Customer.Location = new System.Drawing.Point(12, 450);
            this.pic_Customer.Name = "pic_Customer";
            this.pic_Customer.Size = new System.Drawing.Size(50, 50);
            this.pic_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Customer.TabIndex = 99;
            this.pic_Customer.TabStop = false;
            this.pic_Customer.Click += new System.EventHandler(this.pic_Customer_Click);
            // 
            // pic_Items
            // 
            this.pic_Items.Image = ((System.Drawing.Image)(resources.GetObject("pic_Items.Image")));
            this.pic_Items.Location = new System.Drawing.Point(12, 338);
            this.pic_Items.Name = "pic_Items";
            this.pic_Items.Size = new System.Drawing.Size(50, 50);
            this.pic_Items.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Items.TabIndex = 97;
            this.pic_Items.TabStop = false;
            this.pic_Items.Click += new System.EventHandler(this.pic_Items_Click);
            // 
            // pic_Dashboard
            // 
            this.pic_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("pic_Dashboard.Image")));
            this.pic_Dashboard.Location = new System.Drawing.Point(12, 506);
            this.pic_Dashboard.Name = "pic_Dashboard";
            this.pic_Dashboard.Size = new System.Drawing.Size(50, 50);
            this.pic_Dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Dashboard.TabIndex = 100;
            this.pic_Dashboard.TabStop = false;
            this.pic_Dashboard.Click += new System.EventHandler(this.pic_Dashboard_Click);
            // 
            // pic_Staff
            // 
            this.pic_Staff.Image = ((System.Drawing.Image)(resources.GetObject("pic_Staff.Image")));
            this.pic_Staff.Location = new System.Drawing.Point(12, 394);
            this.pic_Staff.Name = "pic_Staff";
            this.pic_Staff.Size = new System.Drawing.Size(50, 50);
            this.pic_Staff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Staff.TabIndex = 98;
            this.pic_Staff.TabStop = false;
            this.pic_Staff.Click += new System.EventHandler(this.pic_Staff_Click);
            // 
            // lbl_Billing
            // 
            this.lbl_Billing.AutoSize = true;
            this.lbl_Billing.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Billing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Billing.Location = new System.Drawing.Point(68, 236);
            this.lbl_Billing.Name = "lbl_Billing";
            this.lbl_Billing.Size = new System.Drawing.Size(114, 40);
            this.lbl_Billing.TabIndex = 103;
            this.lbl_Billing.Text = "Billing";
            this.lbl_Billing.Click += new System.EventHandler(this.lbl_Billing_Click);
            // 
            // pic_Exit
            // 
            this.pic_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_Exit.Image")));
            this.pic_Exit.Location = new System.Drawing.Point(12, 962);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(50, 50);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 101;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Customer.Location = new System.Drawing.Point(68, 460);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(164, 40);
            this.lbl_Customer.TabIndex = 102;
            this.lbl_Customer.Text = "Customer";
            this.lbl_Customer.Click += new System.EventHandler(this.lbl_Customer_Click);
            // 
            // pic_Billing
            // 
            this.pic_Billing.Image = ((System.Drawing.Image)(resources.GetObject("pic_Billing.Image")));
            this.pic_Billing.Location = new System.Drawing.Point(12, 226);
            this.pic_Billing.Name = "pic_Billing";
            this.pic_Billing.Size = new System.Drawing.Size(50, 50);
            this.pic_Billing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Billing.TabIndex = 95;
            this.pic_Billing.TabStop = false;
            this.pic_Billing.Click += new System.EventHandler(this.pic_Billing_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Category.Location = new System.Drawing.Point(68, 292);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(157, 40);
            this.lbl_Category.TabIndex = 105;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.Click += new System.EventHandler(this.lbl_Category_Click);
            // 
            // pic_Category
            // 
            this.pic_Category.Image = ((System.Drawing.Image)(resources.GetObject("pic_Category.Image")));
            this.pic_Category.Location = new System.Drawing.Point(12, 282);
            this.pic_Category.Name = "pic_Category";
            this.pic_Category.Size = new System.Drawing.Size(50, 50);
            this.pic_Category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Category.TabIndex = 96;
            this.pic_Category.TabStop = false;
            this.pic_Category.Click += new System.EventHandler(this.pic_Category_Click);
            // 
            // lbl_Staff
            // 
            this.lbl_Staff.AutoSize = true;
            this.lbl_Staff.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Staff.Location = new System.Drawing.Point(68, 404);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(88, 40);
            this.lbl_Staff.TabIndex = 107;
            this.lbl_Staff.Text = "Staff";
            this.lbl_Staff.Click += new System.EventHandler(this.lbl_Staff_Click);
            // 
            // lbl_Items
            // 
            this.lbl_Items.AutoSize = true;
            this.lbl_Items.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Items.Location = new System.Drawing.Point(68, 348);
            this.lbl_Items.Name = "lbl_Items";
            this.lbl_Items.Size = new System.Drawing.Size(100, 40);
            this.lbl_Items.TabIndex = 106;
            this.lbl_Items.Text = "Items";
            this.lbl_Items.Click += new System.EventHandler(this.lbl_Items_Click);
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Dashboard.Location = new System.Drawing.Point(68, 516);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(183, 40);
            this.lbl_Dashboard.TabIndex = 104;
            this.lbl_Dashboard.Text = "Dashboard";
            this.lbl_Dashboard.Click += new System.EventHandler(this.lbl_Dashboard_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.DefaultAutoSize = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(899, 274);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(109, 53);
            this.guna2Button1.TabIndex = 99;
            this.guna2Button1.Text = "Find";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 25;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(540, 274);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Enter Name / Email";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(347, 53);
            this.guna2TextBox1.TabIndex = 98;
            // 
            // frm_ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.pic_Setting);
            this.Controls.Add(this.pnl_ManageUsers);
            this.Controls.Add(this.lbl_Setting);
            this.Controls.Add(this.pic_LogoShop);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.pic_Billing);
            this.Controls.Add(this.pic_Customer);
            this.Controls.Add(this.lbl_Dashboard);
            this.Controls.Add(this.pic_Items);
            this.Controls.Add(this.lbl_Items);
            this.Controls.Add(this.pic_Dashboard);
            this.Controls.Add(this.lbl_Staff);
            this.Controls.Add(this.pic_Staff);
            this.Controls.Add(this.pic_Category);
            this.Controls.Add(this.lbl_Billing);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.lbl_Customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataList)).EndInit();
            this.pnl_ManageUsers.ResumeLayout(false);
            this.pnl_ManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Billing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_DataList;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DataList;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Gender;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_BirthDay;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ManageUsers;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Panel pnl_ManageUsers;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Office;
        private System.Windows.Forms.Label lbl_Office;
        private System.Windows.Forms.PictureBox pic_LogoShop;
        private System.Windows.Forms.PictureBox pic_Account;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.PictureBox pic_Hide;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private System.Windows.Forms.PictureBox pic_Setting;
        private System.Windows.Forms.Label lbl_Setting;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.PictureBox pic_Customer;
        private System.Windows.Forms.PictureBox pic_Items;
        private System.Windows.Forms.PictureBox pic_Dashboard;
        private System.Windows.Forms.PictureBox pic_Staff;
        private System.Windows.Forms.Label lbl_Billing;
        private System.Windows.Forms.PictureBox pic_Exit;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.PictureBox pic_Billing;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.PictureBox pic_Category;
        private System.Windows.Forms.Label lbl_Staff;
        private System.Windows.Forms.Label lbl_Items;
        private System.Windows.Forms.Label lbl_Dashboard;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}