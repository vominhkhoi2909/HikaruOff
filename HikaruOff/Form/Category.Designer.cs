
namespace HikaruOff
{
    partial class frm_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Category));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.pic_LogoShop = new System.Windows.Forms.PictureBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.txt_NameCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_NameCategory = new System.Windows.Forms.Label();
            this.dgv_Category = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_ListCategory = new System.Windows.Forms.Label();
            this.pic_Hide = new System.Windows.Forms.PictureBox();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Times New Roman", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Category.Location = new System.Drawing.Point(98, 9);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(308, 78);
            this.lbl_Category.TabIndex = 10;
            this.lbl_Category.Text = "Category";
            // 
            // pic_LogoShop
            // 
            this.pic_LogoShop.Image = ((System.Drawing.Image)(resources.GetObject("pic_LogoShop.Image")));
            this.pic_LogoShop.Location = new System.Drawing.Point(12, 12);
            this.pic_LogoShop.Name = "pic_LogoShop";
            this.pic_LogoShop.Size = new System.Drawing.Size(80, 80);
            this.pic_LogoShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_LogoShop.TabIndex = 9;
            this.pic_LogoShop.TabStop = false;
            // 
            // pic_Exit
            // 
            this.pic_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_Exit.Image")));
            this.pic_Exit.Location = new System.Drawing.Point(738, 12);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(50, 50);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 33;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // txt_NameCategory
            // 
            this.txt_NameCategory.AutoRoundedCorners = true;
            this.txt_NameCategory.BorderColor = System.Drawing.Color.Black;
            this.txt_NameCategory.BorderRadius = 29;
            this.txt_NameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameCategory.DefaultText = "";
            this.txt_NameCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NameCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NameCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameCategory.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_NameCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameCategory.Location = new System.Drawing.Point(14, 140);
            this.txt_NameCategory.Margin = new System.Windows.Forms.Padding(5);
            this.txt_NameCategory.Name = "txt_NameCategory";
            this.txt_NameCategory.PasswordChar = '\0';
            this.txt_NameCategory.PlaceholderText = "Enter Text";
            this.txt_NameCategory.SelectedText = "";
            this.txt_NameCategory.Size = new System.Drawing.Size(772, 60);
            this.txt_NameCategory.TabIndex = 35;
            // 
            // lbl_NameCategory
            // 
            this.lbl_NameCategory.AutoSize = true;
            this.lbl_NameCategory.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_NameCategory.Location = new System.Drawing.Point(12, 95);
            this.lbl_NameCategory.Name = "lbl_NameCategory";
            this.lbl_NameCategory.Size = new System.Drawing.Size(252, 40);
            this.lbl_NameCategory.TabIndex = 34;
            this.lbl_NameCategory.Text = "Name Category";
            // 
            // dgv_Category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Category.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Category.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Category.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Category.EnableHeadersVisualStyles = false;
            this.dgv_Category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Category.Location = new System.Drawing.Point(12, 248);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.RowHeadersVisible = false;
            this.dgv_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Category.Size = new System.Drawing.Size(776, 271);
            this.dgv_Category.TabIndex = 36;
            this.dgv_Category.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Category.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Category.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Category.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Category.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Category.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Category.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Category.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Category.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Category.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Category.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_Category.ThemeStyle.ReadOnly = false;
            this.dgv_Category.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Category.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Category.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Category.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Category.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Category.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Category.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbl_ListCategory
            // 
            this.lbl_ListCategory.AutoSize = true;
            this.lbl_ListCategory.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_ListCategory.Location = new System.Drawing.Point(12, 205);
            this.lbl_ListCategory.Name = "lbl_ListCategory";
            this.lbl_ListCategory.Size = new System.Drawing.Size(224, 40);
            this.lbl_ListCategory.TabIndex = 40;
            this.lbl_ListCategory.Text = "List Category";
            // 
            // pic_Hide
            // 
            this.pic_Hide.Image = ((System.Drawing.Image)(resources.GetObject("pic_Hide.Image")));
            this.pic_Hide.Location = new System.Drawing.Point(682, 12);
            this.pic_Hide.Name = "pic_Hide";
            this.pic_Hide.Size = new System.Drawing.Size(50, 50);
            this.pic_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hide.TabIndex = 86;
            this.pic_Hide.TabStop = false;
            this.pic_Hide.Click += new System.EventHandler(this.pic_Hide_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AutoRoundedCorners = true;
            this.btn_Add.BorderRadius = 25;
            this.btn_Add.DefaultAutoSize = true;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(437, 535);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(103, 53);
            this.btn_Add.TabIndex = 87;
            this.btn_Add.Text = "Add";
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
            this.btn_Edit.Location = new System.Drawing.Point(546, 535);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(103, 53);
            this.btn_Edit.TabIndex = 88;
            this.btn_Edit.Text = "Edit";
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
            this.btn_Delete.Location = new System.Drawing.Point(655, 535);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(133, 53);
            this.btn_Delete.TabIndex = 89;
            this.btn_Delete.Text = "Delete";
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.pic_Hide);
            this.Controls.Add(this.lbl_ListCategory);
            this.Controls.Add(this.dgv_Category);
            this.Controls.Add(this.txt_NameCategory);
            this.Controls.Add(this.lbl_NameCategory);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.pic_LogoShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.PictureBox pic_LogoShop;
        private System.Windows.Forms.PictureBox pic_Exit;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameCategory;
        private System.Windows.Forms.Label lbl_NameCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Category;
        private System.Windows.Forms.Label lbl_ListCategory;
        private System.Windows.Forms.PictureBox pic_Hide;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
    }
}