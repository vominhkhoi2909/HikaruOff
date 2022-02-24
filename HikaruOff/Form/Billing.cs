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
    public partial class frm_Billing : Form
    {
        public frm_Billing()
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

            if (idForm == 2)
            {
                frm_Category frm = new frm_Category();
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
            else
            {
                this.Hide();

                if (idForm == 1)
                {
                    frm_Billing frm = new frm_Billing();
                    frm.Show();
                }
                else if (idForm == 3)
                {
                    frm_ManageItems frm = new frm_ManageItems();
                    frm.Show();
                }
                else if (idForm == 4)
                {
                    frm_ManageUsers frm = new frm_ManageUsers();
                    frm.Show();
                }
                else if (idForm == 5)
                {
                    frm_Customer frm = new frm_Customer();
                    frm.Show();
                }
                else if (idForm == 6)
                {
                    frm_Dashboard frm = new frm_Dashboard();
                    frm.Show();
                }
                else if (idForm == 7)
                {
                    frm_Setting frm = new frm_Setting();
                    frm.Show();
                }
            }
        }

        //Chuyển form.
        private void pic_Category_Click(object sender, EventArgs e)
        {
            changeForm(2);
        }

        private void lbl_Category_Click(object sender, EventArgs e)
        {
            changeForm(2);
        }

        private void pic_Items_Click(object sender, EventArgs e)
        {
            changeForm(3);
        }

        private void lbl_Items_Click(object sender, EventArgs e)
        {
            changeForm(3);
        }

        private void pic_Staff_Click(object sender, EventArgs e)
        {
            changeForm(4);
        }

        private void lbl_Staff_Click(object sender, EventArgs e)
        {
            changeForm(4);
        }

        private void lbl_Customer_Click(object sender, EventArgs e)
        {
            changeForm(5);
        }

        private void pic_Customer_Click(object sender, EventArgs e)
        {
            changeForm(5);
        }

        private void lbl_Dashboard_Click(object sender, EventArgs e)
        {
            changeForm(6);
        }

        private void pic_Dashboard_Click(object sender, EventArgs e)
        {
            changeForm(6);
        }

        private void lbl_Setting_Click(object sender, EventArgs e)
        {
            changeForm(7);
        }

        private void pic_Setting_Click(object sender, EventArgs e)
        {
            changeForm(7);
        }

        private void pic_Exit_Click(object sender, EventArgs e)
        {
            changeForm(0);
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            changeForm(0);
        }

        //Hàm chức năng khác.
            //Ẩn form vào taskbar.
        private void pic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
