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

        void changeForm(int idForm)
        {
            if(idForm == 1)
            {
                this.Hide();
                frm_Billing frm = new frm_Billing();
                frm.Show();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            changeForm(1);
        }
    }
}
