using System;
using System.Windows.Forms;
using HikaruOff.Controller;

namespace HikaruOff
{
    public partial class frm_Category : Form
    {
        //Khởi tạo các biến của form.
        CategoryCtrl category = new CategoryCtrl();
        int id = 0;

        //Hàm khởi tạo mặc định.
        public frm_Category()
        {
            InitializeComponent();
            refresh();
        }

        //Hàm hỗ trợ.
        //Refresh form.
        void refresh()
        {
            txt_Name.Text = "";
            txt_Search.Text = "";
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Add.Enabled = true;
            category.ShowDgv(dgv_Category);
            dgv_Category.Update();
            dgv_Category.Refresh();
        }

        //Check action.
        bool checkAction()
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Category Name Missing.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (category.CheckName(txt_Name.Text) == true && btn_Add.Enabled == true)
            {
                MessageBox.Show("Category Name Already Exists.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Hàm action.
        //Add category.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(checkAction())
            {
                category.Add(txt_Name.Text);
                MessageBox.Show("Category added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Update category.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                category.Update(id, txt_Name.Text);
                MessageBox.Show("Category Updated!!!", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }
        
        //Delete category.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                category.Delete(id);
                MessageBox.Show("Category Deleted!!!", "Delete Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Search category.
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Search.Text != "")
                category.Search(dgv_Category, txt_Search.Text);            
            dgv_Category.Update();
            dgv_Category.Refresh();
        }

        //Refresh lại form.
        private void btn_Renew_Click(object sender, EventArgs e)
        {
            refresh();
        }

        //Check click trên dgv.
        private void dgv_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lưu thông tin category của dòng đã chọn trên dgv.
            id = Convert.ToInt32(dgv_Category.SelectedRows[0].Cells[0].Value);
            txt_Name.Text = dgv_Category.SelectedRows[0].Cells[1].Value.ToString();

            //Cập nhật trạng thái button.
            btn_Save.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Add.Enabled = false;
        }

        //Ẩn form xuống taskbar.
        private void pic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Tắt form.
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to close form?", "Form Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
