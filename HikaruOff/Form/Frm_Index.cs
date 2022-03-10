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

namespace HikaruOff 
{
    public partial class frm_Index : Form
    {
        //Khởi tạo các biến cho form.
        LoginBUS login;

        //Hàm khởi tạo mặc định.
        public frm_Index()
        {
            InitializeComponent();
            this.login = new LoginBUS();
        }

        public frm_Index(LoginBUS log)
        {
            InitializeComponent();
            this.login = new LoginBUS(log);
        }

        //Hàm hỗ trợ.
        //Hàm làm mới UC và chèn UC mới.
        private void changeuUC(UserControl uC)
        {
            pnl_Index.Controls.Clear();
            uC.Dock = DockStyle.Fill;
            uC.BringToFront();
            pnl_Index.Controls.Add(uC);
        }

        //Hàm action.
        //Mở UC form theo từng button được checked.
        private void btn_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Billing.Checked == true)
            {
                UC_Billing uC = new UC_Billing();
                changeuUC(uC);
            }
            else if (btn_Item.Checked == true)
            {
                UC_Item uC = new UC_Item();
                changeuUC(uC);
            }
            else if (btn_User.Checked == true)
            {
                UC_User uC = new UC_User();
                changeuUC(uC);
            }
            else if (btn_Customer.Checked == true)
            {
                UC_Customer uC = new UC_Customer();
                changeuUC(uC);
            }
            else if (btn_Dashboard.Checked == true)
            {
                UC_Dashboard uC = new UC_Dashboard();
                changeuUC(uC);
            }
            else if (btn_Setting.Checked == true)
            {
                UC_Setting uC = new UC_Setting();
                changeuUC(uC);
            }
        }

        //Show form category.
        private void btn_Category_Click(object sender, EventArgs e)
        {
            frm_Category frm = new frm_Category();
            frm.Show();
        }

        //Ẩn form xuống taskbar.
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Đăng xuất.
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                frm_Login frm = new frm_Login();
                this.Hide();
                frm.Show();
            }
        }

        //Hiển thị version phần mềm.
        private void btn_Information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 \n Update date: 10/03/2022 \n Creater/Editer by V.M.K", "Information App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Hiển thị thông tin tài khoản.
        private void btn_Account_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID: " + login.UserId + "\nName: " + login.UserName + "\nEmail: " + login.UserEmail + "\nOffice: " + login.UserOffice, "Information Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
