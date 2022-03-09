using System;
using HikaruOff.Controller;
using System.Windows.Forms;

namespace HikaruOff
{
    public partial class UC_Customer : UserControl
    {
        //Khởi tạo các biến của form.
        CustomerCtrl customer = new CustomerCtrl();
        int id = 0;

        //Hàm khởi tạo mặc định.
        public UC_Customer()
        {
            InitializeComponent();
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
            rtb_Notes.Text = "";
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Add.Enabled = true;
            customer.ShowDgv(dgv_Customer);
            dtm_BirthDay.Value = DateTime.Now;
            dgv_Customer.Update();
            dgv_Customer.Refresh();
        }

        //Check action.
        bool checkAction()
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Customer Name Missing.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (customer.CheckEmail(txt_Email.Text) == true && btn_Add.Checked == true)
            {
                MessageBox.Show("Customer Email Already Exists.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Phone.TextLength != 10)
            {
                MessageBox.Show("Invalid phone number.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(customer.CheckPhone(txt_Phone.Text) == true && btn_Add.Checked == true)
            {
                MessageBox.Show("Customer Phone Already Exists.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Hàm action.
        //Add customer.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                customer.Add(txt_Name.Text, txt_Email.Text, dtm_BirthDay.Value, cbo_Gender.Text, txt_Phone.Text, rtb_Notes.Text);

                MessageBox.Show("Customer added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Update customer.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                customer.Update(id, txt_Name.Text, txt_Email.Text, dtm_BirthDay.Value, cbo_Gender.Text, txt_Phone.Text, rtb_Notes.Text);

                MessageBox.Show("Customer Updated!!!", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Delete customer.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                customer.Delete(id);
                MessageBox.Show("Customer Deleted!!!", "Delete Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }
        
        //Search customer.
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
                customer.Search(dgv_Customer, txt_Search.Text);
            dgv_Customer.Update();
            dgv_Customer.Refresh();
        }

        //Refresh lại form.
        private void btn_Renew_Click(object sender, EventArgs e)
        {
            refresh();
        }

        //Check click trên dgv.
        private void dgv_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lưu thông tin customer của dòng đã chọn trên dgv.
            id = Convert.ToInt32(dgv_Customer.SelectedRows[0].Cells["CustomerId"].Value);
            txt_Name.Text = dgv_Customer.SelectedRows[0].Cells["CustomerName"].Value.ToString();
            txt_Email.Text = dgv_Customer.SelectedRows[0].Cells["CustomerEmail"].Value.ToString();
            txt_Phone.Text = dgv_Customer.SelectedRows[0].Cells["CustomerPhone"].Value.ToString();
            rtb_Notes.Text = dgv_Customer.SelectedRows[0].Cells["CustomerNotes"].Value.ToString();
            cbo_Gender.Text = dgv_Customer.SelectedRows[0].Cells["CustomerGender"].Value.ToString();


            //Cập nhật trạng thái button.
            btn_Save.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Add.Enabled = false;
        }

        //Chỉ cho phép nhập chữ số vào ô phone.
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
