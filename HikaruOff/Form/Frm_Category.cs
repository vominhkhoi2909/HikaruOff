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

        //Refresh form.
        void refresh()
        {
            txt_NameCategory.Text = "";
            txt_Search.Text = "";
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Add.Enabled = true;
            category.HienThiDgv(dgv_Category);
            dgv_Category.Update();
            dgv_Category.Refresh();
        }

        //Check action.
        bool checkAction()
        {
            if (txt_NameCategory.Text == "")
            {
                MessageBox.Show("Category Name Missing.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (category.checkName(txt_NameCategory.Text) == true)
            {
                MessageBox.Show("Category Name Already Exists.", "Action Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Hàm action.
        //Ẩn form xuống taskbar.
        private void pic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Add category.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(checkAction())
            {
                category.Add(txt_NameCategory.Text);
                MessageBox.Show("Category added!!!", "Add Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        //Update category.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkAction())
            {
                category.Update(id, txt_NameCategory.Text);
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
                    txt_NameCategory.Text = dgv_Category.SelectedRows[0].Cells[1].Value.ToString();
                    id = Convert.ToInt32(dgv_Category.SelectedRows[0].Cells[0].Value);

                    //Cập nhật trạng thái button.
                    btn_Save.Enabled = true;
                    btn_Delete.Enabled = true;
                    btn_Add.Enabled = false;
                }
        
        //Tắt form.
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            changeForm(0);
        }
    }
}
