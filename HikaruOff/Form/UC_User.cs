using System;
using HikaruOff.Controller;
using HikaruOff.BUS;
using System.Windows.Forms;
using System.Linq;

namespace HikaruOff
{
    public partial class UC_User : UserControl
    {
        //Khởi tạo các biến của form.
        UserCtrl user = new UserCtrl();
        LoginBUS login;
        int id = 0;

        //Hàm khởi tạo mặc định.
        public UC_User()
        {
            InitializeComponent();
            login = new LoginBUS();
            refresh();
        }

        //Hàm hỗ trợ.
        //Refresh form.
        void refresh()
        {
            txt_Name.Text = "";
            txt_Email.Text = "";
            txt_Phone.Text = "";
            txt_Search.Text = "";
            txt_Password.Text = "";
            rtb_Notes.Text = "";
            dtm_BirthDay.Value = DateTime.Now;

            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Add.Enabled = true;

            if(login.UserOffice == "Master" || login.UserOffice == "Admin")
            {
                user.ShowDgv(dgv_User);
                dgv_User.Update();
                dgv_User.Refresh();
            }

            txt_Password.UseSystemPasswordChar = true;
            pic_PasswordShow.Hide();
            pic_PasswordHide.Show();
        }

        //Check action.
        bool checkAction()
        {
            if (txt_Name.Text == "" || txt_Email.Text == "" || txt_Password.Text == "" || txt_Phone.Text == "" || cbo_Office.Text == "")
            {
                MessageBox.Show("Information Missing.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (user.CheckEmail(txt_Email.Text) == true && btn_Add.Checked == true)
            {
                MessageBox.Show("User Email Already Exists.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!this.txt_Email.Text.Contains('@') || !this.txt_Email.Text.Contains('.'))
            {
                MessageBox.Show("Invalid Email.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txt_Phone.TextLength != 10)
            {
                MessageBox.Show("Invalid Phone Number.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (user.CheckPhone(txt_Phone.Text) == true && btn_Add.Checked == true)
            {
                MessageBox.Show("User Phone Already Exists.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Hàm action.
        //Add user.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                if(cbo_Office.Text == "Master" && login.UserOffice == "Master")
                {
                    user.Add(txt_Name.Text, txt_Email.Text, dtm_BirthDay.Value, cbo_Gender.Text, txt_Phone.Text, txt_Password.Text, cbo_Office.Text, rtb_Notes.Text);
                    MessageBox.Show("User added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else if (cbo_Office.Text != "Master" && (login.UserOffice == "Master" || login.UserOffice == "Admin"))
                {
                    user.Add(txt_Name.Text, txt_Email.Text, dtm_BirthDay.Value, cbo_Gender.Text, txt_Phone.Text, txt_Password.Text, cbo_Office.Text, rtb_Notes.Text);
                    MessageBox.Show("User added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("You are not authorized.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Update user.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                if (cbo_Office.Text == "Master" && login.UserOffice == "Master")
                {
                    user.Update(id, txt_Name.Text, txt_Email.Text, dtm_BirthDay.Value, cbo_Gender.Text, txt_Phone.Text, txt_Password.Text, cbo_Office.Text, rtb_Notes.Text);
                    MessageBox.Show("User Updated!!!", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else if (cbo_Office.Text != "Master" && (login.UserOffice == "Master" || login.UserOffice == "Admin"))
                {
                    user.Update(id, txt_Name.Text, txt_Email.Text, dtm_BirthDay.Value, cbo_Gender.Text, txt_Phone.Text, txt_Password.Text, cbo_Office.Text, rtb_Notes.Text);
                    MessageBox.Show("User Updated!!!", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("You are not authorized.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Delete user.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(cbo_Office.Text == "Master")
            {
                MessageBox.Show("Can't delete master user.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cbo_Office.Text == "Master" || cbo_Office.Text == "Admin")
            {
                var res = MessageBox.Show("Are you sure you want to delete user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    user.Delete(id);
                    MessageBox.Show("User Deleted!!!", "Delete Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
        }

        //Search user.
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if((login.UserOffice == "Master" || login.UserOffice == "Admin") && (txt_Search.Text != ""))
            {
                user.Search(dgv_User, txt_Search.Text);
                dgv_User.Update();
                dgv_User.Refresh();
            }
            else
            {
                MessageBox.Show("You are not authorized.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Refresh lại form.
        private void btn_Renew_Click(object sender, EventArgs e)
        {
            refresh();
        }

        //Check click trên dgv.
        private void dgv_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((login.UserOffice == "Master" || login.UserOffice == "Admin"))
            {
                //Lưu thông tin user của dòng đã chọn trên dgv.
                id = Convert.ToInt32(dgv_User.SelectedRows[0].Cells["UserId"].Value);
                txt_Name.Text = dgv_User.SelectedRows[0].Cells["UserName"].Value.ToString();
                txt_Email.Text = dgv_User.SelectedRows[0].Cells["UserEmail"].Value.ToString();
                txt_Phone.Text = dgv_User.SelectedRows[0].Cells["UserPhone"].Value.ToString();
                txt_Password.Text = dgv_User.SelectedRows[0].Cells["UserPassword"].Value.ToString();
                cbo_Office.Text = dgv_User.SelectedRows[0].Cells["UserOffice"].Value.ToString();
                rtb_Notes.Text = dgv_User.SelectedRows[0].Cells["UserNotes"].Value.ToString();
                cbo_Gender.Text = dgv_User.SelectedRows[0].Cells["UserGender"].Value.ToString();


                //Cập nhật trạng thái button.
                btn_Save.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Add.Enabled = false;
            }
            else
            {
                MessageBox.Show("You are not authorized.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Ẩn password.
        private void pic_PasswordShow_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            pic_PasswordShow.Hide();
            pic_PasswordHide.Show();
        }

        //Hiển thị password.
        private void pic_PasswordHide_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
            pic_PasswordShow.Show();
            pic_PasswordHide.Hide();
        }

        //Chỉ cho phép nhập chữ số vào ô sdt.
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
