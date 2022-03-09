using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HikaruOff
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        //Hàm truyền id form để chuyển form.
        void changeForm(int idForm)
        {
            /*IdForm (id tự quy định.)
            0: X (Close form).
            1: Billing
            2: Cetegory
            3: Items
            4: Staff
            5: Customer
            6: Dashboard
            7: Setting
            8: Login
             */

            if (idForm == 8)
            {
                this.Hide();
                frm_Index frm = new frm_Index();
                frm.Show();
            }
            else if (idForm == 0)
            {
                var res = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
                
        }

        //Chuyển form.
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(login(txt_Email.Text, txt_Password.Text) == true)
                changeForm(8);
        }

        private void pic_Exit_Click(object sender, EventArgs e)
        {
            changeForm(0);
        }

        //Hàm chức năng khác.
        //Hàm check thông tin login.
        bool login(string user, string pass)
        {
            string cmt;

            if (user == "" || pass == "")
            {
                cmt = "Please, Don't leave email or password blank.";
            }
            else
            {
                return true;
            }

            MessageBox.Show(cmt, "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private void pic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_Information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 \n Update date: 10/03/2022 \n Creater/Editer by V.M.K", "Information App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
