using HikaruOff.DataLayer;
using System;
using System.Windows.Forms;

namespace HikaruOff.Controller
{
    class UserCtrl
    {
        //Khởi tạo biến giá trị.
        UserData userData = new UserData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return userData.GetID();
        }

        //Hàm kiểm tra tên có bị trùng.
        public bool CheckName(string uName)
        {
            return userData.CheckUserName(uName);
        }

        //Hàm kiểm tra email có bị trùng.
        public bool CheckEmail(string uEmail)
        {
            return userData.CheckUserEmail(uEmail);
        }

        //Hàm kiểm tra sdt có bị trùng.
        public bool CheckPhone(string uPhone)
        {
            return userData.CheckUserPhone(uPhone);
        }

        //Hàm hiển thị datagridview.
        public void ShowDgv(DataGridView dgv)
        {
            dgv.DataSource = userData.PullListUser().Tables[0];
        }

        //Hàm hiển thị combobox.
        public void ShowCbo(ComboBox cbo)
        {
            cbo.DataSource = userData.PullListUser().Tables[0];
            cbo.DisplayMember = "UserName";
            cbo.ValueMember = "UserId";
        }

        //Hàm xử lý thêm mới.
        public int Add(string uName, string uEmail, DateTime uBirthDay, string uGender, string uPhone, string uPassword, string uOffice, string uNotes)
        {
            return userData.AddUser(uName, uEmail, uBirthDay, uGender, uPhone, uPassword, uOffice, uNotes);
        }

        //Hàm xử lý xóa.
        public int Delete(int uId)
        {
            return userData.DeleteUser(uId);
        }

        //Hàm xử lý cập nhật.
        public int Update(int uId, string uName, string uEmail, DateTime uBirthDay, string uGender, string uPhone, string uPassword, string uOffice, string uNotes)
        {
            return userData.UpdateUser(uId, uName, uEmail, uBirthDay, uGender, uPhone, uPassword, uOffice, uNotes);
        }

        //Hàm xử lý tìm kiếm.
        public void Search(DataGridView dgv, string key)
        {
            dgv.DataSource = userData.SearchUser(key).Tables[0];
        }
    }
}
