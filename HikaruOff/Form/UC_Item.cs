using System;
using HikaruOff.Controller;
using System.Windows.Forms;

namespace HikaruOff
{
    public partial class UC_Item : UserControl
    {
        //Khởi tạo các biến của form.
        ItemCtrl item = new ItemCtrl();
        CategoryCtrl category = new CategoryCtrl();
        int id = 0, iProfit;

        //Hàm khởi tạo mặc định.
        public UC_Item()
        {
            InitializeComponent();
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
            rtb_Nơtes.Text = "";
            txt_Search.Text = "";
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Add.Enabled = true;
            item.HienThiDgv(dgv_Item);
            category.HienThiCbo(cbo_Category);
            dtm_AddedOn.Value = DateTime.Now;
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
            if (item.checkName(txt_Name.Text) == true && btn_Add.Checked == true)
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

                item.Add(txt_Name.Text, rtb_Nơtes.Text, Convert.ToInt32(cbo_Category.SelectedValue), Convert.ToInt32(txt_Quantily.Text),
                    Convert.ToInt32(txt_BuyPrice.Text), Convert.ToInt32(txt_SellPrice.Text), iProfit, DateTime.Now);

                MessageBox.Show("Category added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Update item.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                iProfit = Convert.ToInt32(txt_SellPrice.Text) - Convert.ToInt32(txt_BuyPrice.Text);

                item.Update(id, txt_Name.Text, rtb_Nơtes.Text, Convert.ToInt32(cbo_Category.SelectedValue), Convert.ToInt32(txt_Quantily.Text),
                    Convert.ToInt32(txt_BuyPrice.Text), Convert.ToInt32(txt_SellPrice.Text), iProfit);
                MessageBox.Show("Category Updated!!!", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Delete item.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                item.Delete(id);
                MessageBox.Show("Category Deleted!!!", "Delete Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
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
            //Lưu thông tin category của dòng đã chọn trên dgv.
            id = Convert.ToInt32(dgv_Item.SelectedRows[0].Cells[0].Value);
            txt_Name.Text = dgv_Item.SelectedRows[0].Cells[1].Value.ToString();
            txt_Quantily.Text = dgv_Item.SelectedRows[0].Cells[3].Value.ToString();
            txt_BuyPrice.Text = dgv_Item.SelectedRows[0].Cells[4].Value.ToString();
            txt_SellPrice.Text = dgv_Item.SelectedRows[0].Cells[5].Value.ToString();
            rtb_Nơtes.Text = dgv_Item.SelectedRows[0].Cells[7].Value.ToString();
            dtm_AddedOn.Value = Convert.ToDateTime(dgv_Item.SelectedRows[0].Cells[8].Value);
            cbo_Category.SelectedValue = dgv_Item.SelectedRows[0].Cells["ItemCategory"].Value.ToString();

            //Cập nhật trạng thái button.
            btn_Save.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Add.Enabled = false;
        }
    }
}
