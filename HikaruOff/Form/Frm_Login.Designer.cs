
namespace HikaruOff
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pnl__Login = new Guna.UI2.WinForms.Guna2Panel();
            this.pic_LogoShop = new System.Windows.Forms.PictureBox();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.lbl_ContinueAsAdmin = new System.Windows.Forms.Label();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_NameShop = new System.Windows.Forms.Label();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.pnl__Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl__Login
            // 
            this.pnl__Login.BackColor = System.Drawing.Color.SeaShell;
            this.pnl__Login.Controls.Add(this.pic_LogoShop);
            this.pnl__Login.Controls.Add(this.lbl_ForgotPassword);
            this.pnl__Login.Controls.Add(this.lbl_ContinueAsAdmin);
            this.pnl__Login.Controls.Add(this.btn_Login);
            this.pnl__Login.Controls.Add(this.txt_Password);
            this.pnl__Login.Controls.Add(this.txt_Email);
            this.pnl__Login.Controls.Add(this.lbl_Password);
            this.pnl__Login.Controls.Add(this.lbl_Email);
            this.pnl__Login.Controls.Add(this.lbl_NameShop);
            this.pnl__Login.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl__Login.Location = new System.Drawing.Point(68, 0);
            this.pnl__Login.Name = "pnl__Login";
            this.pnl__Login.Size = new System.Drawing.Size(732, 400);
            this.pnl__Login.TabIndex = 0;
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
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.AutoSize = true;
            this.lbl_ForgotPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ForgotPassword.ForeColor = System.Drawing.Color.Lime;
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(460, 342);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(171, 24);
            this.lbl_ForgotPassword.TabIndex = 96;
            this.lbl_ForgotPassword.Text = "Forgot password?";
            // 
            // lbl_ContinueAsAdmin
            // 
            this.lbl_ContinueAsAdmin.AutoSize = true;
            this.lbl_ContinueAsAdmin.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContinueAsAdmin.ForeColor = System.Drawing.Color.Lime;
            this.lbl_ContinueAsAdmin.Location = new System.Drawing.Point(117, 342);
            this.lbl_ContinueAsAdmin.Name = "lbl_ContinueAsAdmin";
            this.lbl_ContinueAsAdmin.Size = new System.Drawing.Size(188, 24);
            this.lbl_ContinueAsAdmin.TabIndex = 95;
            this.lbl_ContinueAsAdmin.Text = "Continue As Admin.";
            // 
            // btn_Login
            // 
            this.btn_Login.AutoRoundedCorners = true;
            this.btn_Login.BorderRadius = 25;
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
            this.txt_Password.BorderRadius = 23;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_Password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Location = new System.Drawing.Point(121, 230);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Password.MaxLength = 20;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.PlaceholderText = "*********";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(510, 48);
            this.txt_Password.TabIndex = 31;
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
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Location = new System.Drawing.Point(121, 132);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderText = "Hikaru_Shop@gmail.com";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(510, 48);
            this.txt_Email.TabIndex = 30;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Password.Location = new System.Drawing.Point(114, 185);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(162, 40);
            this.lbl_Password.TabIndex = 29;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Email.Location = new System.Drawing.Point(114, 87);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(103, 40);
            this.lbl_Email.TabIndex = 28;
            this.lbl_Email.Text = "Email";
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
            // pic_Exit
            // 
            this.pic_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_Exit.Image")));
            this.pic_Exit.Location = new System.Drawing.Point(12, 338);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(50, 50);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 98;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.pnl__Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl__Login.ResumeLayout(false);
            this.pnl__Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl__Login;
        private System.Windows.Forms.Label lbl_NameShop;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_ForgotPassword;
        private System.Windows.Forms.Label lbl_ContinueAsAdmin;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private System.Windows.Forms.PictureBox pic_LogoShop;
        private System.Windows.Forms.PictureBox pic_Exit;
    }
}