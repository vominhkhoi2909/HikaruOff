using System;
using HikaruOff.Controller;
using System.Windows.Forms;
using System.Linq;

namespace HikaruOff
{
    public partial class Frm_CustomerLite : Form
    {
        CustomerCtrl customer = new CustomerCtrl();

        public Frm_CustomerLite()
        {
            InitializeComponent();
        }

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                customer.Add(txt_CustomerName.Text, "", DateTime.Now, "", txt_Phone.Text, "");

                MessageBox.Show("Customer added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

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

        private void pic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
