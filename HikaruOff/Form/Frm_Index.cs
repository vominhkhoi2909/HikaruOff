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
    public partial class frm_Index : Form
    {
        public frm_Index()
        {
            InitializeComponent();
        }

        private void changeuUC(UserControl uC)
        {
            pnl_Index.Controls.Clear();
            uC.Dock = DockStyle.Fill;
            uC.BringToFront();
            pnl_Index.Controls.Add(uC);
        }

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
            else if (btn_Staff.Checked == true)
            {
                UC_Staff uC = new UC_Staff();
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

        private void btn_Category_Click(object sender, EventArgs e)
        {
            frm_Category frm = new frm_Category();
            frm.Show();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
