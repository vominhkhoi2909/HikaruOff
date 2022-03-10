using System;
using HikaruOff.Controller;
using System.Windows.Forms;
using System.Linq;

namespace HikaruOff
{
    public partial class Frm_CustomerLite : Form
    {
        //Khởi tạo các biến của form.
        CustomerCtrl customer = new CustomerCtrl();

        //Hàm khởi tạo mặc định.
        public Frm_CustomerLite()
        {
            InitializeComponent();
        }

        //Hàm hỗ trợ.
        //Check action.
        bool checkAction()
        {
            if (txt_CustomerName.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Customer Information Missing.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_Phone.TextLength != 10)
            {
                MessageBox.Show("Invalid Phone Number.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (customer.CheckPhone(txt_Phone.Text) == true && btn_Add.Checked == true)
            {
                MessageBox.Show("Customer Phone Already Exists.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Hàm action.
        //Add customer..
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                customer.Add(txt_CustomerName.Text, "", DateTime.Now, "", txt_Phone.Text, "");

                MessageBox.Show("Customer added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Check chỉ cho nhập số vào ô txt.
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Tắt form.
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            if (txt_CustomerName.Text == "" && txt_Phone.Text == "")
            {
                this.Hide();
            }
            else
            {
                var res = MessageBox.Show("Are you sure you want to close form?", "Form Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
        }

        //Ẩn form xuống taskbar.
        private void pic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
