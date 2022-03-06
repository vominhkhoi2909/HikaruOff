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
    public partial class frm_Category : Form
    {
        public frm_Category()
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

            if (idForm == 0)
            {
                var res = MessageBox.Show("Are you sure you want to close form?", "Form Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
        }

        //Chuyển form.
        private void pic_Exit_Click(object sender, EventArgs e)
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
