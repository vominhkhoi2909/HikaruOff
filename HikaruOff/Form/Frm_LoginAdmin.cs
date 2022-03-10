using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HikaruOff.BUS;
using HikaruOff.Class;

namespace HikaruOff
{
    public partial class Frm_LoginAdmin : Form
    {
        //Khởi tạo các biến của form.
        LoginBUS log = new LoginBUS();
        Login login = new Login();


        //Hàm khởi tạo mặc định.
        public Frm_LoginAdmin()
        {
            InitializeComponent();
        }

        //Đăng nhập dưới dạng addmin.
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_Password.Text == "")
            {
                MessageBox.Show("Password Missing.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(login.DangNhap("hikaru_shop@gmail.com", txt_Password.Text, log))
            {
                frm_Index index = new frm_Index(log);
                this.Hide();
                index.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hiển thị thông tin version của app.
        private void pic_Information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 \n Update date: 10/03/2022 \n Creater/Editer by V.M.K", "Information App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Ẩn phần mềm xuống taskbar.
        private void pic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Tắt phần mềm.
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Chuyển về lại login dưới dạng acount.
        private void lbl_ContinueAsAdmin_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            this.Hide();
            login.Show();
        }
    }
}
