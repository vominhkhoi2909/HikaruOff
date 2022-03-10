
namespace HikaruOff
{
    partial class Frm_LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoginAdmin));
            this.pic_Information = new System.Windows.Forms.PictureBox();
            this.pic_Hide = new System.Windows.Forms.PictureBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.pnl__Login = new Guna.UI2.WinForms.Guna2Panel();
            this.pic_LogoShop = new System.Windows.Forms.PictureBox();
            this.lbl_ContinueAsAdmin = new System.Windows.Forms.Label();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_NameShop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl__Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Information
            // 
            this.pic_Information.Image = ((System.Drawing.Image)(resources.GetObject("pic_Information.Image")));
            this.pic_Information.Location = new System.Drawing.Point(12, 226);
            this.pic_Information.Name = "pic_Information";
            this.pic_Information.Size = new System.Drawing.Size(50, 50);
            this.pic_Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Information.TabIndex = 103;
            this.pic_Information.TabStop = false;
            this.pic_Information.Click += new System.EventHandler(this.pic_Information_Click);
            // 
            // pic_Hide
            // 
            this.pic_Hide.Image = ((System.Drawing.Image)(resources.GetObject("pic_Hide.Image")));
            this.pic_Hide.Location = new System.Drawing.Point(12, 282);
            this.pic_Hide.Name = "pic_Hide";
            this.pic_Hide.Size = new System.Drawing.Size(50, 50);
            this.pic_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hide.TabIndex = 102;
            this.pic_Hide.TabStop = false;
            this.pic_Hide.Click += new System.EventHandler(this.pic_Hide_Click);
            // 
            // pic_Exit
            // 
            this.pic_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_Exit.Image")));
            this.pic_Exit.Location = new System.Drawing.Point(12, 338);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(50, 50);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 101;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // pnl__Login
            // 
            this.pnl__Login.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnl__Login.Controls.Add(this.pic_LogoShop);
            this.pnl__Login.Controls.Add(this.lbl_ContinueAsAdmin);
            this.pnl__Login.Controls.Add(this.btn_Login);
            this.pnl__Login.Controls.Add(this.txt_Password);
            this.pnl__Login.Controls.Add(this.lbl_Password);
            this.pnl__Login.Controls.Add(this.lbl_NameShop);
            this.pnl__Login.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl__Login.Location = new System.Drawing.Point(68, 0);
            this.pnl__Login.Name = "pnl__Login";
            this.pnl__Login.Size = new System.Drawing.Size(732, 400);
            this.pnl__Login.TabIndex = 104;
            // 
            // pic_LogoShop
            // 
            this.pic_LogoShop.Image = ((System.Drawing.Image)(resources.GetObject("pic_LogoShop.Image")));
            this.pic_LogoShop.Location = new System.Drawing.Point(135, 12);
            this.pic_LogoShop.Name = "pic_LogoShop";
            this.pic_LogoShop.Size = new System.Drawing.Size(96, 72);
            this.pic_LogoShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_LogoShop.TabIndex = 97;
            this.pic_LogoShop.TabStop = false;
            // 
            // lbl_ContinueAsAdmin
            // 
            this.lbl_ContinueAsAdmin.AutoSize = true;
            this.lbl_ContinueAsAdmin.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContinueAsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_ContinueAsAdmin.Location = new System.Drawing.Point(117, 342);
            this.lbl_ContinueAsAdmin.Name = "lbl_ContinueAsAdmin";
            this.lbl_ContinueAsAdmin.Size = new System.Drawing.Size(204, 24);
            this.lbl_ContinueAsAdmin.TabIndex = 95;
            this.lbl_ContinueAsAdmin.Text = "Continue As Account.";
            this.lbl_ContinueAsAdmin.Click += new System.EventHandler(this.lbl_ContinueAsAdmin_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.AutoRoundedCorners = true;
            this.btn_Login.BorderRadius = 25;
            this.btn_Login.BorderThickness = 1;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(121, 286);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(510, 53);
            this.btn_Login.TabIndex = 94;
            this.btn_Login.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.AutoRoundedCorners = true;
            this.txt_Password.BorderColor = System.Drawing.Color.Black;
            this.txt_Password.BorderRadius = 29;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Location = new System.Drawing.Point(121, 186);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Password.MaxLength = 20;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.PlaceholderText = "*********";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(510, 60);
            this.txt_Password.TabIndex = 31;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Password.Location = new System.Drawing.Point(114, 141);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(162, 40);
            this.lbl_Password.TabIndex = 29;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_NameShop
            // 
            this.lbl_NameShop.AutoSize = true;
            this.lbl_NameShop.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_NameShop.Location = new System.Drawing.Point(237, 12);
            this.lbl_NameShop.Name = "lbl_NameShop";
            this.lbl_NameShop.Size = new System.Drawing.Size(375, 72);
            this.lbl_NameShop.TabIndex = 0;
            this.lbl_NameShop.Text = "Hikaru Shop";
            this.lbl_NameShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_LoginAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.pnl__Login);
            this.Controls.Add(this.pic_Information);
            this.Controls.Add(this.pic_Hide);
            this.Controls.Add(this.pic_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_LoginAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.pnl__Login.ResumeLayout(false);
            this.pnl__Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Information;
        private System.Windows.Forms.PictureBox pic_Hide;
        private System.Windows.Forms.PictureBox pic_Exit;
        private Guna.UI2.WinForms.Guna2Panel pnl__Login;
        private System.Windows.Forms.PictureBox pic_LogoShop;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_NameShop;
        private System.Windows.Forms.Label lbl_ContinueAsAdmin;
    }
}