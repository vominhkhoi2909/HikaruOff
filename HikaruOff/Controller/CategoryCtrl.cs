using HikaruOff.DataLayer;
using System.Windows.Forms;
using System;

namespace HikaruOff.Controller
{
    class CategoryCtrl
    {
        //Khởi tạo biến giá trị.
        CategoryData categoryData = new CategoryData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return categoryData.GetID();
        }

        //Hàm kiểm tra tên có bị trùng.
        public bool CheckName(string cName)
        {
            return categoryData.CheckCategoryName(cName);
        }

        //Hàm hiển thị datagridview.
        public void ShowDgv(DataGridView dgv)
        {
            dgv.DataSource = categoryData.PullListCategory().Tables[0];
        }

        //Hàm hiển thị combobox.
        public void ShowCbo(ComboBox cbo)
        {
            cbo.DataSource = categoryData.PullListCategory().Tables[0];
            cbo.DisplayMember = "CategoryName";
            cbo.ValueMember = "CategoryId";
        }

        //Hàm xử lý thêm mới.
        public int Add(string cName)
        {
            return categoryData.AddCategory(cName);
        }

        //Hàm xử lý xóa.
        public int Delete(int cId)
        {
            return categoryData.DeleteCategory(cId);
        }

        //Hàm xử lý cập nhật.
        public int Update(int cId, string cName)
        {
            return categoryData.UpdateCategory(cId, cName);
        }

        //Hàm xử lý tìm kiếm.
        public void Search(DataGridView dgv, string key)
        {
            dgv.DataSource = categoryData.SearchCategory(key).Tables[0];
        }
    }
}
