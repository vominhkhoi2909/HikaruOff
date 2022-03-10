
namespace HikaruOff
{
    partial class UC_Sale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Sale));
            this.ele_UC_Sale = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgv_Sale = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_SaleList = new System.Windows.Forms.Label();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Renew = new Guna.UI2.WinForms.Guna2Button();
            this.SaleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sale)).BeginInit();
            this.SuspendLayout();
            // 
            // ele_UC_Sale
            // 
            this.ele_UC_Sale.BorderRadius = 26;
            this.ele_UC_Sale.TargetControl = this;
            // 
            // dgv_Sale
            // 
            this.dgv_Sale.AllowUserToAddRows = false;
            this.dgv_Sale.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgv_Sale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Sale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Sale.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Sale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Sale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Sale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Sale.ColumnHeadersHeight = 50;
            this.dgv_Sale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleNum,
            this.SaleDate,
            this.CustomerName,
            this.UserName,
            this.SaleAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Sale.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Sale.EnableHeadersVisualStyles = false;
            this.dgv_Sale.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgv_Sale.Location = new System.Drawing.Point(10, 68);
            this.dgv_Sale.Name = "dgv_Sale";
            this.dgv_Sale.ReadOnly = true;
            this.dgv_Sale.RowHeadersVisible = false;
            this.dgv_Sale.RowTemplate.Height = 45;
            this.dgv_Sale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sale.Size = new System.Drawing.Size(1001, 894);
            this.dgv_Sale.TabIndex = 0;
            this.dgv_Sale.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dgv_Sale.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgv_Sale.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Sale.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Sale.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Sale.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Sale.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Sale.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgv_Sale.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgv_Sale.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Sale.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.dgv_Sale.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Sale.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Sale.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_Sale.ThemeStyle.ReadOnly = true;
            this.dgv_Sale.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgv_Sale.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Sale.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.dgv_Sale.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Sale.ThemeStyle.RowsStyle.Height = 45;
            this.dgv_Sale.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgv_Sale.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lbl_SaleList
            // 
            this.lbl_SaleList.AutoSize = true;
            this.lbl_SaleList.Location = new System.Drawing.Point(3, 20);
            this.lbl_SaleList.Name = "lbl_SaleList";
            this.lbl_SaleList.Size = new System.Drawing.Size(146, 40);
            this.lbl_SaleList.TabIndex = 1;
            this.lbl_SaleList.Text = "Sale List";
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
            this.btn_Search.TabIndex = 132;
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
            this.txt_Search.Location = new System.Drawing.Point(511, 5);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Search.MaxLength = 50;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Enter Text";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(438, 55);
            this.txt_Search.TabIndex = 131;
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
            this.btn_Renew.Location = new System.Drawing.Point(870, 968);
            this.btn_Renew.Name = "btn_Renew";
            this.btn_Renew.Size = new System.Drawing.Size(141, 53);
            this.btn_Renew.TabIndex = 133;
            this.btn_Renew.Text = "Renew";
            this.btn_Renew.Click += new System.EventHandler(this.btn_Renew_Click);
            // 
            // SaleNum
            // 
            this.SaleNum.DataPropertyName = "SaleNum";
            this.SaleNum.HeaderText = "Num";
            this.SaleNum.Name = "SaleNum";
            this.SaleNum.ReadOnly = true;
            this.SaleNum.Width = 112;
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "Date";
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            this.SaleDate.Width = 112;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 188;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 112;
            // 
            // SaleAmount
            // 
            this.SaleAmount.DataPropertyName = "SaleAmount";
            this.SaleAmount.HeaderText = "Amount";
            this.SaleAmount.Name = "SaleAmount";
            this.SaleAmount.ReadOnly = true;
            this.SaleAmount.Width = 161;
            // 
            // UC_Sale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.btn_Renew);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_SaleList);
            this.Controls.Add(this.dgv_Sale);
            this.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "UC_Sale";
            this.Size = new System.Drawing.Size(1023, 1024);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ele_UC_Sale;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Sale;
        private System.Windows.Forms.Label lbl_SaleList;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button btn_Renew;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleAmount;
    }
}
