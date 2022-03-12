using System;
using HikaruOff.Controller;
using System.Windows.Forms;
using HikaruOff.BUS;

namespace HikaruOff
{
    public partial class UC_Item : UserControl
    {
        //Khởi tạo các biến của form.
        ItemCtrl item = new ItemCtrl();
        CategoryCtrl category = new CategoryCtrl();
        LoginBUS login;
        int id = 0, iProfit;

        //Hàm khởi tạo mặc định.
        public UC_Item()
        {
            InitializeComponent();
            login = new LoginBUS();
            refresh();
        }

        public UC_Item(LoginBUS log)
        {
            InitializeComponent();
            login = new LoginBUS(log);
            refresh();
        }

        //Hàm hỗ trợ.
        //Refresh form.
        void refresh()
        {
            txt_BuyPrice.Text = "";
            txt_Name.Text = "";
            txt_Quantily.Text = "";
            txt_SellPrice.Text = "";
            rtb_Details.Text = "";
            txt_Search.Text = "";
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Add.Enabled = true;
            item.ShowDgv(dgv_Item);
            category.ShowCbo(cbo_Category);
            dtm_AddDate.Value = DateTime.Now;
            dgv_Item.Update();
            dgv_Item.Refresh();
        }

        //Check action.
        bool checkAction()
        {
            if (txt_Name.Text == "" || txt_BuyPrice.Text == "" || txt_SellPrice.Text == "" || txt_Quantily.Text == "")
            {
                MessageBox.Show("Infomation Missing.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (item.CheckName(txt_Name.Text) == true && btn_Add.Checked == true)
            {
                MessageBox.Show("Item Name Already Exists.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Hàm action.
        //Add item.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                iProfit = Convert.ToInt32(txt_SellPrice.Text) - Convert.ToInt32(txt_BuyPrice.Text);
                item.Add(txt_Name.Text, rtb_Details.Text, Convert.ToInt32(cbo_Category.SelectedValue), Convert.ToInt32(txt_Quantily.Text), Convert.ToInt32(txt_BuyPrice.Text), Convert.ToInt32(txt_SellPrice.Text), iProfit, DateTime.Now);

                MessageBox.Show("Item added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Update item.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                iProfit = Convert.ToInt32(txt_SellPrice.Text) - Convert.ToInt32(txt_BuyPrice.Text);
                item.Update(id, txt_Name.Text, rtb_Details.Text, Convert.ToInt32(cbo_Category.SelectedValue), Convert.ToInt32(txt_Quantily.Text), Convert.ToInt32(txt_BuyPrice.Text), Convert.ToInt32(txt_SellPrice.Text), iProfit);
                
                MessageBox.Show("Item Updated!!!", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Delete item.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (login.UserOffice == "Intern")
            {
                MessageBox.Show("You are not authorized.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var res = MessageBox.Show("Are you sure you want to delete item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    item.Delete(id);
                    MessageBox.Show("Item Deleted!!!", "Delete Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }

        }

        //Search item.
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
                item.Search(dgv_Item, txt_Search.Text);
            dgv_Item.Update();
            dgv_Item.Refresh();
        }

        //Refresh lại form.
        private void btn_Renew_Click(object sender, EventArgs e)
        {
            refresh();
        }

        //Check click trên dgv.
        private void dgv_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lưu thông tin item của dòng đã chọn trên dgv.
            id = Convert.ToInt32(dgv_Item.SelectedRows[0].Cells["ItemId"].Value);
            txt_Name.Text = dgv_Item.SelectedRows[0].Cells["ItemName"].Value.ToString();
            txt_Quantily.Text = dgv_Item.SelectedRows[0].Cells["ItemQuantily"].Value.ToString();
            txt_BuyPrice.Text = dgv_Item.SelectedRows[0].Cells["ItemBuyPrice"].Value.ToString();
            txt_SellPrice.Text = dgv_Item.SelectedRows[0].Cells["ItemSellPrice"].Value.ToString();
            rtb_Details.Text = dgv_Item.SelectedRows[0].Cells["ItemDetails"].Value.ToString();
            dtm_AddDate.Value = Convert.ToDateTime(dgv_Item.SelectedRows[0].Cells["ItemAddDate"].Value);
            cbo_Category.SelectedValue = dgv_Item.SelectedRows[0].Cells["ItemCategory"].Value.ToString();

            //Cập nhật trạng thái button.
            btn_Save.Enabled = true;
            btn_Delete.Enabled = true;
        }

        //Chỉ cho phép nhập chữ số vào ô tồn kho.
        private void txt_Quantily_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Chỉ cho phép nhập chữ số vào ô giá bán.
        private void txt_SellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Chỉ cho phép nhập chữ số vào ô giá gốc.
        private void txt_BuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
