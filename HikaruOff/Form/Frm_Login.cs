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
    public partial class frm_Login : Form
    {
        //Khởi tạo các biến của form.
        LoginBUS log = new LoginBUS();
        Login login = new Login();

        //Hàm khởi tạo mặc định.
        public frm_Login()
        {
            InitializeComponent();
        }

        //Hàm hỗ trợ.
        //Hàm check thông tin login.
        bool checkLogin(string user, string pass)
        {
            if (user == "" || pass == "")
            {
                MessageBox.Show("Information Login Missing.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (login.DangNhap(user, pass, log) == false)
            {
                MessageBox.Show("Wrong Login Information.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Hàm action.
        //Hàm xử lý login.
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (checkLogin(txt_Email.Text, txt_Password.Text))
            {
                this.Hide();
                frm_Index frm = new frm_Index(log);
                frm.Show();
            }
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

        //Ẩn phần mềm xuống taskbard.
        private void pic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Hiển thị thông tin version của phần mềm.
        private void pic_Information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 \n Update date: 10/03/2022 \n Creater/Editer by V.M.K", "Information App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Chuyển sang login dưới dạng admin/master.
        private void lbl_ContinueAsAdmin_Click(object sender, EventArgs e)
        {
            Frm_LoginAdmin loginAdmin = new Frm_LoginAdmin();            
            this.Hide();
            loginAdmin.Show();
        }
    }
}
