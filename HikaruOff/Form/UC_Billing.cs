using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HikaruOff.Controller;
using HikaruOff.BUS;

namespace HikaruOff
{
    public partial class UC_Billing : UserControl
    {
        //Khởi tạo biến cho form.
        ItemCtrl item = new ItemCtrl();
        CustomerCtrl customer = new CustomerCtrl();
        SaleCtrl sale = new SaleCtrl();
        LoginBUS login;        
        int id = 0, stock = 0, row = 0, grdTotal = 0;

        //Hàm khởi tạo mặc định của form.
        public UC_Billing()
        {
            InitializeComponent();
            login = new LoginBUS();
            refresh();
        }

        public UC_Billing(LoginBUS log)
        {
            InitializeComponent();
            login = new LoginBUS(log);
            refresh();
        }

        void refresh()
        {
            txt_Price.Text = "";
            txt_Quantily.Text = "";
            txt_ProductName.Text = "";
            txt_Search.Text = "";
            lbl_GrdTotal.Text = "Total 0 VND";
            stock = 0;
            grdTotal = 0;
            row = 0;
            id = 0;
            dgv_ClientBill.Rows.Clear();
            btn_Complete.Enabled = false;
            item.ShowDgv(dgv_ManageItems);
            customer.ShowCbo(cbo_Customer);
        }

        void updateStock()
        {
            for (int i = 0; i < dgv_ClientBill.Rows.Count; i++)
            {
                id = Convert.ToInt32(dgv_ClientBill.Rows[i].Cells["IdProduct"].Value);
                stock = item.GetStock(id);
                int newStock = stock - Convert.ToInt32(dgv_ClientBill.Rows[i].Cells["Quantily"].Value);

                item.Update(id, newStock);
            }
        }

        bool checkAction()
        {
            if(txt_Quantily.Text == "")
            {
                MessageBox.Show("Quantily Missing.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Convert.ToInt32(txt_Quantily.Text) > stock)
            {
                MessageBox.Show("Insufficient inventory.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void pic_AddCustomer_Click(object sender, EventArgs e)
        {
            Frm_CustomerLite frm = new Frm_CustomerLite();
            frm.Show();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                pdcm_Bill.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

                if (ppvd_Bill.ShowDialog() == DialogResult.OK)
                {
                    pdcm_Bill.Print();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            if(grdTotal != 0)
            {
                sale.Add(Convert.ToInt32(cbo_Customer.SelectedValue), login.UserId, grdTotal, DateTime.Now);
                updateStock();
                refresh();

                MessageBox.Show("Completed Bill.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Renew_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void txt_Quantily_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Search item
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
                item.Search(dgv_ManageItems, txt_Search.Text);
            dgv_ManageItems.Update();
            dgv_ManageItems.Refresh();
        }

        private void pdcm_Bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int pID, pQuantily, pPrice, ptotal, pos = 60;
            string pName;

            e.Graphics.DrawString("Hikaru Shop", new Font("Times News Roman", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("NUM PRODUCT PRICE QUANTILY TOTAL", new Font("Times News Roman", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            
            foreach(DataGridViewRow pRow in dgv_ClientBill.Rows)
            {
                pID = Convert.ToInt32(pRow.Cells["Num"].Value);
                pName = pRow.Cells["NameProduct"].Value.ToString();
                pQuantily = Convert.ToInt32(pRow.Cells["Quantily"].Value);
                pPrice = Convert.ToInt32(pRow.Cells["Price"].Value);
                ptotal = Convert.ToInt32(pRow.Cells["Total"].Value);
                
                e.Graphics.DrawString("" + pID, new Font("Times News Roman", 8), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + pName, new Font("Times News Roman", 8), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + pPrice, new Font("Times News Roman", 8), Brushes.Blue, new Point(120, pos)); 
                e.Graphics.DrawString("" + pQuantily, new Font("Times News Roman", 8), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + ptotal, new Font("Times News Roman", 8), Brushes.Blue, new Point(235, pos));
                
                pos += 20;
            }
            e.Graphics.DrawString("Grand Total: " + grdTotal + "đ", new Font("Times News Roman", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("----- Thank you very much!!! -----", new Font("Times News Roman", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));

            pos = 100;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            item.ShowDgv(dgv_ManageItems);
            dgv_ManageItems.Update();
            dgv_ManageItems.Refresh();

            customer.ShowCbo(cbo_Customer);
            cbo_Customer.Update();
            cbo_Customer.Refresh();

        }

        private void btn_AddToBill_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                btn_Complete.Enabled = true;
                int total = Convert.ToInt32(txt_Price.Text) * Convert.ToInt32(txt_Quantily.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv_ClientBill);
                newRow.Cells[0].Value = row + 1;
                newRow.Cells[1].Value = txt_ProductName.Text;
                newRow.Cells[2].Value = txt_Price.Text;
                newRow.Cells[3].Value = txt_Quantily.Text;
                newRow.Cells[4].Value = total;
                newRow.Cells[5].Value = id;
                dgv_ClientBill.Rows.Add(newRow);

                grdTotal = grdTotal + total;
                lbl_GrdTotal.Text = "Total: " + grdTotal + " VND";
                row++;
            }
        }

        private void dgv_ManageItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lưu thông tin item của dòng đã chọn trên dgv.
            id = Convert.ToInt32(dgv_ManageItems.SelectedRows[0].Cells["ItemId"].Value);
            txt_ProductName.Text = dgv_ManageItems.SelectedRows[0].Cells["ItemName"].Value.ToString();
            stock = Convert.ToInt32(dgv_ManageItems.SelectedRows[0].Cells["ItemQuantily"].Value);
            txt_Price.Text = dgv_ManageItems.SelectedRows[0].Cells["ItemSellPrice"].Value.ToString();

            txt_Quantily.Text = "";
        }
    }
}
